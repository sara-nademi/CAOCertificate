using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Infra.Common;

namespace Infra.SecurityManagement
{
    public class ResourceInstaller
    {
        private bool _isSafeInsert;
        private readonly ResourceManager _resourceManager;

        internal static Dictionary<long, string> Dictionary = new Dictionary<long, string>();

        public bool IsSafeInsert
        {
            get { return _isSafeInsert; }
            set { _isSafeInsert = value; }
        }

        public ResourceInstaller() : this(false)
        {
        }

        public ResourceInstaller(bool safeInsert = false)
        {
            _isSafeInsert = safeInsert;
            _resourceManager = new ResourceManager();
        }

        public void Install(Assembly assembly, string @namesapce)
        {
            assembly.GetTypes().Where(p => p.IsClass
                                           && p.Namespace == @namesapce
                                           && p.ContainInterface("IResource")
                                           && p.ContainAttribute(typeof (ParentAttribute)))
                .ToList()
                .ForEach(p => RecursiveResourceOpration(p, p.GetProperties(), 0));
        }

        private void RecursiveResourceOpration(Type classType, IEnumerable<PropertyInfo> properties, long parentId)
        {
            var obj = Activator.CreateInstance(classType);
            var resource = new Resource();
            //TODO fill valid subscriperID
            resource.SubscriberID = 2;
            if (parentId != 0)
                resource.ParentResourceID = parentId;

            foreach (var property in properties)
            {
                if (property.PropertyType.ContainInterface("IResource"))
                {
                    parentId = InsertOrDefault(resource);

                    RecursiveResourceOpration(property.PropertyType, property.PropertyType.GetProperties(), parentId);
                }
                else
                {
                    var val = property.GetValue(obj, null);
                    FillResource(property.Name, val, resource);
                }
            }

            if (resource.ResourceID == 0)
                InsertOrDefault(resource);
        }

        private static void FillResource(string name, object val, Resource resource)
        {
            if (val == null) return;

            switch (name)
            {
                case "Key":
                    resource.ResourceKey = val.ToString();
                    break;
                case "Title":
                    resource.Title = val.ToString();
                    break;
                case "Comment":
                    resource.Comment = val.ToString();
                    break;
            }
        }

        private long InsertOrDefault(Resource resource)
        {
            if (!ExistResource(resource))
                Insert(resource);
            else if (_isSafeInsert)
            {
                //if exist in db,update in db and then add resource to dic
                var currentResource =
                    _resourceManager.FirstOrDefault(
                        p => p.ResourceKey == resource.ResourceKey && p.SubscriberID == resource.SubscriberID);
                currentResource.Title = resource.Title;
                currentResource.Comment = resource.Comment;
                _resourceManager.Update(currentResource);
            }
            return Dictionary.First(p => p.Value == resource.ResourceKey).Key;
        }

        private bool ExistResource(Resource resource)
        {
            if (Dictionary.Any(p => p.Value == resource.ResourceKey)) return true;

            if (_isSafeInsert)
            {
                var currentResource =
                    _resourceManager.FirstOrDefault(
                        p => p.ResourceKey == resource.ResourceKey && p.SubscriberID == resource.SubscriberID);
                if (currentResource == null)
                    return false;

                AddToDictionary(currentResource);
                return true;
            }

            return false;
        }

        private static void AddToDictionary(Resource resource)
        {
            Dictionary.Add(resource.ResourceID, resource.ResourceKey);
        }

        private void Insert(Resource resource)
        {
            resource.InsertDate = DateTime.Now;
            resource.InsertUser = "arash-Convertor";
            resource.SubscriberID = 2;
            _resourceManager.Insert(resource);

            AddToDictionary(resource);
        }
    }
}