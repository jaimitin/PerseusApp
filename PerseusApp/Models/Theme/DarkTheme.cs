using Perseus.Maui.Graphics;

namespace Perseus.App.Models.Theme
{
    public class DarkTheme : BuiltInTheme, IAppTheme
    {
        public static readonly Guid InternalID = Guid.Parse("DDF9011705644CA28C5F224914166739");

        Guid IAppTheme.ID => InternalID;

        public override string Name => "Dark Theme";

        public override ColorFamily PrimaryColor { get; set; } = Color.FromArgb("#512BD4");
        public override ColorFamily SecondaryColor { get; set; } = Color.FromArgb("#DFD8F7");
        public override ColorFamily TertiaryColor { get; set; } = Color.FromArgb("#2B0B98");
        public override ColorFamily NeutralColor { get; set; } = Color.FromArgb("#00FF00");
    }
}
