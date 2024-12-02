using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi5_loop
{
    internal class BTVN
    {
        // Bài 1: Viết chương trình bằng C# Sharp để hiển thị một mẫu như hình tam giác vuông có số
        //        Output: 
        //1
        //12
        //123
        //1234

        public static void Bai1()
        {
            Console.Write("Nhap so hang cua tam giac: ");
            int n1;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out n1))
                {
                    break;
                }
                Console.WriteLine("Vui long nhap so nguyen");
            }
            for (int i = 1; i <= n1; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }

        // Bài 2: Viết chương trình bằng C# Sharp để tạo một mẫu như một tam giác vuông với một số lặp lại một số liên tiếp.
        //        Output
        //1
        //22
        //333
        //4444
        public static void Bai2()
        {
            Console.Write("Nhap so hang cua tam giac: ");
            int n2;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out n2))
                {
                    break;
                }
                Console.Write("Vui long nhap so nguyen: ");
            }
            for (int i = 1; i <= n2; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }

        // Bài 3: Viết chương trình bằng C# Sharp để tạo một mẫu như hình kim tự tháp có dấu hoa thị.

        //   *
        //  * * 
        // * * *
        //* * * *

        public static void Bai3()
        {
            Console.Write("Nhap so hang cua tam giac: ");
            int n3;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out n3))
                {
                    break;
                }
                Console.Write("Vui long nhap so nguyen: ");
            }
            for (int i = 1; i <= n3; i++)
            {
                for (int j = 1; j <= n3 - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }


        // Bai 4: Viết chương trình bằng C# Sharp để hiển thị n số hạng của chuỗi  và tổng của chúng.
        //1 + 1/2 + 1/3 + 1/4 + 1/5 ... 1/n số hạng
        //Dữ liệu thử nghiệm:
        //Nhập số từ: 5
        //Output::
        //1/1 + 1/2 + 1/3 + 1/4 + 1/5 +
        //Tổng của dãy tối đa 5 số hạng: 2.283334

        public static void Bai4()
        {
            Console.Write("Nhap so phan tu cua chuoi: ");
            int n4;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out n4))
                {
                    break;
                }
                Console.Write("Vui long nhap so nguyen: ");
            }
            double sum = 0;
            for (int i = 1; i <= n4; i++)
            {
                Console.Write($"1/{i} ");
                sum += 1.0 / i;
                if (i != n4)
                {
                    Console.Write("+ ");
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Tong cua day toi da {n4} so hang: {sum}");
        }

    }
}
