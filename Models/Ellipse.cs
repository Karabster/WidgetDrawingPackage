using System;

namespace WidgetDrawingPackage
{
    public class Ellipse : Widget
    {
        public Ellipse(int x, int y, int hDiameter, int vDiameter) : base(x, y)
        {
            HorizontalDiameter = hDiameter < 0 ? throw new ArgumentException($"{nameof(hDiameter)} cannot be less than 0") : hDiameter;
            VerticalDiameter = vDiameter < 0 ? throw new ArgumentException($"{nameof(vDiameter)} cannot be less than 0") : vDiameter;
        }

        public override string ToString()
        {
            return $"{base.ToString()}  diameterH = {HorizontalDiameter}  diameterV = {VerticalDiameter}";
        }

        internal int HorizontalDiameter { get; }
        internal int VerticalDiameter { get; }
    }
}
