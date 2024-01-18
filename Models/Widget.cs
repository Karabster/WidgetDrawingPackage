using System;

namespace WidgetDrawingPackage
{
    public abstract class Widget(int x, int y, int width, int height)
    {
        public override string ToString()
        {
            return WidgetBasePrint;
        }

        protected string WidgetBasePrint => $"{GetType().Name} x={XCoordinate}, y={YCoordinate}";
        protected int Width { get; } = width < 0 ? throw new ArgumentException($"{nameof(width)} cannot be less than 0") : width;
        protected int Height { get; } = height < 0 ? throw new ArgumentException($"{nameof(height)} cannot be less than 0") : height;
        private int XCoordinate { get; } = x;
        private int YCoordinate { get; } = y;
    }
}
