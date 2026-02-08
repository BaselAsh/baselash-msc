string name;
int age;
string city;


Console.Write("Enter Your Name: ");
name = Console.ReadLine();
Console.Write("Enter Your Age: ");
age = int.Parse(Console.ReadLine());
Console.Write("Enter Your City: ");
city = Console.ReadLine();

Console.WriteLine("My name is " + name + ".");
Console.WriteLine("I'm " + age + " Years Old.");
Console.WriteLine("I live in " + city + ".");
