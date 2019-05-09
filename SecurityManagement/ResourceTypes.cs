#region

using System;

#endregion

namespace Infra.SecurityManagement
{
    /// <summary>
    /// انواع منابع سیستم
    /// </summary>
    [Flags]
    public enum ResourceTypes
    {
        Menu = 1,
        Form = 2,
        Action = 3
    }
}