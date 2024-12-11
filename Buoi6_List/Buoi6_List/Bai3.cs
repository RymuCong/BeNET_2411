namespace Buoi6_List;

public class Bai3
{
    public static void main()
    {
        List<int> numbers = new() { 3, 1, 4, 5, 2, 6, 11, 16, 14, 3, 6, 9, 8, 10 };
        numbers.Sort((a, b) =>
        {
            if (a % 2 == 0 && b % 2 == 0)
            {
                return a.CompareTo(b);
            }
            if (a % 2 != 0 && b % 2 != 0)
            {
                return b.CompareTo(a);
            }
            return a % 2 == 0 ? -1 : 1;
        });
        for (int i = 0; i < numbers.Count; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    }
}