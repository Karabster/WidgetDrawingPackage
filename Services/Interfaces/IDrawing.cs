using System.Collections.Generic;

namespace WidgetDrawingPackage
{
    interface IDrawing
    {
        /// <summary>
        /// Ability to add widgets to the canvas
        /// </summary>
        /// <param name="widget">Widget to be added</param>
        public void Add(Widget widget);
        /// <summary>
        /// Prints existing widgets on the drawing
        /// </summary>
        public void Print();
        /// <summary>
        /// Gets the list of existing widgets on the drawing
        /// </summary>
        public List<Widget> Widgets { get; }
    }
}
