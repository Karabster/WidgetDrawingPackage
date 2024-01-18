namespace WidgetDrawingPackage
{
    public class Square : Rectangle
    {
        public Square(int x, int y, int size) :
            base(x, y, size, size)
        { }

        public override string ToString()
        {
            return $"{WidgetBasePrint} size={Width}";
        }
    }
}
