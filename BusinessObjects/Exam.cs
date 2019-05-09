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
    public partial class Exam
    {
        #region Primitive Properties
    
        public virtual int Id
        {
            get;
            set;
        }
    
        public virtual string Title
        {
            get;
            set;
        }
    
        public virtual int CertificateId
        {
            get { return _certificateId; }
            set
            {
                if (_certificateId != value)
                {
                    if (CertificateEntity != null && CertificateEntity.Id != value)
                    {
                        CertificateEntity = null;
                    }
                    _certificateId = value;
                }
            }
        }
        private int _certificateId;
    
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
    
        public virtual ICollection<ExamSchedule> ExamSchedules
        {
            get
            {
                if (_examSchedules == null)
                {
                    var newCollection = new FixupCollection<ExamSchedule>();
                    newCollection.CollectionChanged += FixupExamSchedules;
                    _examSchedules = newCollection;
                }
                return _examSchedules;
            }
            set
            {
                if (!ReferenceEquals(_examSchedules, value))
                {
                    var previousValue = _examSchedules as FixupCollection<ExamSchedule>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupExamSchedules;
                    }
                    _examSchedules = value;
                    var newValue = value as FixupCollection<ExamSchedule>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupExamSchedules;
                    }
                }
            }
        }
        private ICollection<ExamSchedule> _examSchedules;

        #endregion
        #region Association Fixup
    
        private void FixupCertificateEntity(Certificate previousValue)
        {
            if (previousValue != null && previousValue.Exams.Contains(this))
            {
                previousValue.Exams.Remove(this);
            }
    
            if (CertificateEntity != null)
            {
                if (!CertificateEntity.Exams.Contains(this))
                {
                    CertificateEntity.Exams.Add(this);
                }
                if (CertificateId != CertificateEntity.Id)
                {
                    CertificateId = CertificateEntity.Id;
                }
            }
        }
    
        private void FixupExamSchedules(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (ExamSchedule item in e.NewItems)
                {
                    item.ExamEntity = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (ExamSchedule item in e.OldItems)
                {
                    if (ReferenceEquals(item.ExamEntity, this))
                    {
                        item.ExamEntity = null;
                    }
                }
            }
        }

        #endregion
    }
}
