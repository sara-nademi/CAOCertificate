#region

using System;

#endregion

namespace Infra.SecurityManagement
{
    /// <summary>
    /// انواع حق دسترسی
    /// </summary>
    [Flags]
    public enum AccessRightTypes
    {
        //TODO add other types

        /// <summary>
        /// 1
        /// </summary>
        View = 1,

        /// <summary>
        /// 2
        /// </summary>
        Add = 2,

        /// <summary>
        /// 4
        /// </summary>
        Delete = 4,

        /// <summary>
        /// 8
        /// </summary>
        Edit = 8
    }
}