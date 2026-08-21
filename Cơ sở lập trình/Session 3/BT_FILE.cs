using System.Text;
using System.Globalization;

internal class BT_THUC_TE
{
    enum currency
    {
        USD = 1,
        EUR = 2,
        JPY = 3,
        GBP = 4,
    }
    static void Bai1()
    {
        //BÀI 1: Tính tiền điện sinh hoạt theo bậc thang (EVN)
        Console.Write("Nhập chỉ số điện cũ (kWh): ");
        decimal old = decimal.Parse(Console.ReadLine());
        decimal new_index;

        do
        {
            Console.Write("Nhập chỉ số điện mới (kWh): ");
            new_index = decimal.Parse(Console.ReadLine());
            if (new_index >= old)
                break;
            else
                Console.WriteLine("\nChỉ số mới phải lớn hơn hoặc bằng chỉ số cũ. Hãy nhập lại!");
        }
        while (true);

        decimal Consumption = new_index - old;
        decimal price = 0m;
        
        //Tính tiền
        if (Consumption <= 50)
        { price = Consumption * 1806; }
        else if (Consumption <= 100)
        { price = 50 * 1806 + (Consumption - 50) * 1866; }
        else if (Consumption <= 200)
        { price = 50 * 1806 + 50 * 1866 + (Consumption - 100) * 2167; }
        else if (Consumption <= 300)
        { price = 50 * 1806 + 50 * 1866 + 100 * 2167 + (Consumption - 200) * 2729; }
        else { price = 50 * 1806 + 50 * 1866 + 100 * 2167 + 100 * 2729 + (Consumption - 300) * 3050; }

        decimal VAT = price * 0.08m;

        Console.WriteLine($"\nSố điện tiêu thụ: {Consumption} kWh");
        Console.WriteLine($"Tiền điện chưa thuế: {price:N0} VNĐ");
        Console.WriteLine($"Thuế VAT (8%): {VAT:N0} VNĐ");
        Console.WriteLine($"Tổng thanh toán: {price+VAT:N0} VNĐ");
        Console.WriteLine("\n");

    }
    static void Bai2()
    {
        //Tính toán BMI dựa vào chiều cao và cân nặng
        Console.Write("Nhập vào chiều cao của bạn (m): ");
        double height = double.Parse(Console.ReadLine());
        Console.Write("Nhập vào cân nặng của bạn (kg): ");
        double weight = double.Parse(Console.ReadLine());

        decimal BMI = (decimal) (weight / Math.Pow(height,2));
        decimal min_weight = (decimal) (18.5d * Math.Pow(height, 2));
        decimal max_weight = (decimal) (22.9d * Math.Pow(height, 2));

        Console.WriteLine("\nKết quả kiểm tra sức khỏe của bạn là");
        
        if (BMI <= 18.5m)
        {
            Console.WriteLine($"Chỉ số BMI của bạn: {BMI:F2}");
            Console.WriteLine("Phân loại sức khỏe: Gầy (Thiếu cân)");
            Console.WriteLine($"Khuyên dùng: Cân nặng của bạn nên từ {min_weight:F2} đến {max_weight:F2} (kg)");
        }
        else if (BMI < 23m)
        {
            Console.WriteLine($"Chỉ số BMI của bạn: {BMI:F2}");
            Console.WriteLine("Phân loại sức khỏe: Bình thường (Lý tưởng)");
            Console.WriteLine($"Khuyên dùng: Cân nặng của bạn nên từ {min_weight:F2} đến {max_weight:F2} (kg)");
        }
        else if (BMI < 25m)
        {
            Console.WriteLine($"Chỉ số BMI của bạn: {BMI:F2}");
            Console.WriteLine("Phân loại sức khỏe: Thừa cân (Tiền béo phì)");
            Console.WriteLine($"Khuyên dùng: Cân nặng của bạn nên từ {min_weight:F2} đến {max_weight:F2} (kg)");
        }
        else
        {
            Console.WriteLine($"Chỉ số BMI của bạn: {BMI:F2}");
            Console.WriteLine("Phân loại sức khỏe: Béo phì");
            Console.WriteLine($"Khuyên dùng: Cân nặng của bạn nên từ {min_weight:F2} đến {max_weight:F2} (kg)");
        }

        Console.WriteLine("\n");
    }
    static void Bai3()
    {
        //Quy đổi tiền tệ
        Console.Write("Nhập vào số tiền VNĐ: ");
        decimal enter_vnd = decimal.Parse(Console.ReadLine());
        int choice;
        decimal real_vnd = enter_vnd - (0.5m / 100) * enter_vnd;

        do
        {
            Console.Write(@"Chọn ngoại tệ (1-USD; 2-EUR; 3-JPY; 4-GBP): ");
            choice = int.Parse(Console.ReadLine());
            int[] list = { 1, 2, 3, 4 };
            if (list.Contains(choice) is true) break;
            else
                Console.WriteLine("Bạn chưa chọn đúng loại ngoại tệ!");

        }
        while (true);

        decimal exchange;
        currency mode = (currency)choice;

        switch (mode)
        {
            case currency.USD:
                exchange = real_vnd / 25400;
                break;
            case currency.EUR:
                exchange = real_vnd / 27200;
                break;
            case currency.JPY:
                exchange = real_vnd / 165;
                break;
            case currency.GBP:
                exchange = real_vnd / 32100;
                break;
            default:
                exchange = 0m;
                break;
        }    
        


        Console.WriteLine("\nBẢNG QUY ĐỔI NGOẠI TỆ");
        Console.WriteLine($"Phí dịch vụ: {(0.5m/100)*enter_vnd}");
        Console.WriteLine($"Số tiền thực tế để đổi ngoại tệ: {real_vnd:N0}");
        Console.WriteLine($"Số tiền {Enum.GetName(typeof(currency),choice)} nhận được là: {exchange:N2}");


    }

    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        //Bai1();
        //Bai2();
        //Bai3();
    }
}