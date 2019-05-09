#region

using System;
using System.Collections.Generic;
using System.Xml.Serialization;

#endregion

namespace CAOCertificate.BusinessObjects.Reports
{
    public class Examination
    {
        [XmlAttribute]
        public string Comment { get; set; }

        [XmlAttribute]
        public string PersonRegistrationLocation { get; set; }

        [XmlAttribute]
        public string RegionOfService { get; set; }

        [XmlAttribute]
        public string MaritalStatus { get; set; }

        [XmlAttribute]
        public string Nationality { get; set; }

        [XmlAttribute]
        public string TotalMinutesFlee { get; set; }

        [XmlAttribute]
        public string MintesFleeLastSixMonths { get; set; }

        [XmlAttribute]
        public string YearsOfExperience { get; set; }

        [XmlAttribute]
        public string Address { get; set; }

        [XmlAttribute]
        public string RequestType { get; set; }

        [XmlAttribute]
        public string PreviousExamination { get; set; }

        [XmlAttribute]
        public string PreviousCommittee { get; set; }

        [XmlAttribute]
        public string Sanehe { get; set; }

        [XmlAttribute]
        public string RecentDrugUse { get; set; }

        [XmlAttribute]
        public string DeseaseLegacy { get; set; }

        [XmlArray]
        public List<bool> CheckGrid { get; set; }

        [XmlAttribute]
        public byte[] image { get; set; }

        [XmlAttribute]
        public DateTime applicantBirthDate { get; set; }

        [XmlAttribute]
        public string applicantFirstName { get; set; }

        [XmlAttribute]
        public string applicantLastName { get; set; }

        [XmlAttribute]
        public string applicantIdentity { get; set; }

        [XmlAttribute]
        public string certificateTitle { get; set; }

        [XmlAttribute]
        public DateTime doctorConfirmDate { get; set; }

        [XmlAttribute]
        public string doctorEntityFirstName { get; set; }

        [XmlAttribute]
        public string doctorEntityLastName { get; set; }

        [XmlAttribute]
        public bool C12T11 { get; set; }

        [XmlAttribute]
        public bool C12T12 { get; set; }

        [XmlAttribute]
        public bool C12T13 { get; set; }

        [XmlAttribute]
        public bool C12T14 { get; set; }

        [XmlAttribute]
        public string C12T15 { get; set; }

        [XmlAttribute]
        public bool C13T21 { get; set; }

        [XmlAttribute]
        public bool C13T22 { get; set; }

        [XmlAttribute]
        public string C13T23 { get; set; }

        [XmlAttribute]
        public bool C15T31 { get; set; }

        [XmlAttribute]
        public bool C15T32 { get; set; }

        [XmlAttribute]
        public string C15T33 { get; set; }

        [XmlAttribute]
        public bool C17T41 { get; set; }

        [XmlAttribute]
        public bool C17T42 { get; set; }

        [XmlAttribute]
        public string C17T43 { get; set; }

        [XmlAttribute]
        public bool C18T51 { get; set; }

        [XmlAttribute]
        public bool C18T52 { get; set; }

        [XmlAttribute]
        public string C18T53 { get; set; }

        [XmlAttribute]
        public bool C19T61 { get; set; }

        [XmlAttribute]
        public bool C19T62 { get; set; }

        [XmlAttribute]
        public string C19T63 { get; set; }


        public Examination()
        {
            int max = 50;
            CheckGrid = new List<bool>();
        }

        public bool this[int index]
        {
            get { return CheckGrid[index]; }
            set { CheckGrid[index] = value; }
        }
    }
}