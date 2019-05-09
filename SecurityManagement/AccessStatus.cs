namespace Infra.SecurityManagement
{
    /// <summary>
    /// وضعیت دسترسی به یک ریسورس توسط یک کاربر خاص
    /// </summary>
    public enum AccessStatus
    {
        /// <summary>
        /// به این منبع اجازه دارد
        /// </summary>
        Allow = 0,

        /// <summary>
        /// این منبع دسترسی ندارد
        /// </summary>
        Deny = 1,

        /// <summary>
        /// دسترسی به این منبع برای این کاربر وجود ندار
        /// </summary>
        AccessIsNotDefinedForThisEntity = 2,

        /// <summary>
        /// دسترسی به این منبع با این نوع دسترسی مقدور نیست
        /// </summary>
        AccessTypeIsNotAvaiableForThisEntity = 3,

        /// <summary>
        /// منبع موجود نیست
        /// </summary>
        ResourceIsNotAvaiable = 4,
    }
}