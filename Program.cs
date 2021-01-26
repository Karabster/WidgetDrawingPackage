using System;
using System.Collections.Generic;
using WidgetDrawingPackage.Resources;

namespace WidgetDrawingPackage
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                var _Drawing = new Drawing(new List<Widget>()
                {
                    new Rectangle(10, 10, 30, 40),
                    new Square(15, 30, 35),
                    new Ellipse(100, 150, 300, 200),
                    new Circle(1, 1, 300),
                    new Textbox(5, 5, 200, 100, StringResource.DemoTextboxText)
                });
                
                _Drawing.Print();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
