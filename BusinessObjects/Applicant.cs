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
    public partial class Applicant : Person
    {
        #region Primitive Properties
    
        public virtual string NationalCode
        {
            get;
            set;
        }
    
        public virtual byte[] Picture
        {
            get;
            set;
        }
    
        public virtual string FatherName
        {
            get;
            set;
        }
    
        public virtual System.DateTime BirthDate
        {
            get;
            set;
        }
    
        public virtual string PassportNo
        {
            get;
            set;
        }
    
        public virtual string IdentityNo
        {
            get;
            set;
        }
    
        public virtual string ArnCode
        {
            get;
            set;
        }
    
        public virtual string Nationality
        {
            get;
            set;
        }
    
        public virtual string BirthPlace
        {
            get;
            set;
        }
    
        public virtual string Telephone
        {
            get;
            set;
        }
    
        public virtual string LastDegree
        {
            get;
            set;
        }
    
        public virtual Nullable<double> LastDegreeAvgGrade
        {
            get;
            set;
        }
    
        public virtual string Email
        {
            get;
            set;
        }
    
        public virtual string MilitaryServiceStatus
        {
            get;
            set;
        }
    
        public virtual string MilitaryExempt
        {
            get;
            set;
        }

        #endregion
        #region Navigation Properties
    
        public virtual ICollection<Applicant_Certificate> Applicant_Certificates
        {
            get
            {
                if (_applicant_Certificates == null)
                {
                    var newCollection = new FixupCollection<Applicant_Certificate>();
                    newCollection.CollectionChanged += FixupApplicant_Certificates;
                    _applicant_Certificates = newCollection;
                }
                return _applicant_Certificates;
            }
            set
            {
                if (!ReferenceEquals(_applicant_Certificates, value))
                {
                    var previousValue = _applicant_Certificates as FixupCollection<Applicant_Certificate>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupApplicant_Certificates;
                    }
                    _applicant_Certificates = value;
                    var newValue = value as FixupCollection<Applicant_Certificate>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupApplicant_Certificates;
                    }
                }
            }
        }
        private ICollection<Applicant_Certificate> _applicant_Certificates;
    
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
    
        public virtual ICollection<Applicant_limitation> Applicant_limitations
        {
            get
            {
                if (_applicant_limitations == null)
                {
                    var newCollection = new FixupCollection<Applicant_limitation>();
                    newCollection.CollectionChanged += FixupApplicant_limitations;
                    _applicant_limitations = newCollection;
                }
                return _applicant_limitations;
            }
            set
            {
                if (!ReferenceEquals(_applicant_limitations, value))
                {
                    var previousValue = _applicant_limitations as FixupCollection<Applicant_limitation>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupApplicant_limitations;
                    }
                    _applicant_limitations = value;
                    var newValue = value as FixupCollection<Applicant_limitation>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupApplicant_limitations;
                    }
                }
            }
        }
        private ICollection<Applicant_limitation> _applicant_limitations;

        #endregion
        #region Association Fixup
    
        private void FixupApplicant_Certificates(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (Applicant_Certificate item in e.NewItems)
                {
                    item.ApplicantEntity = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (Applicant_Certificate item in e.OldItems)
                {
                    if (ReferenceEquals(item.ApplicantEntity, this))
                    {
                        item.ApplicantEntity = null;
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
                    item.ApplicantEntity = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (Applicant_Service item in e.OldItems)
                {
                    if (ReferenceEquals(item.ApplicantEntity, this))
                    {
                        item.ApplicantEntity = null;
                    }
                }
            }
        }
    
        private void FixupApplicant_limitations(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (Applicant_limitation item in e.NewItems)
                {
                    item.ApplicantEntity = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (Applicant_limitation item in e.OldItems)
                {
                    if (ReferenceEquals(item.ApplicantEntity, this))
                    {
                        item.ApplicantEntity = null;
                    }
                }
            }
        }

        #endregion
    }
}
