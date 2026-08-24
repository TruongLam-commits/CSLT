using System.Drawing;
using System.Security.Cryptography;
using System.Text;

internal class BaiTap
{
    static void Operators_1()
    {

        //Write a C# Sharp program that takes two numbers as input and
        //performs an operation(+, -, *, x,/) on them and displays the result of that
        //operation.

                Console.Write("Enter a= ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter b= ");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("\n");
        Console.WriteLine($"{a} + {b} = {a + b}");
        Console.WriteLine($"{a} - {b} = {a - b}");
        Console.WriteLine($"{a} * {b} = {a * b}");
        Console.WriteLine($"{a} / {b} = {a / b}");
        Console.WriteLine($"{a} % {b} = {a % b}");

    }
    static void Operators_2()
    {

        //Write a C# Sharp program to display certain values of the function
        //x = y2 +2y + 1(using integer numbers for y, ranging from - 5 to + 5).

                Console.WriteLine("Result of function x = y^2 + 2y + 1 (with y ranging from -5 to 5)");
        for (int input_o2 = -5; input_o2<=5; input_o2 += 1)
        {
            Console.WriteLine($"{input_o2}^2 + 2x{input_o2} + 1 = {Math.Pow(input_o2,2) + 2*input_o2 + 1}");
        }
    }
    static void Operators_3()
    {

        //Write a C# Sharp program that takes distance and time (hours, minutes,
        //seconds) as input and displays speed in kilometers per hour(km / h) and
        //miles per hour(miles/ h).
        
        Console.Write("Enter distance (km): ");
        float dis = float.Parse(Console.ReadLine());
        Console.Write("Enter time (hours): ");
        float hour = float.Parse(Console.ReadLine());
        Console.Write("Enter time (minutes): ");
        float min = float.Parse(Console.ReadLine());
        Console.Write("Enter time (seconds): ");
        float sec = float.Parse(Console.ReadLine());

        float time = hour + min / 60 + sec / 3600;

        Console.WriteLine($"The speed (km/h) is: {dis/time:F2}");
        Console.WriteLine($"The speed (mile/h) is: {((dis * 0.6214f) )/ time:F2}");
    }
    static void Operators_4()
    {

        //Write a C# Sharp program that takes the radius of a sphere as input and
        //calculates and displays the surface and volume of the sphere. V =
        // 4 / 3 * π * r

        Console.Write("Enter the radius of a sphere: ");
        float r = float.Parse(Console.ReadLine());
        Console.WriteLine($"The surface is: {4*Math.PI*Math.Pow(r,2):F2} unit squared");
        Console.WriteLine($"The volume is: {(4/3) * Math.PI * Math.Pow(r, 3):F2} unit cubed");

    }
    static void Operators_5()
    {
        //Write a C# Sharp program that takes a character as input and checks if it
        //is a vowel, a digit, or any other symbol.

        Console.Write("Enter one character only: ");
        var input5 = Console.ReadLine();

        if (input5 is string)
        {
            if (new List<string> { "u", "e", "o", "a", "i" }.Contains(input5)) Console.WriteLine("This is a vowel");
            else Console.WriteLine("This is other symbol");
        }
        else if (float.Parse(input5) is float) Console.WriteLine("This is a digit");
        else { Console.WriteLine("This is other symbol"); }
    }

    static void Control_Flow_1()
    {
        //Write a C# Sharp program to check whether a given number is even or odd.

        Console.Write("Enter your number to check whether it is even or odd: ");
        int check_number = int.Parse(Console.ReadLine());

        if (check_number % 2 == 0) Console.WriteLine($"Your number: {check_number} is even");
        else Console.WriteLine($"Your number: {check_number} is odd");

        Console.WriteLine("\n");
    }
    static void Control_Flow_2()
    {
        //Write a C# Sharp program to find the largest of three numbers.
        Console.Write("Enter your first number: ");
        double first = double.Parse(Console.ReadLine());
        Console.Write("Enter your second number: ");
        double second = double.Parse(Console.ReadLine());
        Console.Write("Enter your third number: ");
        double third = double.Parse(Console.ReadLine());

        Console.WriteLine($"The largest of three numbers is: {Math.Max(Math.Max(first, second), third)}");

        Console.WriteLine("\n");
    }
    static void Control_Flow_3()
    {
        //Write a C# Sharp program to accept a coordinate point in an XY coordinate system and determine in which quadrant the coordinate point lies.

        Console.Write("Enter the value in X coordinate: ");
        double X = double.Parse(Console.ReadLine());
        Console.Write("Enter the value in Y coordinate: ");
        double Y = double.Parse(Console.ReadLine());

        if (X > 0 && Y > 0) Console.WriteLine($"The coordinate point ({X},{Y}) lies in the First quadrant");
        else if (X < 0 && Y > 0) Console.WriteLine($"The coordinate point ({X},{Y}) lies in the Second quadrant");
        else if (X < 0 && Y < 0) Console.WriteLine($"The coordinate point ({X},{Y}) lies in the Third quadrant");
        else if (X > 0 && Y < 0) Console.WriteLine($"The coordinate point ({X},{Y}) lies in the Fourth quadrant");
        else if (X == 0)
        {
            if (Y > 0) Console.WriteLine($"The coordinate point ({X},{Y}) lies in positive Y-axis");
            else Console.WriteLine($"The coordinate point ({X},{Y}) lies in negative Y-axis");

        }
        else if (Y == 0)
        {
            if (X > 0) Console.WriteLine($"The coordinate point({X},{Y}) lies in positive X-axis");
            else Console.WriteLine($"The coordinate point ({X},{Y}) lies in negative X-axis");
        }
        else Console.WriteLine($"The coordinat point ({X},{Y}) lies at the Origin (0,0)");
    }

    static void Control_Flow_4()
    {
        //Write a program to check whether a triangle is Equilateral, Isosceles or Scalene.

        Console.Write("Enter side A: "); int sA = int.Parse(Console.ReadLine());
        Console.Write("Enter side B: "); int sB = int.Parse(Console.ReadLine());
        Console.Write("Enter side C: "); int sC = int.Parse(Console.ReadLine());

        if (sA + sB > sC && sA + sC > sB && sB + sC > sA)
        {
            if (sA == sB && sB == sC) Console.WriteLine("Equilateral");
            else if (sA == sB || sB == sC || sA == sC) Console.WriteLine("Isosceles");
            else Console.WriteLine("Scalene");
        }
        else Console.WriteLine("Error: These side lengths cannot form a valid triangle!");
    }
    static void Control_Flow_5()
    {
        //Write a program to read 10 numbers and find their average and sum.

        double sum = 0;

        Console.WriteLine("Please enter 10 number below:");
        for (int i = 1; i <= 10; i++)
        {
            Console.Write($"\nEnter number {i}: ");
            double number = double.Parse(Console.ReadLine());

        }    

    }
    private static void subMain(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Control_Flow_4();
    }

}