﻿using System;

namespace DoItLess.DotNet.Extensions
{
    public static partial class ObjectExtensions
    {
        /// <summary>
        ///     是否DBNull
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        /// <example>
        ///     <code>
        ///         <![CDATA[
        /// var value = DBNull.Value;
        /// value.IsDBNull(); // true
        ///         ]]>
        ///     </code>
        /// </example>
        // ReSharper disable once InconsistentNaming
        public static bool IsDBNull(this object @this)
        {
            return Convert.IsDBNull(@this);
        }
    }
}