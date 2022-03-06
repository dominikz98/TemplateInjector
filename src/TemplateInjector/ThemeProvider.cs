using CssTemplateInjector.Contracts;
using CssTemplateInjector.Extensions;
using CssTemplateInjector.Models;
using Microsoft.AspNetCore.Components;

namespace CssTemplateInjector
{
    public class ThemeProvider
    {
        private readonly CSSBuilder _cssBuilder;
        private readonly Theme _theme;

        public ThemeProvider(CSSBuilder cssBuilder, Theme theme)
        {
            _cssBuilder = cssBuilder;
            _theme = theme;
        }

#pragma warning disable IDE0051 // Remove unused private members
        private MarkupString Create()
#pragma warning restore IDE0051 // Remove unused private members
        {
            var sb = new System.Text.StringBuilder();
            sb.AppendLine("<style>");
            sb.AppendLine($":root {{ {CreateRootStyle()} }}");
            sb.AppendLine($"body {{ {CreateBodyStyle()} }}");
            sb.AppendLine("</style>");

            return new MarkupString(sb.ToString());
        }

        private string CreateBodyStyle()
            => _cssBuilder.Create()
                .SetBackground(ThemeColor.Background)
                .SetColor(ThemeColor.Secondary)
                .SetFontFamily("Roboto") //'Roboto','Helvetica','Arial','sans-serif'
                .SetMargin(new Spacing(0))
                .Build();

        private string CreateRootStyle()
        {
            var sb = new System.Text.StringBuilder();
            sb.AppendLine($"--color-primary: {_theme.GetHex(ThemeColor.Primary, Opacity.P100)};");
            sb.AppendLine($"--color-secondary: {_theme.GetHex(ThemeColor.Secondary, Opacity.P100)};");
            sb.AppendLine($"--color-menu: {_theme.GetHex(ThemeColor.Menu, Opacity.P100)};");
            sb.AppendLine($"--color-background: {_theme.GetHex(ThemeColor.Background, Opacity.P100)};");
            sb.AppendLine($"--color-surface: {_theme.GetHex(ThemeColor.Surface, Opacity.P100)};");
            return sb.ToString();
        }
    }
}
