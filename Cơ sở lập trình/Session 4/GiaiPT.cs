using System.Text;

internal class giaiPT
{
    static void giai_PT(int a, int b, int c)
    {

        if (a == 0)
        {
            if (b == 0)
            {
                if (c == 0) Console.WriteLine("Phương trình có vô số nghiệm");
                else Console.WriteLine("Vô lý");
            }
            else //b!=0
            {
                if (c == 0) Console.WriteLine("Nghiệm đơn: x=0");
                else Console.WriteLine($"x = {(double) -c / b}"); //c!=0
            }
        }
        else //a!=0
        {
            if (b == 0)
            {
                if (c == 0) Console.WriteLine("Nghiệm kép: x=0");
                else //c!=0
                {
                    if (a * c > 0) Console.WriteLine("Vô lý");
                    else
                    {
                        Console.WriteLine($"x1 = {Math.Sqrt(-c / a)}");
                        Console.WriteLine($"x2 = -{Math.Sqrt(-c / a)}");
                    } 
                        
                }

            }
            else //b!=0
            {
                if (c == 0)
                {
                    Console.WriteLine("x1  = 0");
                    Console.WriteLine($"x2 = {-b / a}");
                }
                else //c!=0
                {
                    double delta = Math.Pow(b, 2) - 4 * a * c;
                    if (delta < 0) Console.WriteLine("Phương trình vô nghiệm");
                    else if (delta == 0) Console.WriteLine($"Nghiệm kép: x = {-b / (2 * a)}");
                    else
                    {
                        Console.WriteLine($"x1 = {(-b + Math.Sqrt(delta)) / (2 * a)}");
                        Console.WriteLine($"x2 = {(-b - Math.Sqrt(delta)) / (2 * a)}");
                    }
                }
            }
        }
    }
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.Write("Nhập hệ số a: "); int a = int.Parse(Console.ReadLine());
        Console.Write("Nhập hệ số b: "); int b = int.Parse(Console.ReadLine());
        Console.Write("Nhập hệ số c: "); int c = int.Parse(Console.ReadLine());

        giai_PT(a,b,c);
    }
}