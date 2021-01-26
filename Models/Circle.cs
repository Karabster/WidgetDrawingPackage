namespace WidgetDrawingPackage
{
    public class Circle : Ellipse
    {
        public Circle(int x, int y, int size) 
            : base(x, y, size, size)
        { }

        public override string ToString()
        {
            return $"{WidgetBasePrint} size={VerticalDiameter}";
        }
    }
}
