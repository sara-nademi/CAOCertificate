#region

using System;

#endregion

namespace CAOCertificate.BusinessObjects
{
    [Flags]
    public enum CertificateType
    {
        MedicalCertificate = 0,
        OpratingCertificate = 2,
        TechnicalCertificate = 3
    }

    [Flags]
    public enum Certificates
    {
        Ir = 32,
        Pplo = 15,
        Cplo = 14
    }
}