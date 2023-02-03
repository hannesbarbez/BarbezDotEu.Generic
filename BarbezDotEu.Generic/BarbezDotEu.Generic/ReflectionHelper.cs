// Copyright (c) Hannes Barbez. All rights reserved.
// Licensed under the GNU General Public License v3.0

namespace BarbezDotEu.Generic
{
    /// <summary>
    /// Generic helper extension method adapted for Reflection from https://stackoverflow.com/a/1954663, amongst others.
    /// </summary>
    public static class ReflectionHelper
    {
        /// <summary>
        /// Example use: DateTime now = DateTime.Now;
        /// int min = GetPropertyValue&lt;int&gt;(now, "TimeOfDay.Minutes");
        /// int hrs = now.GetPropertyValue&lt;int&gt;("TimeOfDay.Hours");
        /// </summary>
        public static T GetPropertyValue<T>(this object @object, string propertyName)
        {
            var propertyValue = GetPropertyValue(@object, propertyName);
            if (propertyValue == null)
                return default;

            if (propertyValue is T result)
                return result;

            return default;
        }

        private static object GetPropertyValue(this object @object, string propertyName)
        {
            foreach (var subPropertyName in propertyName.Split('.'))
            {
                if (@object == null)
                    return null;

                var type = @object.GetType();
                var info = type.GetProperty(subPropertyName);
                if (info == null)
                    return null;

                @object = info.GetValue(@object, null);
            }

            return @object;
        }

    }
}
