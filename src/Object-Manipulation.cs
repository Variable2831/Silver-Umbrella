
using System;
 
namespace ChangeObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create our objects
            var obj1 = new { Name = "Object1", Value = 1 };
            var obj2 = new { Name = "Object2", Value = 2 };
 
            // Change the values of our objects
            obj1.Value = 3;
            obj2.Name = "ChangedObject2";
 
            // Print out the new values
            Console.WriteLine("Object1 Value: " + obj1.Value);
            Console.WriteLine("Object2 Name: " + obj2.Name);
        }
    }
}

// Output
// Object1 Value: 3
// Object2 Name: ChangedObject2

// Change the colours and make a list of the objects and define the phyiscal properties 

using System;
using System.Collections.Generic;
 
namespace ChangeObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create our objects and add them to a list
            var obj1 = new { Name = "Object1", Color = "Red", Weight = 10 };
            var obj2 = new { Name = "Object2", Color = "Blue", Weight = 20 };
            var objects = new List<object> { obj1, obj2 };
 
            // Change the values of our objects
            obj1.Color = "Green";
            obj2.Weight = 30;
 
            // Print out the new values
            foreach (var obj in objects)
            {
                Console.WriteLine("Name: " + obj.Name + ", Color: " + obj.Color + ", Weight: " + obj.Weight);
            }
        }
    }
}

// Output
// Name: Object1, Color: Green, Weight: 10
// Name: Object2, Color: Blue, Weight: 30

// Code example

using System;

namespace ObjectExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a car object
            var car = new { Make = "Honda", Model = "Accord", Year = 2018 };
            
            // Print out the car's details
            Console.WriteLine("Make: " + car.Make);
            Console.WriteLine("Model: " + car.Model);
            Console.WriteLine("Year: " + car.Year);
        }
    }
}

// Output
// Make: Honda
// Model: Accord
// Year: 2018

// Create an object to represent a person

using System;

namespace ObjectExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a person object
            var person = new { Name = "John", Age = 25, Height = 183 };
            
            // Print out the person's details
            Console.WriteLine("Name: " + person.Name);
            Console.WriteLine("Age: " + person.Age);
            Console.WriteLine("Height: " + person.Height);
        }
    }
}

// Output
// Name: John
// Age: 25
// Height: 183
