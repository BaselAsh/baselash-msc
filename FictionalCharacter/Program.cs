string name;
int age;
bool is_student;
string favorite_hobby;
string buf;

Console.Write("Name: ");
name = Console.ReadLine()!;
Console.Write("Age: ");
age = int.Parse(Console.ReadLine()!);
Console.Write("Is Student (Y/N): ");
buf = Console.ReadLine()!;

if (buf == "Y" || buf == "y")
{
    is_student = true;
}
else
{
    is_student = false;
}

Console.Write("Favorite Hobby: ");
favorite_hobby = Console.ReadLine()!;

Console.WriteLine($"Hi, my name is {name}, I am {age} years old and it is {is_student} that I am a student. My favorite hobby is {favorite_hobby}!");
