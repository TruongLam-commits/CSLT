internal class Slide
{
    static void Exercise1()
    {
        //Exercise 1
        do
        {
            Console.Write("Enter a Celcius Degree: ");
            string input_exercise1 = Console.ReadLine();
            float celcius_degree;
            if (float.TryParse(input_exercise1, out celcius_degree))
            {
                Console.WriteLine($"Kelvin Degree: {celcius_degree + 273:F2}");
                Console.WriteLine($"Fahrenheit Degree: {(celcius_degree * 18 / 10 + 32):F2}");
                break;
            }
            else
            {
                Console.WriteLine("Failed! Your input is not in correct format");
            }
        }
        while (true);
        Console.WriteLine("\n");
    }
    static void Exercise2()
    {
        //Exercise 2
        do
        {
            Console.Write("Enter the sphere's radius: ");
            string input_exercise2 = Console.ReadLine();
            const float pi = 3.14f;
            float radius;
            if (float.TryParse(input_exercise2, out radius))
            {
                Console.WriteLine($"Surface: {4 * pi * radius * radius} (unit squared)");
                Console.WriteLine($"Volume: {4 / 3 * pi * radius * radius * radius} (unit cubed)");
                break;
            }
            else
            {
                Console.WriteLine("Failed! Your input is not in correct format");
            }
        }
        while (true);
        Console.WriteLine("\n");
    }
    static void Exercise3()
    {
        //Exercise 3
        Console.Write("Enter your first number: ");
        string input_exercise3_1 = Console.ReadLine();
        Console.Write("Enter your second number: ");
        string input_exercise3_2 = Console.ReadLine();
        float num1 = float.Parse(input_exercise3_1);
        float num2 = float.Parse(input_exercise3_2);

        Console.WriteLine("\n");
        Console.WriteLine("===Your calculation===");
        Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
        Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
        Console.WriteLine($"{num1} x {num2} = {num1 * num2}");
        Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
        Console.WriteLine($"{num1} mod {num2} = {num1 % num2}");
    }
    public static void subMain(string[] args)
    {
        Exercise1();
        Exercise2();
        Exercise3();

       

    }
}