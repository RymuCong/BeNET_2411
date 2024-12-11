namespace Buoi6_List;

public class Bai4
{
    public static void main()
    {
        List<int> numbers = new() { 3, 1, 4, 5, 2, 6, 9, 8 };
        int n = numbers.Count + 1;
        int sum = n * (n + 1) / 2;
        foreach (var number in numbers)
        {
            sum -= number;
        }
        Console.WriteLine(sum);
    }
}