using System.Runtime.Intrinsics.X86;
using System;

internal class Session2
{
    public static void Main(string[] args)
    {
        Session1.subMain(args); //Dùng để gọi lại code ở file Session1

        //Extract 1: To Add/Sum two number
        Console.WriteLine("Enter two integer numbers: ");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int sum = a + b;
        Console.WriteLine($"{a}+{b}={sum}");
        Console.WriteLine("\n");

        //Extract 2: To Swap Values of Two Varible
        int middle_man = a; a = b; b = middle_man;
        Console.WriteLine("Two Given Number after swapping will be shown below");
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine("\n");

        //Extract 3: To Multiply two Floating Point Number
        Console.WriteLine("Enter two numbers you want to multiply: ");
        float c = Convert.ToSingle(Console.ReadLine());
        float d = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine($"The multiplication is: {c * d:F2}");
        Console.WriteLine("\n");

        //Extract 4: To convert feet to meter
        Console.Write("Enter length in feet: ");
        float feet = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine($"{feet}feet = {feet * 0.3048:F2}m");
        Console.WriteLine("\n");

        //Extract 5: To convert Celcius to Farenheit
        Console.Write("Enter the Degree: ");
        float degree = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine($"{degree} Celcius Degree = {degree*1.8+32:F2} Farenheit Degree");
        Console.WriteLine($"{degree} Farenheit Degree = {(degree-32)/1.8:F2} Celcius Degree");
        Console.WriteLine("\n");

        //Extract 6: To Find the size of DataType
        Console.WriteLine($"The size of boolen, integer is {sizeof(bool)}, {sizeof(int)} respectively");
        Console.WriteLine("\n");

        //Extract 7: Print ASCII
        Console.WriteLine("Enter a character:");
        var x = Console.Read();
        Console.WriteLine($"The ASCII value of {(char)x} is {x}"); //(char)x: ép kiểu dữ liệu
        Console.ReadLine();
        Console.WriteLine("\n");

        //Extract 8: Calculate Area of Circle
        Console.WriteLine("Enter the radius of Circle: ");
        float r = Convert.ToSingle(Console.ReadLine());
        const float pi = 3.14f;
        Console.WriteLine($"The Area of the Circle that has r = {r} unit is {pi * (r * r)} unit squared");
        Console.WriteLine("\n");

        //Extract 9: Calculate Area of Square
        Console.WriteLine("Enter the edge of Square: ");
        float s = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine($"The area of the Square that has the edge = {s} unit is {s * s} squared");
        Console.WriteLine("\n");

        //Extract 10: To Convert Day to Year, Week, Day
        Console.WriteLine("Enter the number of days: ");
        int day = Convert.ToInt32(Console.ReadLine());
        int years = day/365;
        int remaining_days_after_year = day % 365;
        int weeks = remaining_days_after_year / 7;
        int days = remaining_days_after_year % 7;
        Console.WriteLine($"{day} days = {years} year(s) + {weeks} week(s) + {days} days");
            

    }
}
