#region

using System;

#endregion

namespace CAOCertificate.BusinessObjects
{
    public static class BusinessExtension
    {
        public static long MapInfraGroupId(this PersonTypes personType)
        {
            switch (personType)
            {
                case PersonTypes.Admin:
                    return 11;
                case PersonTypes.Applicant:
                    return 4;
                case PersonTypes.Company:
                case PersonTypes.CompanyUser:
                    return 5;
                case PersonTypes.Clinic:
                    return 6;
                case PersonTypes.Manager:
                    return 8;
                case PersonTypes.Doctor:
                    return 6;
                case PersonTypes.Assesor:
                    return 7;
                case PersonTypes.Council:
                case PersonTypes.Examiner:
                case PersonTypes.ResponsibleExminer:
                case PersonTypes.OralExaminer:
                case PersonTypes.DispatchOralExaminer:
                case PersonTypes.Certification:
                case PersonTypes.RCertification:
                case PersonTypes.FlightExpert:
                case PersonTypes.ResponsibleAssesor:
                case PersonTypes.Oprator:
                case PersonTypes.StandardDepartment:
                    return 9;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public static string DisplayName(this PersonTypes personType)
        {
            switch (personType)
            {
                case PersonTypes.Applicant:
                    return "متقاضی";
                case PersonTypes.Company:
                    return "شرکت";
                case PersonTypes.Clinic:
                    return "کلینیک";
                case PersonTypes.Manager:
                    return "مدیر سازمان";
                case PersonTypes.Doctor:
                    return "دکتر";
                case PersonTypes.Assesor:
                    return "ارزیاب";
                case PersonTypes.Council:
                    return "شورا";
                case PersonTypes.Admin:
                    return "مدیر سیستم";
                case PersonTypes.CompanyUser:
                    return "کاربر شرکت";
                case PersonTypes.Examiner:
                    return "کارشناس واحد امتحانات";
                case PersonTypes.Certification:
                    return "کارشناس صدور گواهینامه";
                case PersonTypes.ResponsibleAssesor:
                    return "ارزیاب مسئول";
                case PersonTypes.Oprator:
                    return "پیشخوان مرکز";
                case PersonTypes.ResponsibleExminer:
                    return "کارشناس مسئول واحد امتحانات";
                case PersonTypes.FlightExpert:
                    return "معلم پروازی";
                case PersonTypes.StandardDepartment:
                    return "معاونت استاندارد";
                case PersonTypes.RCertification:
                    return "کارشناس مسئول واحد صدور گواهینامه ها";
                case PersonTypes.OralExaminer:
                    return "کارشناس امتحان شفاهی";
                case PersonTypes.DispatchOralExaminer :
                    return "کارشناس امتحان شفاهی Dispatch";

                default:
                    return string.Empty;
            }
        }
    }
}