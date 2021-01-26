using System;

namespace WidgetDrawingPackage
{
    public class Rectangle : Widget
    {
        public Rectangle(int x, int y, int width, int height)
            : base(x, y, width, height)
        { }

        public override string ToString()
        {
            return $"{base.ToString()} width={Width} height={Height}";
        }
    }
}
