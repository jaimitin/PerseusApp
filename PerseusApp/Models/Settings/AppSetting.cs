using Perseus.Core;
using Perseus.Core.Extensions;

namespace Perseus.App.Models.Settings
{
    /// <summary>
    /// An application setting
    /// </summary>
    public class AppSetting<T> : PerseusObject, IAppSetting<T>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppSetting{T}"/> class for a setting with a <paramref name="key"/> and <paramref name="defaultValue"/>
        /// </summary>
        public AppSetting(string key, T defaultValue)
        {
            if(key.IsNullOrWhiteSpace())
            {
                throw new ArgumentException($"'{nameof(key)}' cannot be null or whitespace.", nameof(key));
            }

            Key = key;
            DefaultValue = defaultValue;
        }

        public string Key { get; init; }

        public T DefaultValue { get; init; }

        public string? Name { get; init; }

        public string? Description { get; init; }

        // Not planning on using shared settings for the time being
        //public string? SharedName { get; }
        //public bool IsShared => !SharedName.IsNullOrWhiteSpace();
    }
}
