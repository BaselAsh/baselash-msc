float gpa;

Console.Write("Enter Your GPA: ");
gpa = float.Parse(Console.ReadLine());

if (gpa < 1 && gpa > 0)
{
    Console.WriteLine("Failed");
}
else if (gpa >= 1 && gpa <= 2.5)
{
    Console.WriteLine("Good");
}
else if (gpa > 2.5 && gpa <= 3.5)
{
    Console.WriteLine("Very Good");
}
else if (gpa > 3.5 && gpa <= 4)
{
    Console.WriteLine("Excellent");
}
else
{
    Console.WriteLine("Something Went Wrong");
}
