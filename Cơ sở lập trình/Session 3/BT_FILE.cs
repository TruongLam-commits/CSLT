using System.Text;
using System.Globalization;
using Microsoft.VisualBasic;
using System.Runtime.InteropServices;
using System.ComponentModel.DataAnnotations;

internal class BT_THUC_TE
{
    enum currency
    {
        USD = 1,
        EUR = 2,
        JPY = 3,
        GBP = 4,
    }
    enum score
    {
        A = 4,
        B = 3,
        C = 2,
        D = 1,
        F = 0,


    }
    enum Status
    {
        OutOfStock,
        LowStock,
        InStock,
        Discontinued
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
    static void Bai4()
    {

    //TÍNH TUỔI
        Console.Write("Enter your Date of Birth (dd/MM/yyyy): ");

        DateTime now = DateTime.Today;
       
        
        bool success = DateTime.TryParseExact(
            Console.ReadLine(),
            "dd/MM/yyyy",
            CultureInfo.InvariantCulture,
            DateTimeStyles.None,
            out DateTime customer_input);

        DateTime next_birthday = new DateTime(now.Year, customer_input.Month, customer_input.Day);

        int age = now.Year - customer_input.Year;
        if (customer_input.Date > now.AddYears(-age)) age--; //-1 age if your birhday has not come yet in this year

        if (next_birthday < now) next_birthday = next_birthday.AddYears(1);
        int remain = (next_birthday - now).Days; 

        if (success)
        {
            Console.WriteLine($"\nYour age is: {age} years old");
            Console.WriteLine($"You have been living for: {(now - customer_input).Days} days");
            if (remain == 0) Console.WriteLine("Happy birthday");
            else Console.WriteLine($"Your next birthday is within {remain} days");
        }
        else Console.WriteLine("Your input can not validated");
    }
    static void Bai5()
    {
        Console.Write("Nhập điểm môn C#   (4TC): "); double cslt = double.Parse(Console.ReadLine()); int cslt_credit = 4;
        Console.Write("Nhập điểm môn Toán (3TC): "); double toan = double.Parse(Console.ReadLine()); int toan_credit = 3;
        Console.Write("Nhập điểm môn TA   (2TC): "); double eng = double.Parse(Console.ReadLine()); int eng_credit = 2;

        double GPA = ((cslt * cslt_credit) + (toan * toan_credit) + (eng * eng_credit))/(cslt_credit + toan_credit + eng_credit);

        score grade = GPA switch
        {
            >= 8.5 => score.A,
            >= 7.0 => score.B,
            >= 5.5 => score.C,
            >= 4.0 => score.D,
            _      => score.F
        };

        string rank = grade switch
        {
            score.A => "Xuất sắc",
            score.B => "Khá",
            score.C => "Trung bình",
            score.D => "Yếu",
            _ => "Kém"
        };

        Console.WriteLine($"\nĐiểm TB thang 10: {GPA:F2}");
        Console.WriteLine($"Điểm chữ quy đổi: {grade}");
        Console.WriteLine($"Điểm GPA Thang 4: {(double) grade:F2}");
        Console.WriteLine($"Xếp loại học lực: {rank}");

    }

    static string Khongdau(string text)
    {
        string norm = text.Normalize(NormalizationForm.FormD);
        StringBuilder sb = new StringBuilder();
        
        foreach (char c in norm)
        {
            UnicodeCategory cat = CharUnicodeInfo.GetUnicodeCategory(c);
            if (cat != UnicodeCategory.NonSpacingMark)
            {
                sb.Append(c);
            }
        }
        return sb.ToString().Normalize(NormalizationForm.FormC).Replace("Đ", "D").Replace("đ", "d");
    }
    static void Bai6()
    {
        Console.Write("Hãy nhập tên của bạn: "); string input = Console.ReadLine();
        string[] name = input.ToLower().Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < name.Length; i++)
        {
            name[i] = char.ToUpper(name[i][0]) + name[i].Substring(1);
        }

        string tendem = "";
        if (name.Length > 3) tendem = string.Join(" ", name, 1, name.Length - 2);
        else tendem = name[1];
        
        string full_name = string.Join(" ", name);

        string[] no_mark = Khongdau(full_name).ToLower().Split(' ', StringSplitOptions.RemoveEmptyEntries);
        string ten_khong_dau = no_mark[no_mark.Length - 1];
        string ho_va_ten_dem_khong_dau = string.Join("",no_mark,0,no_mark.Length - 2);

        string username = $"{ten_khong_dau}.{ho_va_ten_dem_khong_dau}";


        Console.WriteLine($"Họ tên chuẩn hóa: {full_name}");
        Console.WriteLine($"Họ: {name[0]} | Tên đệm: {tendem} | Tên: {name[name.Length - 1]}");
        Console.WriteLine($"Username tạo tự động: {username}");
        Console.WriteLine($"Email cấp phát: {username}@company.edu.vn");
        
    }

