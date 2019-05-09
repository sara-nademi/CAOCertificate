using System;

namespace CAOCertificate.BusinessObjects
{
    public class PaymentReport
    {
        public string ApplicationName
        {
            get;
            set;
        }

        public int RequestId
        {
            get;
            set;
        }

        public DateTime RequestDateTime
        {
            get;
            set;
        }

        public DateTime PaymentDateTime
        {
            get;
            set;
        }

        public int CertificateId
        {
            get;
            set;
        }

        public string CertificateName
        {
            get;
            set;
        }

        public string Requestkey
        {
            get;
            set;
        }

        public int OrderId
        {
            get;
            set;
        }

        public string SystemPaymentStatus
        {
            get;
            set;
        }

        public EPaymentStatus LastPaymentStatus
        {
            get;
            set;
        }
    }
}
