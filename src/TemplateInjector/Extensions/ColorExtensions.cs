using CssTemplateInjector.Contracts;
using CssTemplateInjector.Models;
using System.Drawing;

namespace CssTemplateInjector.Extensions
{
    public static class ColorExtensions
    {
        public static Color GetRGBA(this Theme theme, ThemeColor color, Opacity opacity = Opacity.P100)
        {
            var hex = theme.GetColor(color);
            return ColorTranslator.FromHtml(hex);
        }

        public static string GetHex(this Theme theme, ThemeColor color, Opacity opacity = Opacity.P100)
        {
            var hex = theme.GetColor(color);
            var alpha = opacity switch
            {
                Opacity.P0 => "00",
                Opacity.P10 => "1a",
                Opacity.P20 => "33",
                Opacity.P30 => "4d",
                Opacity.P40 => "66",
                Opacity.P50 => "80",
                Opacity.P60 => "99",
                Opacity.P70 => "b3",
                Opacity.P80 => "cc",
                Opacity.P90 => "e6",
                _ or Opacity.P100 => "ff",
            };

            return $"{hex}{alpha}";
        }
    }
}
