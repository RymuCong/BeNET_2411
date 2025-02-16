using System.Text;

namespace Module1_Test;

public class Bai2
{
    public static void Main() {
        Console.OutputEncoding = Encoding.UTF8;
        int[] array = {1, 5, 7, -1, 5};
        int k = 6; 
        TimCap(array, k);
    }

    static void TimCap(int[] array, int k) {
        Dictionary<int, int> map = new Dictionary<int, int>();

        for (int i = 0; i < array.Length; i++) {
            int hieu = k - array[i];
            if (map.ContainsKey(hieu)) {
                Console.WriteLine($"Cặp phần tử ({hieu}, {array[i]}) có tổng bằng {k}");
            }
            if (!map.ContainsKey(array[i])) {
                map.Add(array[i], i);
            }
        }
    }
}