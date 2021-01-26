using System;
using System.Collections.Generic;
using WidgetDrawingPackage.Resources;

namespace WidgetDrawingPackage
{
    public class Drawing : IDrawing
    {
        internal List<Widget> __Widgets;
        public Drawing(List<Widget> widgets = null)
        {
            __Widgets = widgets ?? new List<Widget>();
        }

        public void Add(Widget widget)
        {
            __Widgets.Add(widget);
        }

        public void Print()
        {
            Console.WriteLine(StringResource.LineConstant);
            Console.WriteLine(StringResource.RequestedDrawingLabel);
            Console.WriteLine(StringResource.LineConstant);
            __Widgets.ForEach(shape => Console.WriteLine(shape.ToString()));
            Console.WriteLine(StringResource.LineConstant);
        }

        public List<Widget> Widgets => __Widgets;
    }
}
