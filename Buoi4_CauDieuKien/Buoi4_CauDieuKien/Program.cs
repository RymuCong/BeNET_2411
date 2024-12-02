// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


// Exercise 1
//1.Viết chương trình C# để kiểm tra xem một số nguyên nhập từ người dùng là số chẵn hay lẻ.
//2.Viết chương trình C# để tìm số lớn nhất trong ba số nhập từ người dùng.
//Exercise 2
//1. Viết chương trình kiểm tra 1 năm có phải năm nhuận hay không, biết rằng 1 năm nếu là năm nhuận thì vừa chia hết cho 100 vừa chia hết cho 400 hoặc vừa không chia hết cho 100 và vừa chia hết cho 4
Console.OutputEncoding = System.Text.Encoding.UTF8;
#region Bai1_1
Console.Write("Nhập số nguyên: ");
int number = int.Parse(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine($"{number} là số chẵn.");
}
else
{
    Console.WriteLine($"{number} là số lẻ.");
}
#endregion

#region Bai1_2
Console.Write("Nhập số thứ nhất: ");
int num1 = int.Parse(Console.ReadLine());

Console.Write("Nhập số thứ hai: ");
int num2 = int.Parse(Console.ReadLine());

Console.Write("Nhập số thứ ba: ");
int num3 = int.Parse(Console.ReadLine());

int max = num1;

if (num2 > max)
{
    max = num2;
}

if (num3 > max)
{
    max = num3;
}

Console.WriteLine($"Số lớn nhất trong ba số là: {max}");
#endregion

#region Bai2_1
Console.Write("Nhập một năm: ");
int year = int.Parse(Console.ReadLine());

bool checkNamNhuan = (year % 400 == 0) || (year % 100 != 0 && year % 4 == 0);

if (checkNamNhuan)
{
    Console.WriteLine($"{year} là năm nhuận.");
}
else
{
    Console.WriteLine($"{year} không phải là năm nhuận.");
}
#endregion
