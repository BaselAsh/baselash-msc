int user_age;
int required_age = 18;

Console.Write("Enter Your Age: ");
user_age = int.Parse(Console.ReadLine());
Console.WriteLine(user_age >= required_age);
