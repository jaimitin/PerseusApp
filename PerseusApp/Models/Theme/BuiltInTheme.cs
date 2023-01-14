namespace Perseus.App.Models.Theme
{
    /// <summary>
    /// A built in application theme
    /// </summary>
    public abstract class BuiltInTheme : AppThemeBase, IAppTheme
    {
        public override bool IsCustom => false;
    }
}
