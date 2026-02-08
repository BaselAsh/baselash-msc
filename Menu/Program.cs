Console.WriteLine("1 --> Adding 2 Numbers");
Console.WriteLine("2 --> Subtract 2 Numbers");
Console.WriteLine("3 --> Multiply 2 Numbers");
Console.WriteLine("4 --> Divide 2 Numbers");
Console.Write("Please Choose an Operation: ");
int selection = int.Parse(Console.ReadLine());
double FirstNumber;
double SecondNumber;
if (selection >= 1 && selection <= 4)
{
    Console.Write("Enter The First Number: ");
    FirstNumber = double.Parse(Console.ReadLine());

    Console.Write("Enter The Second Number: ");
    SecondNumber = double.Parse(Console.ReadLine());
}
else
{
    Console.WriteLine("Please choose an operation between 1 and 4.");
    return;
}

switch (selection)
{
    case 1:
        Console.WriteLine($"{FirstNumber} + {SecondNumber} = {FirstNumber + SecondNumber}");
        break;
    case 2:
        Console.WriteLine($"{FirstNumber} - {SecondNumber} = {FirstNumber - SecondNumber}");
        break;
    case 3:
        Console.WriteLine($"{FirstNumber} * {SecondNumber} = {FirstNumber * SecondNumber}");
        break;
    case 4:
        Console.WriteLine($"{FirstNumber} / {SecondNumber} = {FirstNumber / SecondNumber}");
        break;
    default:
        Console.WriteLine("Please choose an operation between 1 and 4.");
        break;
}

