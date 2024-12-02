// See https://aka.ms/new-console-template for more information
// Bài 1: In bảng cửu chương
//Đề bài:
//Viết chương trình in ra bảng cửu chương từ 1 đến 10.
Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("Bảng cửu chương");
for (int i = 1; i <= 10; i++)
{
    for (int j = 1; j <= 10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i * j}");
    }
    Console.WriteLine();
}


// Bài 2: Viết chương trình kiểm tra một số nguyên dương  n
//n nhập vào từ bàn phím có phải là số nguyên tố hay không.

Console.WriteLine("Nhập số nguyên dương n: ");
int n = int.Parse(Console.ReadLine());
bool isPrime = true;

for (int i = 2; i <= Math.Sqrt(n); i++)
{
    if (n % i == 0)
    {
        Console.WriteLine($"{n} không phải là số nguyên tố");
        isPrime = false;
        break;
    }
}

if (isPrime)
{
    Console.WriteLine($"{n} là số nguyên tố");
}

// Bài 3:  Tìm số hoàn hảo trong một khoảng
// Viết chương trình tìm tất cả các số hoàn hảo trong khoảng từ 1 đến n (nhập từ bàn phím).

Console.WriteLine("Nhập số nguyên dương n: ");
int n3 = int.Parse(Console.ReadLine());

Console.WriteLine("Các số hoàn hảo trong khoảng từ 1 đến {0} là: ", n3);

for (int i = 2; i <= n3; i++)
{
    int sum = 1;
    for (int j = 2; j <= Math.Sqrt(i); j++)
    {
        if (i % j == 0)
        {
            sum += j;
            if (j != i / j)
            {
                sum += i / j;
            }
        }
    }
    if (sum == i)
    {
        Console.WriteLine(i);
    }
}