namespace Buoi6_List;

public class Bai2
{
    public static void Main()
    {
        List<string> fruits = new() { "apple", "banana", "kiwi", "pear", "mango" };
        fruits.Sort((a, b) =>
        {
            if (a.Length != b.Length)
            {
                return a.Length.CompareTo(b.Length);
            }
            return a.CompareTo(b);
        });
        fruits.ForEach(Console.WriteLine);
    }
}