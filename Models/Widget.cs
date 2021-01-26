using System;

namespace WidgetDrawingPackage
{
    public abstract class Widget
    {
        private string __WidgetBasePrint;
        public Widget(int x, int y, int width, int height)
        {
            XCoordinate = x;
            YCoordinate = y;
            Width = width < 0 ? throw new ArgumentException($"{nameof(width)} cannot be less than 0") : width;
            Height = height < 0 ? throw new ArgumentException($"{nameof(height)} cannot be less than 0") : height;
        }

        public override string ToString()
        {
            return WidgetBasePrint;
        }

        internal string WidgetBasePrint => string.IsNullOrWhiteSpace(__WidgetBasePrint) ? __WidgetBasePrint = $"{GetType().Name} ({XCoordinate}, {YCoordinate})" : __WidgetBasePrint;
        internal int Width { get; }
        internal int Height { get; }
        internal int XCoordinate { get; }
        internal int YCoordinate { get; }
    }
}
