﻿namespace DoItLess.DotNet.Extensions
{
    public static partial class ObjectExtensions
    {
        /// <summary>
        /// 是否 null
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        /// 
        public static bool IsNull(this object @this)
        {
            return @this == null;
        }
    }
}