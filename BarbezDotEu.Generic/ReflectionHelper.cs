// Copyright (c) Hannes Barbez. All rights reserved.
// Licensed under the GNU General Public License v3.0

namespace BarbezDotEu.Generic
{
    /// <summary>
    /// Provides reflection-based helper extension methods.
    /// Adapted from https://stackoverflow.com/a/1954663 and other sources.
    /// </summary>
    public static class ReflectionHelper
    {
        /// <summary>
        /// Retrieves the value of a specified property from an object.
        /// Example usage:
        /// <code>
        /// DateTime now = DateTime.Now;
        /// int min = now.GetPropertyValue<int>("TimeOfDay.Minutes");
        /// int hrs = now.GetPropertyValue<int>("TimeOfDay.Hours");
        /// </code>
        /// </summary>
        /// <typeparam name="T">The expected type of the property value.</typeparam>
        /// <param name="object">The source object.</param>
        /// <param name="propertyName">The name of the property, supporting nested properties.</param>
        /// <returns>The property value if found; otherwise, the default value of <typeparamref name="T"/>.</returns>
        public static T GetPropertyValue<T>(this object @object, string propertyName)
        {
            var propertyValue = GetPropertyValue(@object, propertyName);
            if (propertyValue == null)
                return default;

            return propertyValue is T result ? result : default;
        }

        /// <summary>
        /// Recursively retrieves the value of a nested property from an object.
        /// </summary>
        /// <param name="object">The source object.</param>
        /// <param name="propertyName">The property name, supporting dot-separated paths (e.g., "TimeOfDay.Minutes").</param>
        /// <returns>The retrieved property value or <c>null</c> if not found.</returns>
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
