namespace WidgetDrawingPackage
{
    public abstract class Widget
    {
        private string __WidgetBasePrint;
        public Widget(int x, int y)
        {
            XCoordinate = x;
            YCoordinate = y;
        }

        public override string ToString()
        {
            return WidgetBasePrint;
        }

        internal string WidgetBasePrint => string.IsNullOrWhiteSpace(__WidgetBasePrint) ? __WidgetBasePrint = $"{GetType().Name} ({XCoordinate}, {YCoordinate})" : __WidgetBasePrint;
        internal int XCoordinate { get; }
        internal int YCoordinate { get; }
    }
}
