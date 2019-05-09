using System;

namespace CAOCertificate.BusinessObjects.Reports
{
    public class CompanyPayments
    {
        public string FullName { get; set; }
        public string CompanyName { get; set; }
        public string CertificateType { get; set; }
        public DateTime RequestDate { get; set; }
        public decimal Amount { get; set; }
        public string PaymentTrackCode { get; set; }
        public string NationalCode { get; set; }
        public string RequestTrackCode { get; set; }
        public DateTime PaymentDate { get; set; }
        public string CertificateName { get; set; }
    }
}
