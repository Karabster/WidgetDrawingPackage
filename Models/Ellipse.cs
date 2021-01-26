namespace WidgetDrawingPackage
{
    public class Ellipse : Widget
    {
        public Ellipse(int x, int y, int hDiameter, int vDiameter) : base(x, y, hDiameter, vDiameter)
        { }

        public override string ToString()
        {
            return $"{base.ToString()}  diameterH = {Width}  diameterV = {Height}";
        }
    }
}
