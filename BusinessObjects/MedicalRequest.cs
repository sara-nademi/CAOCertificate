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
    public partial class MedicalRequest : Request
    {
        #region Primitive Properties
    
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
    
        public virtual byte MedicalStatus
        {
            get;
            set;
        }
    
        public virtual string ExaminationForm
        {
            get;
            set;
        }
    
        public virtual string ParallelExamination
        {
            get;
            set;
        }

        #endregion
        #region Navigation Properties
    
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
    
        public virtual ICollection<Request_Doctor> Request_Doctors
        {
            get
            {
                if (_request_Doctors == null)
                {
                    var newCollection = new FixupCollection<Request_Doctor>();
                    newCollection.CollectionChanged += FixupRequest_Doctors;
                    _request_Doctors = newCollection;
                }
                return _request_Doctors;
            }
            set
            {
                if (!ReferenceEquals(_request_Doctors, value))
                {
                    var previousValue = _request_Doctors as FixupCollection<Request_Doctor>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupRequest_Doctors;
                    }
                    _request_Doctors = value;
                    var newValue = value as FixupCollection<Request_Doctor>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupRequest_Doctors;
                    }
                }
            }
        }
        private ICollection<Request_Doctor> _request_Doctors;
    
        public virtual ICollection<Applicant_Service> Applicant_Services
        {
            get
            {
                if (_applicant_Services == null)
                {
                    var newCollection = new FixupCollection<Applicant_Service>();
                    newCollection.CollectionChanged += FixupApplicant_Services;
                    _applicant_Services = newCollection;
                }
                return _applicant_Services;
            }
            set
            {
                if (!ReferenceEquals(_applicant_Services, value))
                {
                    var previousValue = _applicant_Services as FixupCollection<Applicant_Service>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupApplicant_Services;
                    }
                    _applicant_Services = value;
                    var newValue = value as FixupCollection<Applicant_Service>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupApplicant_Services;
                    }
                }
            }
        }
        private ICollection<Applicant_Service> _applicant_Services;
    
        public virtual ICollection<CheckupForm> CheckupForms
        {
            get
            {
                if (_checkupForms == null)
                {
                    var newCollection = new FixupCollection<CheckupForm>();
                    newCollection.CollectionChanged += FixupCheckupForms;
                    _checkupForms = newCollection;
                }
                return _checkupForms;
            }
            set
            {
                if (!ReferenceEquals(_checkupForms, value))
                {
                    var previousValue = _checkupForms as FixupCollection<CheckupForm>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupCheckupForms;
                    }
                    _checkupForms = value;
                    var newValue = value as FixupCollection<CheckupForm>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupCheckupForms;
                    }
                }
            }
        }
        private ICollection<CheckupForm> _checkupForms;

        #endregion
        #region Association Fixup
    
        private void FixupClinicEntity(Person previousValue)
        {
            if (previousValue != null && previousValue.MedicalRequests.Contains(this))
            {
                previousValue.MedicalRequests.Remove(this);
            }
    
            if (ClinicEntity != null)
            {
                if (!ClinicEntity.MedicalRequests.Contains(this))
                {
                    ClinicEntity.MedicalRequests.Add(this);
                }
                if (ClinicID != ClinicEntity.Id)
                {
                    ClinicID = ClinicEntity.Id;
                }
            }
        }
    
        private void FixupRequest_Doctors(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (Request_Doctor item in e.NewItems)
                {
                    item.MedicalRequestEntity = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (Request_Doctor item in e.OldItems)
                {
                    if (ReferenceEquals(item.MedicalRequestEntity, this))
                    {
                        item.MedicalRequestEntity = null;
                    }
                }
            }
        }
    
        private void FixupApplicant_Services(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (Applicant_Service item in e.NewItems)
                {
                    item.MedicalRequestEntity = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (Applicant_Service item in e.OldItems)
                {
                    if (ReferenceEquals(item.MedicalRequestEntity, this))
                    {
                        item.MedicalRequestEntity = null;
                    }
                }
            }
        }
    
        private void FixupCheckupForms(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (CheckupForm item in e.NewItems)
                {
                    item.MedicalRequestEntity = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (CheckupForm item in e.OldItems)
                {
                    if (ReferenceEquals(item.MedicalRequestEntity, this))
                    {
                        item.MedicalRequestEntity = null;
                    }
                }
            }
        }

        #endregion
    }
}