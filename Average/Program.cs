long n1;
long n2;
long n3;

Console.WriteLine("--This app calculates the average of 3 numbers--");

Console.Write("Enter The First Number: ");
n1 = int.Parse(Console.ReadLine()!);
Console.Write("Enter The Second Number: ");
n2 = int.Parse(Console.ReadLine()!);
Console.Write("Enter The Third Number: ");
n3 = int.Parse(Console.ReadLine()!);

double average = (n1 + n2 + n3) / 3;
Console.WriteLine("The average of the three numbers is " + average);
