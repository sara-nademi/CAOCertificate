#region

using System;
using System.Collections.Generic;
using System.Linq;
using Infra.Common;

#endregion

namespace Infra.SecurityManagement
{
    public abstract class SecurityManager
    {
        private readonly Entity_AccessManager _entityAccessManager = new Entity_AccessManager();
        private readonly ResourceManager _resourceManager = new ResourceManager();
        private readonly MemberManager _memberManager = new MemberManager();
        private readonly EntityManager _entityManager = new EntityManager();

        public virtual bool HasAccess(IResource resource, string currentUsername, AccessRightTypes accessRightTypes)
        {
            var entity = _entityManager.FirstOrDefault(p => p.PersonalCardNo == currentUsername);
            return entity != null && HasAccess(resource, entity, accessRightTypes);
        }

        public virtual bool HasAccess(IResource resource, Entity entity, AccessRightTypes accessRightTypes)
        {
            var dbResource = _resourceManager.FirstOrDefault(p => p.ResourceKey == resource.Key);
            return dbResource != null && HasAccess(dbResource.ResourceID, entity.EntityID, accessRightTypes);
        }

        public virtual bool HasAccess(long resourceId, long entityId, AccessRightTypes accessType)
        {
            var status = GetAccessStatus(resourceId, entityId, accessType);

            var result = false;
            switch (status)
            {
                case AccessStatus.Allow:
                    result = true;
                    break;
                case AccessStatus.Deny:
                    result = false;
                    break;
                case AccessStatus.AccessIsNotDefinedForThisEntity:
                    var parents = _memberManager.GetPrents(entityId);
                    if (parents == null) break;
                    foreach (var item in parents)
                    {
                        result = HasAccess(resourceId, item.EntityID, accessType);
                        if (!result)
                            break;
                    }
                    break;
                case AccessStatus.AccessTypeIsNotAvaiableForThisEntity:
                case AccessStatus.ResourceIsNotAvaiable:
                default:
                    result = false;
                    break;
            }

            return result;
        }

        public AccessStatus HasAccessRight(string resourcekey, long entityId, AccessRightTypes accessRightTypes)
        {
            throw new NotImplementedException();
        }

        private AccessStatus GetAccessStatus(long resourceId, long entityId, AccessRightTypes accessType)
        {
            var access =
                _entityAccessManager.GetQuery(p => p.EntityID == entityId && p.ApplicationResourceID == resourceId);

            if (!access.Any())
                return AccessStatus.AccessIsNotDefinedForThisEntity;

            var accessControlItem = IsAccess(access, accessType);

            return accessControlItem == null
                       ? AccessStatus.AccessTypeIsNotAvaiableForThisEntity
                       : ((accessControlItem.IsAccess)
                              ? AccessStatus.Allow
                              : AccessStatus.Deny);
        }

        private Entity_Access IsAccess(IEnumerable<Entity_Access> access, AccessRightTypes accessType)
        {
            return (from accessControlItem in access
                    let temp = accessControlItem.AccessType
                    where (temp | (int) accessType) == temp
                    select accessControlItem).FirstOrDefault();
        }
    }
}