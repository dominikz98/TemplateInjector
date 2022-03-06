using CssTemplateInjector.Contracts;

namespace CssTemplateInjector.Models
{
    public class Theme
    {
        public string Primary { get; set; }
        public string Secondary { get; set; }
        public string Background { get; set; }
        public string Surface { get; set; }
        public string Menu { get; set; }

        public Theme(string primary, string secondary, string background, string surface, string menu)
        {
            Primary = primary;
            Secondary = secondary;
            Background = background;
            Surface = surface;
            Menu = menu;
        }

        public string GetColor(ThemeColor color)
            => color switch
            {
                ThemeColor.Primary => Primary,
                ThemeColor.Secondary => Secondary,
                ThemeColor.Background => Background,
                ThemeColor.Surface => Surface,
                ThemeColor.Menu => Menu,
                _ => "white"
            };
    }
}
