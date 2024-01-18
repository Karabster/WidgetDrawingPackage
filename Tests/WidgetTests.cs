using FsCheck.Xunit;
using Xunit;

namespace WidgetDrawingPackage.Tests
{
    public class WidgetTests
    {
        [Theory]
        [InlineData(1, 1, 10)]
        [InlineData(0, 0, 100)]
        [InlineData(-1, 1, 10)]
        [InlineData(1, -1, 0)]
        public void Square_correct_parameters_prints_successfully(int x, int y, int size)
        {
            var s = new Square(x, y, size);
            Assert.NotNull(s.ToString());
        }

        [Property]
        public void Square_with_negative_size_throws(int x, int y, int size)
        {
            if (size < 0)
            {
                var ex = Assert.Throws<ArgumentException>(() => new Square(x, y, size));
                Assert.Contains("cannot be less than 0", ex.Message);
            }
            else
            {
                var square = new Square(x, y, size);
                Assert.NotNull(square.ToString());
            }
        }

        [Fact]
        public void Square_correct_params_prints_correctly()
        {
            Assert.Equal("Square x=1, y=2 size=3", new Square(1, 2, 3).ToString());
        }

        [Theory]
        [InlineData(1, 1, 10)]
        [InlineData(0, 0, 100)]
        [InlineData(-1, 1, 10)]
        [InlineData(1, -1, 0)]
        public void Circle_correct_parameters_prints_successfully(int x, int y, int diameter)
        {
            var s = new Circle(x, y, diameter);
            Assert.NotNull(s.ToString());
        }

        [Property]
        public void Circle_with_negative_diameter_throws(int x, int y, int diameter)
        {
            if (diameter < 0)
            {
                var ex = Assert.Throws<ArgumentException>(() => new Circle(x, y, diameter));
                Assert.Contains("cannot be less than 0", ex.Message);
            }
            else
            {
                var circle = new Circle(x, y, diameter);
                Assert.NotNull(circle.ToString());
            }
        }

        [Fact]
        public void Circle_correct_params_prints_correctly()
        {
            Assert.Equal("Circle x=1, y=2 size=3", new Circle(1, 2, 3).ToString());
        }

        [Theory]
        [InlineData(1, 1, 10, 1)]
        [InlineData(0, 0, 100, 2)]
        [InlineData(-1, 1, 10, 4)]
        [InlineData(1, -1, 0, 4)]
        public void Ellipse_correct_parameters_prints_successfully(int x, int y, int hDia, int vDia)
        {
            var s = new Ellipse(x, y, hDia, vDia);
            Assert.NotNull(s.ToString());
        }


        [Property]
        public void Ellipse_with_negative_diameter_throws(int x, int y, int hDia, int vDia)
        {
            if (hDia < 0 || vDia < 0)
            {
                var ex = Assert.Throws<ArgumentException>(() => new Ellipse(x, y, hDia, vDia));
                Assert.Contains("cannot be less than 0", ex.Message);
            }
            else
            {
                var ellipse = new Ellipse(x, y, hDia, vDia);
                Assert.NotNull(ellipse.ToString());
            }
        }

        [Fact]
        public void Ellipse_correct_params_prints_correctly()
        {
            Assert.Equal("Ellipse x=1, y=2  diameterH = 3  diameterV = 4", new Ellipse(1, 2, 3, 4).ToString());
        }

        [Theory]
        [InlineData(1, 1, 10, 1)]
        [InlineData(0, 0, 100, 2)]
        [InlineData(-1, 1, 10, 4)]
        [InlineData(1, -1, 0, 4)]
        public void Rectangle_correct_parameters_prints_successfully(int x, int y, int width, int height)
        {
            var s = new Rectangle(x, y, width, height);
            Assert.NotNull(s.ToString());
        }

        [Property]
        public void Rectangle_with_negative_diameter_throws(int x, int y, int width, int height)
        {
            if (width < 0 || height < 0)
            {
                var ex = Assert.Throws<ArgumentException>(() => new Rectangle(x, y, width, height));
                Assert.Contains("cannot be less than 0", ex.Message);
            }
            else
            {
                var rectangle = new Rectangle(x, y, width, height);
                Assert.NotNull(rectangle.ToString());
            }
        }

        [Fact]
        public void Rectangle_correct_params_prints_correctly()
        {
            Assert.Equal("Rectangle x=1, y=2 width=3 height=4", new Rectangle(1, 2, 3, 4).ToString());
        }

        [Theory]
        [InlineData(1, 1, 10, 1, "asd")]
        [InlineData(0, 0, 100, 2, "asd")]
        [InlineData(-1, 1, 10, 4, "asd")]
        [InlineData(1, -1, 0, 4, "")]
        public void Textbox_correct_parameters_prints_successfully(int x, int y, int width, int height, string text)
        {
            var s = new Textbox(x, y, width, height, text);
            Assert.NotNull(s.ToString());
        }

        [Property]
        public void Textbox_with_negative_diameter_throws(int x, int y, int width, int height, string text)
        {
            if (width < 0 || height < 0)
            {
                var ex = Assert.Throws<ArgumentException>(() => new Textbox(x, y, width, height, text));
                Assert.Contains("cannot be less than 0", ex.Message);
            }
            else
            {
                var textbox = new Textbox(x, y, width, height, text);
                Assert.NotNull(textbox.ToString());
            }
        }

        [Fact]
        public void Textbox_correct_params_prints_correctly()
        {
            Assert.Equal("Textbox x=1, y=2 width=3 height=4 text=\"sample\"", new Textbox(1, 2, 3, 4, "sample").ToString());
        }
    }
}