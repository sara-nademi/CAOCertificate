#region

using System;

#endregion

namespace CAOCertificate.BusinessObjects
{
    [Serializable]
    public class JsonResult
    {
        public string Message { get; set; }

        public bool IsValid { get; set; }

        public JsonResult()
        {
            IsValid = false;
        }
    }
}