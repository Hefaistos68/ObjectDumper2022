﻿using System;
using System.Reflection;

namespace ObjectFormatter.ObjectDumper.NET.Embedded
{
    internal static class PropertyInfoExtensions
    {
        internal static object TryGetValue(this PropertyInfo property, object element)
        {
            object value;
            try
            {
                value = property.GetValue(element);
            }
            catch (Exception ex)
            {
                value = $"{{{ex.GetType().Name}: {ex.Message}}}";
            }

            return value;
        }
    }
}