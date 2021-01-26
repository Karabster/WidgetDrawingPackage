using System;

namespace WidgetDrawingPackage
{
    public class Rectangle : Widget
    {
        public Rectangle(int x, int y, int width, int height)
            : base(x, y)
        {
            Width = width < 0 ? throw new ArgumentException($"{nameof(width)} cannot be less than 0") : width;
            Height = height < 0 ? throw new ArgumentException($"{nameof(height)} cannot be less than 0") : height;
        }

        public override string ToString()
        {
            return $"{base.ToString()} width={Width} height={Height}";
        }

        internal int Width { get; }
        internal int Height { get; }
    }
}
