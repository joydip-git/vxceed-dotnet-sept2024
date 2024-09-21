using CalculationLibrary;
using ExtensionLibrary;
using NewFeatures;

Console.WriteLine("Welcome to top level statement");

//implicitly-typed local variable
//type inference: determining the data type of the variable from the assigned value
var x = 100;
Console.WriteLine(x);

//implicitly-typed array variable
var numbers = new[] { 1, 2, 3, 4 };
var names = new string[3];

//Person p = new Person();
//p.Name = "anil";
//p.Id = 100;

//object initializer
//Person p = new Person() { Id = 1, Name = "anil" };
//or
Person p = new Person { Id = 1, Name = "anil" };
//or
Person p1 = new() { Id = 1, Name = "anil" };

Use();
void Use()
{
    Console.WriteLine("use something...");
    Console.WriteLine(x);
}
//Utility utility = new Utility();
//utility.Call();

Calculation calculation = new();
ICalculation upcasted = calculation;
Console.WriteLine(upcasted.Add(12, 13));
Console.WriteLine(upcasted.Multiply(12, 3));

string str = "joydip";
Console.WriteLine(str.SayHello());