    static void Bai7()
    {
        Console.Write("Quãng đường (km): ");
        double s = double.Parse(Console.ReadLine());
        Console.Write("Mức tiêu hao (L/100km): ");
        double e = double.Parse(Console.ReadLine());
        Console.Write("Giá xăng (VNĐ/Lít): ");
        decimal price = decimal.Parse(Console.ReadLine());
        Console.Write("Số người đi: ");
        int people = int.Parse(Console.ReadLine());

        double total_petrol = s / 100 * e;
        decimal petrol_cost = (decimal)total_petrol * price;

        decimal cost_per_capita = Math.Ceiling((petrol_cost / people)/1000m) * 1000m; //chia 1000 nhân 1000 để làm tròn

        Console.WriteLine($"\nTổng nhiên liệu tiêu thụ: {total_petrol:F2} Lít");
        Console.WriteLine($"Tổng chi phí xăng dầu: {petrol_cost:N0} VNĐ");
        Console.WriteLine($"Chi phí mỗi người: {cost_per_capita:N0} VNĐ");



    }
    static void Bai8()
    {
        string OTP = "839201";
        DateTime creationTime = DateTime.Now;
        Console.Write("Mã OTP nhận được: "); string input = Console.ReadLine();
        Console.Write("Thời gian đã trôi qua: "); string time = Console.ReadLine();

        string[] split = time.Split(new string[] { "phút", "giây" }, StringSplitOptions.RemoveEmptyEntries);
        int minute = int.Parse(split[0].Trim());
        int sec = int.Parse(split[1].Trim());

        TimeSpan duration = new TimeSpan(0, minute, sec);

        //Kiểm tra định dạng
        if (!(input?.Length == 6 && int.TryParse(input, out _)))
        {
            Console.WriteLine("LỖI: Định dạng không hợp lệ");
            return;
        }

        //Kiểm tra thời gian
        if (duration.TotalSeconds > 300 || duration.TotalSeconds < 0)
        {
            Console.WriteLine("LỖI: Mã OTP hết hạn");
            return;
        }

        //Kiểm tra mã khớp
        if (input != OTP)
        {
            Console.WriteLine("LỖI: Mã OTP không khớp");
            return;
        }

        Console.WriteLine("THÀNH CÔNG: Giao dịch được phê duyệt");
    }
    static void Bai9()
    {
        Console.Write("Lương Gross (VNĐ): "); decimal gross_salary = decimal.Parse(Console.ReadLine());
        Console.Write("Số người phụ thuộc: "); int people = int.Parse(Console.ReadLine());

        decimal insurance = 10.5m / 100m * gross_salary;
        decimal income_tax = gross_salary - insurance - 11000000m - (4400000m * people);

        if (income_tax < 0) income_tax = 0;

        decimal personal_tax;
        if (income_tax <= 5000000) personal_tax = 5m / 100m * income_tax;
        else if (income_tax <= 10000000) personal_tax = 5m / 100m * 5000000 + (income_tax - 5000000) * (10m / 100m);
        else personal_tax = 5m / 100m * 5000000 + 10m / 100m * 5000000 + (income_tax - 10000000) * (15m / 100m);

        decimal NET = gross_salary - insurance - personal_tax;

        Console.WriteLine($"\nGiảm trừ bảo hiểm (10.5%): {insurance:N0} VNĐ");
        Console.WriteLine($"Thu nhập chịu thuế: {income_tax:N0} VNĐ");
        Console.WriteLine($"Thuế TNCN phải nộp: {personal_tax:N0} VNĐ");
        Console.WriteLine($"Lương NET thực nhận: {NET:N0} VNĐ");

    }
    
 
    static void Bai10()
    {
        string ten_sp = "Bàn phím Cơ Akko";
        string ma_sp = "KB-09";
        Console.WriteLine($"{ten_sp} (Mã: {ma_sp})");

        int minThreshold = 10;
        Console.Write("Restock Date: ");

        DateTime? restockDate = DateTime.TryParseExact(
            Console.ReadLine(),
            "dd/MM/yyyy",
            CultureInfo.InvariantCulture,
            DateTimeStyles.None,
            out DateTime dt) ? dt : null; //toán tử ba ngôi

        int? quantity = null;
        int display_quantity =  quantity ?? 0;

        Status status;
        if (quantity == null || quantity <= 0) status = Status.OutOfStock;
        else if (quantity < minThreshold) status = Status.LowStock;
        else status = Status.InStock;

        Console.WriteLine($"Số lượng hiển thị: {display_quantity}");
        Console.WriteLine($"Trạng thái kho: {status}");
        string restock = restockDate?.ToString("dd/MM/yyyy") ?? "Chưa có lịch nhập hàng";
        Console.WriteLine($"Ngày dự kiến nhập tiếp theo: {restock}");



    }
    static void Bai11()
    {
        Console.Write("Số tiền gửi (VNĐ): "); decimal tien_gui = decimal.Parse(Console.ReadLine());
        Console.Write("Lãi suất năm (%/năm): "); double lai_suat = double.Parse(Console.ReadLine());
        Console.Write("Thời gian gửi (tháng): "); int thang = int.Parse(Console.ReadLine());

        decimal lai_don = tien_gui * ((decimal)lai_suat / 100m) * (thang / 12.0m);

        decimal tong_tien_nhan = tien_gui * (decimal)Math.Pow(1 + (lai_suat/100/12), thang);
        decimal lai_kep = tong_tien_nhan - tien_gui;

        Console.WriteLine($"\nTổng tiền (Lãi đơn): {lai_don:N0} VNĐ");
        Console.WriteLine($"Tổng tiền (Lãi kép): {lai_kep:N0} VNĐ");
        Console.WriteLine($"Lợi nhuận chênh lệch: {lai_kep - lai_don:N0} VNĐ");
    }
    static void Bai12()
    {
        Console.Write("Văn bản gốc: "); string input = Console.ReadLine();
        Console.Write("Khóa dịch chuyển (Shift Key k) từ 1 - 25: "); int k = int.Parse(Console.ReadLine());

        StringBuilder sb = new StringBuilder();
        foreach (int c in input)
        {
            if (c >= (int)'A' && c <= (int)'Z')
            {
                char newChar = (char)((int)'A' + (c - (int)'A' + k) % 26);
                sb.Append(newChar);
            }
            else if (c >= (int)'a' && c <= (int)'z')
            {
                char newChar = (char)((int)'a' + (c - (int)'a' + k) % 26);
                sb.Append(newChar);
            }
            else
            {
                sb.Append((char)c);
            }
        }

        Console.WriteLine($"Văn bản Mã hóa: {sb}");

        string encrypted = sb.ToString();
        StringBuilder decrypted = new StringBuilder();

        foreach (char c in encrypted)
        {
            if (c >= (int)'A' && c <= (int)'Z')
            {
                int shifted = c - (int)'A' - k;
                if (shifted < 0) shifted += 26;
                decrypted.Append((char)('A' + shifted));
            }
            else if (c >= (int)'a' && c <= (int)'z')
            {
                int shifted = (c - (int)'a' - k);
                if (shifted < 0) shifted += 26;
                decrypted.Append((char)('a' + shifted));
            }
            else decrypted.Append((char)c);
        }
        Console.WriteLine($"Văn bản Giải mã: {decrypted}");
    }
    
