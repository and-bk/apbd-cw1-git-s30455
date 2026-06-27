Console.WriteLine("Hello, enter your name:");
string name = Console.ReadLine();
Console.WriteLine("Enter your age:");
int age = int.Parse(Console.ReadLine());

Console.WriteLine("Choose operation(x/:): ");
string operation = Console.ReadLine();

if (operation == "x")
{
    Console.WriteLine("Enter first number:");
    int num1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter second number:");
    int num2 = int.Parse(Console.ReadLine());
    
    Console.WriteLine($"{name}, {age}");
    Console.WriteLine($"{num1} x {num2} =  {num1 * num2}");
} else if (operation == ":")
{
    Console.WriteLine("Enter first number:");
    int num1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter second number:");
    int num2 = int.Parse(Console.ReadLine());
    
    Console.WriteLine($"{name}, {age}");
    Console.WriteLine($"{num1} : {num2} =  {num1 / num2}");
}

int[] nums = { 1, 2, 3, 4 };
Console.WriteLine($"Sum: {CalculateAverage(nums)}");

static int CalculateAverage(int[] values)
{
    int sum = 0;
    foreach (int num in values)
    {
        sum += num;
    }
    return sum;
}