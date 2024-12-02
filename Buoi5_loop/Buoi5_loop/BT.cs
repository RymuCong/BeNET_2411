using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Buoi5_loop
{
     class BT
    {
        // Bài 1:  Viết chương trình trong C# Sharp để in tất cả các phần tử duy nhất trong một mảng.

        //        Test Data :

        //Nhập số phần tử cần lưu trong mảng :3

        //Nhập 3 phần tử vào mảng:

        //element  - 0 : 1

        //element  - 1 : 5

        //element  - 2 : 1

        //Expected Output :

        //Các phần tử duy nhất được tìm thấy trong mảng là: 5

        public static void Bai1()
        {
            Console.Write("Nhap so phan tu cua mang: ");
            var n = int.Parse(Console.ReadLine());
            var arr = new int[n];
            var count = new int[100000];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"element - {i}: ");
                arr[i] = int.Parse(Console.ReadLine());
                count[arr[i]]++;
            }
            Console.Write("Cac phan tu duy nhat duoc tim thay trong mang la: ");
            for (int i = 0; i < n; i++)
            {
                if (count[arr[i]] == 1)
                {
                    Console.Write(arr[i] + " ");
                }
            }
        }

        // Viết chương trình bằng C# Sharp để tách các số nguyên lẻ và số chẵn thành các mảng riêng biệt.

        //        Test Data :

        //Nhập số phần tử cần lưu trữ trong mảng :5

        //Nhập 5 phần tử vào mảng:

        //element  - 0 : 25

        //element  - 1 : 47

        //element  - 2 : 42

        //element  - 3 : 56

        //element  - 4 : 32

        //Expected Output :

        //Các phần tử Chẵn là: 42 56 32

        //Các phần tử lẻ là: 25 47
        public static void Bai2()
        {
            Console.Write("Nhap so phan tu cua mang: ");
            var n = int.Parse(Console.ReadLine());
            var arr = new int[n];
            var even = new List<int>();
            var odd = new List<int>();
            for (int i = 0; i < n; i++)
            {
                Console.Write($"element - {i}: ");
                arr[i] = int.Parse(Console.ReadLine());
                if (arr[i] % 2 == 0)
                {
                    even.Add(arr[i]);
                }
                else
                {
                    odd.Add(arr[i]);
                }
            }
            Console.Write("Cac phan tu chan la: ");
            foreach (var item in even)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.Write("Cac phan tu le la: ");
            foreach (var item in odd)
            {
                Console.Write(item + " ");
            }
        }

    }
}
