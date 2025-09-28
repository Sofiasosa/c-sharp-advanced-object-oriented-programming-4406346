// Example file for Advanced C#: Object Oriented Programming by Joe Marini
// Defining and instantiating classes

// TODO: Create some new Rectangle objects with dimensions

Reactangle react1 = new Reactangle(10, 20);
Reactangle react2 = new Reactangle(6);

Console.WriteLine(react1.GetArea());
Console.WriteLine(react2.GetArea());

// TODO: Change the values of width and height

react1.width = 20;

Console.WriteLine(react1.GetArea());
