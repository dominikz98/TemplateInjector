using CssTemplateInjector.Contracts;

namespace CssTemplateInjector.Models
{
    public class Spacing
    {
        public int Top { get; }
        public int Right { get; }
        public int Bottom { get; }
        public int Left { get; }
        public Size Size { get; }

        public Spacing(int top, int right, int bottom, int left, Size size)
        {
            Size = size;

            Top = CalculateValue(top);
            Bottom = CalculateValue(bottom);
            Left = CalculateValue(left);
            Right = CalculateValue(right);
        }

        public Spacing(int topAbottom, int leftAright, Size size) : this(topAbottom, leftAright, topAbottom, leftAright, size) { }

        public Spacing(int topAbottom, int leftAright) : this(topAbottom, leftAright, Size.Normal) { }

        public Spacing(int all) : this(all, all, Size.Normal) { }

        private int CalculateValue(int original)
        {
            if (Size == Size.Small)
                return original / 2;

            else if (Size == Size.Large)
                return original * 2;

            return original;
        }
    }
}
