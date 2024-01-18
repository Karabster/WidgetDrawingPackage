using System.Collections.Generic;
using System.Text;
using WidgetDrawingPackage.Resources;

namespace WidgetDrawingPackage;
public class Drawing
{
    internal List<Widget> _widgets;
    public Drawing(List<Widget> widgets = null)
    {
        _widgets = widgets ?? new List<Widget>();
    }

    public Drawing Add(params Widget[] widget)
    {
        _widgets.AddRange(widget);
        return this;
    }

    public string Print()
    {
        var s = new StringBuilder();
        s.AppendLine(StringResource.LineConstant);
        s.AppendLine(StringResource.RequestedDrawingLabel);
        s.AppendLine(StringResource.LineConstant);
        _widgets.ForEach(shape => s.AppendLine(shape.ToString()));
        s.AppendLine(StringResource.LineConstant);
        return s.ToString();
    }
}
