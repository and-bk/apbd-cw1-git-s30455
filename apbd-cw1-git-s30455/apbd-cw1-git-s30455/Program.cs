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

int[] nums = {1, 3, 4, 2};
Console.WriteLine($"Average: {CalculateAverage(nums)}");
Console.WriteLine($"Max number: {CalculateMax(nums)}");

static double CalculateAverage(int[] values)
{
    int sum = 0;
    foreach (int num in values)
    {
        sum += num;
    }
    return (double)sum /  values.Length;
}

static int CalculateMax(int[] values)
{
    int currentMax = 0;
    foreach (int num in values)
    {
        if(num > currentMax)
            currentMax = num;
    }
    return currentMax;
}