    enum VehicleType
    {
        Motorbike,
        Car,
        Truck
    }
    static void Bai13()
    {
        Console.Write("Loại xe (Motorbike - Car - Truck): ");
        string vehicleInput = Console.ReadLine();

        Console.Write("Giờ vào (yyyy-MM-dd HH:mm): ");
        bool checkin = DateTime.TryParseExact(
            Console.ReadLine(),
            "yyyy-MM-dd HH:mm",
            CultureInfo.InvariantCulture,
            DateTimeStyles.None,
            out DateTime checkin_input);

        Console.Write("Giờ ra (yyyy-MM-dd HH:mm): ");
        bool checkout = DateTime.TryParseExact(
            Console.ReadLine(),
            "yyyy-MM-dd HH:mm",
            CultureInfo.InvariantCulture,
            DateTimeStyles.None,
            out DateTime checkout_input);

        bool isValidVehicle = Enum.TryParse<VehicleType>(vehicleInput, true, out VehicleType vehicleType);

        if (checkin && checkout && isValidVehicle && checkout_input >= checkin_input)
        {
            decimal TotalHours = (decimal)(checkout_input - checkin_input).TotalHours;
            int real = (int) Math.Ceiling(TotalHours);

            decimal firstTwoHoursRate;
            decimal nextHourRate;

            switch (vehicleType)
            {
                case VehicleType.Motorbike:
                    firstTwoHoursRate = 5000m;
                    nextHourRate = 2000m;
                    break;
                case VehicleType.Car:
                    firstTwoHoursRate = 20000m;
                    nextHourRate = 10000m;
                    break;
                case VehicleType.Truck:
                default:
                    firstTwoHoursRate = 50000m;
                    nextHourRate = 25000m;
                    break;
            }
            
            int extraHours = real > 2 ? real - 2 : 0;
            decimal restPrice = extraHours * nextHourRate;

            decimal subFee = (checkout_input.Date > checkin_input.Date) ? 30000m : 0;
            decimal total = firstTwoHoursRate + restPrice + subFee;

            Console.WriteLine($"Tổng thời gian đỗ: {TotalHours:F2} giờ -> Tính phí: {real} giờ");
            Console.WriteLine($"Phí 2 giờ đầu: {firstTwoHoursRate:N0} VNĐ");
            Console.WriteLine($"Phí {extraHours} giờ tiếp theo: {restPrice:N0} VNĐ ({nextHourRate} x {extraHours})");
            Console.WriteLine($"TỔNG PHÍ ĐỖ XE: {total:N0} VNĐ");
        }
        else Console.WriteLine("Bạn chưa nhập đúng định dạng");
    }

    private static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;

        //Bai1();
        //Bai2();
        //Bai3();
        //Bai4();
        //Bai5();
        //Bai6();
        //Bai7();
        //Bai8();
        //Bai9();
        //Bai10();
        //Bai11();
        //Bai12();
        //Bai13();
    }
}