# WidgetDrawingPackage
This small console app is a showcase of general OOP principles Inheritance, Polymorphism and use of SOLID Principles

## General Structure

The purpose of this app is to simulate a drawing package that prints hard-coded widgets that were added to the drawing

Here the parent class for all widgets is logically named Widget, which contains not only the coordinates of itself 
but an overriden ToString() method, which will be used laterю

Using this parent method and it's overriden ToString Method are 5 implementations of the widget: Rectangle, Square, Ellipse, Circle and Textbox.

While having a hierarchy of their own, i.e. Square is a child of Rectangle, since they share the same properties, they all use the to some extent
the ToString() method of the Widget.

The Drawing class represents our canvas to which we can add widgets either via the constructor or using Add(method).

This way we are isolating the list of widgets from external change. However, the full list can still be accessed through a public property Widgets.

The Drawing class prints out into the console the list of current widgets that were added using Print() method which utilises the overidden ToString() methods
that we have specified when setting up the hierarchy.
