Console.WriteLine("Hello, enter your name:");
string name = Console.ReadLine();
Console.WriteLine("Enter your age:");
int age = int.Parse(Console.ReadLine());

Console.WriteLine("Enter first number:");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter second number:");
int num2 = int.Parse(Console.ReadLine());

Console.WriteLine($"{name}, {age}");
Console.WriteLine($"{num1} x {num2} =  {num1 * num2}");