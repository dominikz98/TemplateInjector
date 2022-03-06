using CssTemplateInjector.Contracts;

namespace CssTemplateInjector.Models
{
    public class FlexBox
    {
        public Direction Direction { get; set; }
        public bool Wrap { get; set; }
        public Alignment ItemAlignment { get; set; }
        public Alignment TextAlignment { get; set; }
        public JustifyContent JustifyContent { get; set; }

        public FlexBox(Direction direction, bool wrap, Alignment itemAlignment, Alignment textAlignment, JustifyContent justifyContent)
        {
            Direction = direction;
            Wrap = wrap;
            ItemAlignment = itemAlignment;
            TextAlignment = textAlignment;
            JustifyContent = justifyContent;
        }

        public FlexBox() : this(Direction.Row, false, Alignment.None, Alignment.None, JustifyContent.None) { }
    }
}
