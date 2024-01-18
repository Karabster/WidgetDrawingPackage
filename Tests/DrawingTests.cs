using Xunit;

namespace WidgetDrawingPackage.Tests;

public class DrawingTests
{
    [Fact]
    public void Drawing_with_no_widgets_prints()
    {
        Assert.NotNull(new Drawing().Print());
    }

    [Fact]
    public void Drawing_with_widgets_prints()
    {
        Assert.NotNull(new Drawing().Add(new Square(1, 1, 0)).Print());
    }

    [Fact]
    public void Drawing_with_one_widget_prints_correctly()
    {
        var expected = """
            ----------------------------------------------------------------
            Requested Drawing
            ----------------------------------------------------------------
            Square x=1, y=1 size=1
            ----------------------------------------------------------------
            
            """;
        Assert.Equal(expected, new Drawing().Add(new Square(1, 1, 1)).Print());
    }

    [Fact]
    public void Drawing_with_multiple_widgets_prints_correctly()
    {
        var expected = """
            ----------------------------------------------------------------
            Requested Drawing
            ----------------------------------------------------------------
            Square x=1, y=1 size=1
            Ellipse x=1, y=2  diameterH = 3  diameterV = 4
            ----------------------------------------------------------------
            
            """;
        Assert.Equal(expected, new Drawing().Add(new Square(1, 1, 1), new Ellipse(1,2,3,4)).Print());
    }
}

