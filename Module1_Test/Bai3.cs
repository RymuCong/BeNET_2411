using System.Text;

namespace Module1_Test;

public class Bai3
{
     public static void Main() {
        int[] array = {64, 34, 25, 12, 22, 11, 90};
        BubbleSort(array);
        var target = 22;
        var index = TimKiemNhiPhan(array, target, 0, array.Length - 1);
        Console.OutputEncoding = Encoding.UTF8;
        if (index != -1) {
            Console.WriteLine($"Số {target} được tìm thấy tại vị trí {index}");
        } else {
            Console.WriteLine("Không tìm thấy số trong mảng.");
        }
    }

    static void BubbleSort(int[] array) {
        var n = array.Length;
        for (var i = 0; i < n - 1; i++) {
            for (var j = 0; j < n - i - 1; j++) {
                if (array[j] > array[j + 1]) {
                    var temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }

    static int TimKiemNhiPhan(int[] array, int target, int low, int high) {
        while (low <= high) {
            var mid = low + (high - low) / 2;
            if (array[mid] == target) 
                return mid;
            if (array[mid] < target) 
                low = mid + 1;
            else 
                high = mid - 1;
        }
        return -1;
    }
}