namespace Buoi6_List;

public class Bai5
{
    public static void main()
    {
        List<int> numbers = new() { 1, 3, 4, 2, 5, 6, 7 };
        int K = 9;
        HashSet<int> set = new();
        List<(int, int)> cap = new();
        foreach (var number in numbers)
        {
            if (set.Contains(K - number))
            {
                cap.Add((number, K - number));
            }
            set.Add(number);
        }
        foreach (var pair in cap)
        {
            Console.WriteLine(pair);
        }
    }
}