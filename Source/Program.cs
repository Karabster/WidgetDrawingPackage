﻿using System;

namespace WidgetDrawingPackage
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(new Drawing().Add(
                    [
                        new Rectangle(10, 10, 30, 40),
                        new Square(15, 30, 35),
                        new Ellipse(100, 150, 300, 200),
                        new Circle(1, 1, 300),
                        new Textbox(5, 5, 200, 100, "sample text")
                    ]).Print());
        }
    }
}
