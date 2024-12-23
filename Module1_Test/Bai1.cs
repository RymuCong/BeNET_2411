namespace Module1_Test;

using System;
using System.Collections.Generic;

public class Bai1
{
    public static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Nhập số lượng phần tử của mảng:");
        var n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        Console.WriteLine("Nhập các phần tử của mảng:");
        for (var i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        
        Dictionary<int, int> dem = new Dictionary<int, int>();
        foreach (var e in array)
        {
            if (dem.ContainsKey(e))
            {
                dem[e]++;
            }
            else
            {
                dem.Add(e, 1);
            }
        }
        
        Console.WriteLine("Số lần xuất hiện của mỗi phần tử trong mảng:");
        foreach (var pair in dem)
        {
            Console.WriteLine($"Phần tử {pair.Key} xuất hiện {pair.Value} lần.");
        }
    }
}