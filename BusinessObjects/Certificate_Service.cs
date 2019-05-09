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
    public partial class Certificate_Service
    {
        #region Primitive Properties
    
        public virtual int Id
        {
            get;
            set;
        }
    
        public virtual int CertificateID
        {
            get { return _certificateID; }
            set
            {
                if (_certificateID != value)
                {
                    if (CertificateEntity != null && CertificateEntity.Id != value)
                    {
                        CertificateEntity = null;
                    }
                    _certificateID = value;
                }
            }
        }
        private int _certificateID;
    
        public virtual int ServiceID
        {
            get { return _serviceID; }
            set
            {
                if (_serviceID != value)
                {
                    if (ServiceLookupEntity != null && ServiceLookupEntity.Id != value)
                    {
                        ServiceLookupEntity = null;
                    }
                    _serviceID = value;
                }
            }
        }
        private int _serviceID;
    
        public virtual Nullable<int> ValidAge
        {
            get;
            set;
        }
    
        public virtual bool IsInitial
        {
            get { return _isInitial; }
            set { _isInitial = value; }
        }
        private bool _isInitial = false;
    
        public virtual int ToAge
        {
            get { return _toAge; }
            set { _toAge = value; }
        }
        private int _toAge = 0;
    
        public virtual int FromAge
        {
            get { return _fromAge; }
            set { _fromAge = value; }
        }
        private int _fromAge = 0;
    
        public virtual int ValidPeriod
        {
            get { return _validPeriod; }
            set { _validPeriod = value; }
        }
        private int _validPeriod = 0;

        #endregion
        #region Navigation Properties
    
        public virtual Certificate CertificateEntity
        {
            get { return _certificateEntity; }
            set
            {
                if (!ReferenceEquals(_certificateEntity, value))
                {
                    var previousValue = _certificateEntity;
                    _certificateEntity = value;
                    FixupCertificateEntity(previousValue);
                }
            }
        }
        private Certificate _certificateEntity;
    
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

        #endregion
        #region Association Fixup
    
        private void FixupCertificateEntity(Certificate previousValue)
        {
            if (previousValue != null && previousValue.Certificate_Services.Contains(this))
            {
                previousValue.Certificate_Services.Remove(this);
            }
    
            if (CertificateEntity != null)
            {
                if (!CertificateEntity.Certificate_Services.Contains(this))
                {
                    CertificateEntity.Certificate_Services.Add(this);
                }
                if (CertificateID != CertificateEntity.Id)
                {
                    CertificateID = CertificateEntity.Id;
                }
            }
        }
    
        private void FixupServiceLookupEntity(Lookup previousValue)
        {
            if (previousValue != null && previousValue.Certificate_Services.Contains(this))
            {
                previousValue.Certificate_Services.Remove(this);
            }
    
            if (ServiceLookupEntity != null)
            {
                if (!ServiceLookupEntity.Certificate_Services.Contains(this))
                {
                    ServiceLookupEntity.Certificate_Services.Add(this);
                }
                if (ServiceID != ServiceLookupEntity.Id)
                {
                    ServiceID = ServiceLookupEntity.Id;
                }
            }
        }

        #endregion
    }
}
