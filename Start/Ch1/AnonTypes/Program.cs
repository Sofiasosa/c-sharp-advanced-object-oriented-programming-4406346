// Example file for Advanced C#: Object Oriented Programming by Joe Marini
// Creating and using Anonymous types

// TODO: Anonymous types can be declared using "new" and { }, similar to JS

var myObj = new
{
    Name = "Pepe",
    Age = 89,
    Address = new
    {
        Street = "123 Main St",
        City = "Anywhere"
    }
};

Console.WriteLine($"{myObj.Name}, {myObj.Address.City}");
Console.WriteLine(myObj);
// Anonymous types are read-only and cannot be modified
// myobj.Name = "Jane Doe";

// TODO: To change a value, use non-destructive mutation and "with" clause
var myObj2 = myObj with { Name = "Pepa" };
Console.WriteLine($"{myObj2.Name}, {myObj2.Address.City}");


// TODO: You can check to see if an anonymous object contains a property
Console.WriteLine($"{myObj.GetType().GetProperty("Name") != null}");
Console.WriteLine($"{myObj.GetType().GetProperty("Namee") != null}");
