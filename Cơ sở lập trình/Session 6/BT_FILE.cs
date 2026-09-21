using System.Threading.Tasks.Dataflow;

internal partial class BTFILE
{
    static int TinhTong(int a, int b)
    {
        return a + b;
    }
    static bool KiemTraChan(int n)
    {
        if (n % 2 == 0) return true;
        else return false;
    }
    static int TimMax(int a, int b, int c)
    {
        return Math.Max(Math.Max(a, b), c);
    }
    static long TinhGiaiThua(int n)
    {
        long result = 1;
        for (int i = n; i>=1; i--)
        {
            result *= i;
        }
        return result;
    }
    static string DaoNguocChuoi(string input)
    {
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
    static bool KiemTraSoNguyenTo(int n)
    {
        if (n < 2) return false;
        for (int i = 2; i<=Math.Sqrt(n); i++)
        {
            if (n % i == 0) return false;
        }
        return true;
    }
    static void InFibonacci(int n)
    {
        List<int> FibonacciList = new List<int>();

        if (n >= 1) FibonacciList.Add(0);
        if (n >= 2) FibonacciList.Add(1);

        while (FibonacciList.Count < n)
        {
            int sohientai = FibonacciList[FibonacciList.Count - 1] + FibonacciList[FibonacciList.Count - 2];
            FibonacciList.Add(sohientai);
        }
        Console.Write($"Your {n} Fibonacci list is: [");
        Console.Write(string.Join(", ", FibonacciList));
        Console.WriteLine("]\n");
    }
    static int DemNguyenAm(string input)
    {
        input = input.ToLower().Trim();
        List<char> NguyenAm = ['u', 'e', 'o', 'a', 'i'];
        int Count = 0;
        foreach (char c in input)
        {
            if (NguyenAm.Contains(c)) Count++;
        }
        return Count;
    }
    static double TinhLuyThua(int a, int b)
    {
        double result = 1; 
        for (int i = 1; i<=b; i++)
        {
            result *=a;
        }
        return result; 
    }
    static double TinhTrungBinh(int[] arr)
    {
        if (arr.Length == 0) return 0;
        return arr.Average();
    }
    static bool KiemTraDoiXung(string s)
    {
        s = s.ToLower().Trim();
        int sokytu= s.Length;
        if (sokytu % 2 != 0)
        {
            int mid_index = sokytu / 2;
            char[] left = s.Substring(0, mid_index).ToArray();
            char[] right = s.Substring(mid_index + 1).ToArray();
            return left.SequenceEqual(right.Reverse());
        }
        else
        {
            char[] left = s.Substring(0, sokytu / 2).ToArray();
            char[] right = s.Substring(sokytu / 2).ToArray();
            return left.SequenceEqual(right.Reverse());
        }
    }
    static double CelciusToFarenheit(double c)
    {
        return (c * 1.8d) + 32d;
    }
    static int TimMin(int[] arr)
    {
        return arr.Min();
    }
    static int TongCacChuSo(int n)
    {
        List<int> list_digits = new List<int>();
        while (n > 0)
        {
            int digit = n % 10;
            list_digits.Add(digit);
            n /= 10;
        }
        return list_digits.Sum();

    }
    static void SapXepMang(int[] arr)
    {
        var arr_list = arr.ToList();
        List<int> newlist = new List<int>();
        for (int i = 1; i <= arr.Length; i++)
        {
            int sonhonhat = arr_list.Min();
            newlist.Add(sonhonhat);
            arr_list.Remove(sonhonhat);
        }
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = newlist[i];
        }
    }
    static string XoaTrungLap(string s)
    {
        List<int> ascii_list = new List<int>(); 
        foreach (char c in s)
        {
            int ascii = (int)c;
            if (ascii_list.Contains(ascii) == false)
            {
                ascii_list.Add(ascii);
            }
        }
        string new_word = "";
        foreach (int i in ascii_list)
        {
            char c = (char)i;
            new_word += c + "";
        }
        return new_word;
    }
    static int TimUCLN(int a, int b)
    {
        return b == 0 ? Math.Abs(a) : TimUCLN(b, a % b);
    }
    static string DecimalToBinary(int n)
    {
        if (n == 0) return "0";
        return Convert.ToString(n, 2);
    }
    static bool KiemTraNamNhuan(int year)
    {
        return (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0);
    }
    static int DemSoTu(string sentence)
    {
        if (string.IsNullOrWhiteSpace(sentence)) return 0;

        string[] words = sentence.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
        return words.Length;
    }




