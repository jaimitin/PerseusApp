namespace Perseus.App.Models.Settings
{
    /// <summary>
    /// Represents an application setting
    /// </summary>
    public interface IAppSetting<T>
    {
        /// <summary>
        /// The setting's <b>unique</b> key 
        /// </summary>
        string Key { get; }

        /// <summary>
        /// The setting's default value
        /// </summary>
        /// <remarks>
        /// This property should never be <see langword="null"/>
        /// </remarks>
        T DefaultValue { get; }

        /// <summary>
        /// The setting's name
        /// </summary>
        string? Name { get; }

        /// <summary>
        /// The setting's description
        /// </summary>
        string? Description { get; }


        // Not planning on using shared settings for the time being
        /// <summary>
        /// The setting's shared name across applications
        /// </summary>
        //string? SharedName { get; }

        /// <summary>
        /// Whether the property is shared across applications
        /// </summary>
        //bool IsShared { get; }
    }
}
