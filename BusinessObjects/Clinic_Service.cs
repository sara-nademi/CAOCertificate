//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace CAOCertificate.BusinessObjects
{
    public partial class Clinic_Service
    {
        #region Primitive Properties
    
        public virtual int Id
        {
            get;
            set;
        }
    
        public virtual int ClinicID
        {
            get { return _clinicID; }
            set
            {
                if (_clinicID != value)
                {
                    if (ClinicEntity != null && ClinicEntity.Id != value)
                    {
                        ClinicEntity = null;
                    }
                    _clinicID = value;
                }
            }
        }
        private int _clinicID;
    
        public virtual int ServicelookupID
        {
            get { return _servicelookupID; }
            set
            {
                if (_servicelookupID != value)
                {
                    if (ServiceLookupEntity != null && ServiceLookupEntity.Id != value)
                    {
                        ServiceLookupEntity = null;
                    }
                    _servicelookupID = value;
                }
            }
        }
        private int _servicelookupID;
    
        public virtual string InsertUserName
        {
            get;
            set;
        }
    
        public virtual System.DateTime InsertDate
        {
            get;
            set;
        }
    
        public virtual string UpdateUserName
        {
            get;
            set;
        }
    
        public virtual Nullable<System.DateTime> UpdateDate
        {
            get;
            set;
        }

        #endregion
        #region Navigation Properties
    
        public virtual Lookup ServiceLookupEntity
        {
            get { return _serviceLookupEntity; }
            set
            {
                if (!ReferenceEquals(_serviceLookupEntity, value))
                {
                    var previousValue = _serviceLookupEntity;
                    _serviceLookupEntity = value;
                    FixupServiceLookupEntity(previousValue);
                }
            }
        }
        private Lookup _serviceLookupEntity;
    
        public virtual Person ClinicEntity
        {
            get { return _clinicEntity; }
            set
            {
                if (!ReferenceEquals(_clinicEntity, value))
                {
                    var previousValue = _clinicEntity;
                    _clinicEntity = value;
                    FixupClinicEntity(previousValue);
                }
            }
        }
        private Person _clinicEntity;

        #endregion
        #region Association Fixup
    
        private void FixupServiceLookupEntity(Lookup previousValue)
        {
            if (previousValue != null && previousValue.Clinik_Services.Contains(this))
            {
                previousValue.Clinik_Services.Remove(this);
            }
    
            if (ServiceLookupEntity != null)
            {
                if (!ServiceLookupEntity.Clinik_Services.Contains(this))
                {
                    ServiceLookupEntity.Clinik_Services.Add(this);
                }
                if (ServicelookupID != ServiceLookupEntity.Id)
                {
                    ServicelookupID = ServiceLookupEntity.Id;
                }
            }
        }
    
        private void FixupClinicEntity(Person previousValue)
        {
            if (previousValue != null && previousValue.Clinic_Services.Contains(this))
            {
                previousValue.Clinic_Services.Remove(this);
            }
    
            if (ClinicEntity != null)
            {
                if (!ClinicEntity.Clinic_Services.Contains(this))
                {
                    ClinicEntity.Clinic_Services.Add(this);
                }
                if (ClinicID != ClinicEntity.Id)
                {
                    ClinicID = ClinicEntity.Id;
                }
            }
        }

        #endregion
    }
}