    private static void Main(string[] args)
    {
        int x = 4, y = 5, z = 3;

        Console.WriteLine($"The given number is [{x}, {y}, {z}]\n");
        Console.Write("Enter a string: "); string input = Console.ReadLine();
        List<int> list_num = [x, y, z];

        //Bai 1
        Console.WriteLine("---SUM---");
        Console.WriteLine($"{x} + {y} = {TinhTong(x,y)}\n");

        //Bai 2
        Console.WriteLine("---EVEN/ODD--- ");
        if (KiemTraChan(x)) Console.WriteLine($"{x} is an even number\n");
        else Console.WriteLine($"{x} is not an even number\n");

        //Bai 3
        Console.WriteLine("---MAX---");
        Console.WriteLine($"{TimMax(x, y, z)} is the max value\n");

        //Bai 4
        Console.WriteLine("---FACTORIAL---");
        Console.WriteLine($"The factorial of {x} is {TinhGiaiThua(x)}\n");

        //Bai 5
        Console.WriteLine("---REVERSE---");
        Console.WriteLine($"The reverse string of \"{input}\" is: \"{DaoNguocChuoi(input)}\"\n");

        //Bai 6
        Console.WriteLine("---PRIME---");
        if (KiemTraSoNguyenTo(x)) Console.WriteLine($"{x} is a prime number\n");
        else Console.WriteLine($"{x} is not a prime number\n");

        //Bai 7
        Console.WriteLine("---FIBONACCI---");
        Console.Write("Enter the number of number you want to print in Fibonacci List: "); int k = int.Parse(Console.ReadLine());
        InFibonacci(k);

        //Bai 8
        Console.WriteLine("---VOWEL COUNT---");
        Console.WriteLine($"You have {DemNguyenAm(input)} vowels in \"{input}\"\n");

        //Bai 9
        Console.WriteLine("---EXPONENTIAL---");
        Console.WriteLine($"{x} ^ {y} = {TinhLuyThua(x, y)}\n");

        //Bai 10
        Console.WriteLine("---AVERAGE---");
        Console.WriteLine($"Average of given array is {TinhTrungBinh(list_num.ToArray())}\n");

        //Bai 11
        Console.WriteLine("---CHECK PALINDROME---");
        if (KiemTraDoiXung(input)) Console.WriteLine($"Your string \"{input}\" is palindrome\n");
        else Console.WriteLine($"Your string \"{input}\" is not a palindrome\n");

        //Bai 12
        Console.WriteLine("---C TO F DEGREE---");
        Console.Write("Enter Celcius degree: "); int cel = int.Parse(Console.ReadLine());
        Console.WriteLine($"{cel} celcius degree is equivalent to {CelciusToFarenheit(cel)} farenheit degree\n");

        //Bai 13
        Console.WriteLine("---MIN---");
        Console.WriteLine($"The minimum value in [{x},{y},{z}] is {TimMin(list_num.ToArray())}\n");

        //Bai 14
        Console.WriteLine("---SUM OF THE DIGITS---");
        Console.Write("Enter your number: "); int num = int.Parse(Console.ReadLine());
        Console.WriteLine($"The sum of the digits of {num} is: {TongCacChuSo(num)}");

        //Bai 15
        Console.WriteLine("---ARRAY ORDERING---");
        int[] mang = list_num.ToArray();
        SapXepMang(mang);
        Console.WriteLine($"Your ordered array is: [{string.Join(", ", mang)}]\n");

        //Bai 16
        Console.WriteLine("---REPEATED WORDS REMOVING---");
        Console.Write("Enter a string: "); string inp = Console.ReadLine();
        Console.WriteLine($"Your string after removing repeated words is: {XoaTrungLap(inp)}");

        //Bai 17
        Console.WriteLine("\n---UCLN---");
        Console.Write("Enter first number: "); int a = int.Parse(Console.ReadLine());
        Console.Write("Enter first number: "); int b = int.Parse(Console.ReadLine());
        int ketqua = TimUCLN(a, b);
        Console.WriteLine(ketqua);

        //Bai 18
        Console.WriteLine("\n---DECIMAL TO BINARY---");
        int dcm = int.Parse(Console.ReadLine());
        string bin = DecimalToBinary(dcm);
        Console.WriteLine(bin);

        //Bai 19
        Console.WriteLine("\n---CHECK YEAR---");
        int year = int.Parse(Console.ReadLine());
        Console.WriteLine(KiemTraNamNhuan(year));

        //Bai 20
        Console.WriteLine("\n---COUNT WORDS---");
        string count = Console.ReadLine();
        Console.WriteLine(DemSoTu(count));
    }
}