using Perseus.App.Util;
using Perseus.Core;
using Perseus.Core.Extensions;
using Perseus.Maui.Graphics;
using System.Reflection;

namespace Perseus.App.Models.Theme
{
    /// <summary>
    /// Base class for all application themes
    /// </summary>
    public abstract class AppThemeBase : PerseusObject, IAppTheme
    {
        public abstract string Name { get; }

        public abstract bool IsCustom { get; }

        public abstract ColorFamily PrimaryColor { get; set; }
        public abstract ColorFamily SecondaryColor { get; set; }
        public abstract ColorFamily TertiaryColor { get; set; }
        public abstract ColorFamily NeutralColor { get; set; }

        public virtual ResourceDictionary CreateResourceDictionary()
        {
            ResourceDictionary resourceDictionary = new();

            LoadThemeColor(ThemeKeys.Primary, resourceDictionary, PrimaryColor);
            LoadThemeColor(ThemeKeys.Secondary, resourceDictionary, SecondaryColor);
            LoadThemeColor(ThemeKeys.Tertiary, resourceDictionary, TertiaryColor);
            LoadThemeColor(ThemeKeys.Neutral, resourceDictionary, NeutralColor);

            return resourceDictionary;
        }

        /// <summary>
        /// Load the specified <paramref name="color"/> styles into the specified <paramref name="resourceDictionary"/>
        /// </summary>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="ArgumentNullException"></exception>
        protected virtual void LoadThemeColor(string colorType, ResourceDictionary resourceDictionary, ColorFamily color)
        {
            if(colorType.IsNullOrEmpty())
            {
                throw new ArgumentException($"'{nameof(colorType)}' cannot be null or empty.", nameof(colorType));
            }

            foreach(PropertyInfo property in color.GetType().GetProperties())
            {
                string key = property.Name;

                key = key == nameof(ColorFamily.Color)
                    ? colorType
                    : colorType + key;

                object? value = property.GetValue(color);

                if(!key.IsNullOrEmpty() && value != null)
                {
                    resourceDictionary.Add(key, value);
                }
            }
        }
    }
}
