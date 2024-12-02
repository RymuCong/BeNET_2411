// See https://aka.ms/new-console-template for more information
// Viết chương trình nhập thông tin sinh viên: tên, tuổi, điểm toán, điểm văn, điểm anh.
// Sau khi nhập xong thì in ra thông tin tên – tuổi – điểm trung bình 3 môn. Tuổi trong khoảng từ 12 => 15.
// Điểm là số thực trong khoảng từ 0, đến 10.
// Trong quá trình nhập nếu người dùng nhập thông tin tuổi và điểm không hợp lệ thì yêu cầu nhập đến khi nào hợp lệ mới thôi.
// Sau khi nhập xong 1 học sinh, hỏi người dùng có muốn tiếp tục hay không (y/n).
// Nếu bấm “y” thì tiếp tục nhập học sinh, ngược lại thoát chương trình.

using Buoi5_loop;
//BTVN.Bai1();
//BTVN.Bai2();
//BTVN.Bai3();
BTVN.Bai4();
//BT.Bai1();
//BT.Bai2();





//while (true)
//{
//    var student = new Student();
//    Console.Write("Nhap ten: ");
//    student.Name = Console.ReadLine();
//    Console.Write("Nhap tuoi: ");
//    while (true)
//    {
//        if (int.TryParse(Console.ReadLine(), out var age) && age >= 12 && age <= 15)
//        {
//            student.Age = age;
//            break;
//        }
//        Console.WriteLine("Tuoi phai trong khoang tu 12 den 15");
//    }
//    Console.Write("Nhap diem toan: ");
//    while (true)
//    {
//        if (double.TryParse(Console.ReadLine(), out var math) && math >= 0 && math <= 10)
//        {
//            student.Math = math;
//            break;
//        }
//        Console.WriteLine("Diem phai trong khoang tu 0 den 10");
//    }
//    Console.Write("Nhap diem van: ");
//    while (true)
//    {
//        if (double.TryParse(Console.ReadLine(), out var literature) && literature >= 0 && literature <= 10)
//        {
//            student.Literature = literature;
//            break;
//        }
//        Console.WriteLine("Diem phai trong khoang tu 0 den 10");
//    }
//    Console.Write("Nhap diem anh: ");
//    while (true)
//    {
//        if (double.TryParse(Console.ReadLine(), out var english) && english >= 0 && english <= 10)
//        {
//            student.English = english;
//            break;
//        }
//        Console.WriteLine("Diem phai trong khoang tu 0 den 10");
//    }
//    Console.Write("Ban co muon tiep tuc khong?");
//    if (Console.ReadLine() != "y")
//    {
//        for (int i = 0; i < students.Count; i++)
//        {
//            Console.WriteLine($"Ten: {student.Name}, Tuoi: {student.Age}, Diem trung binh: {(student.Math + student.Literature + student.English) / 3}");
//        }
//        break;
//    }
//}

//Bai 2: Viết một ứng dụng từ điển đơn giản: 
//+Tạo  một mảng gồm các từ tiếng anh (vd: book, chair, pen, ruler…)
//+ Tạo một mảng gồm nghĩa tiếng việt tương ứng (vd: sách, ghế, bút, thước…)
//+ Khi người dùng nhập vào 1 từ tiếng anh thì trả ra nghĩa của từ tiếng Việt tương ứng. Trong trường hợp không có thì trả ra “không tìm thấy”.


//var englishWords = new[] { "book", "chair", "pen", "ruler" };
//var vietnameseWords = new[] { "sach", "ghe", "but", "thuoc" };

//Console.Write("Nhap tu tieng anh: ");
//var input = Console.ReadLine();
//var index = Array.IndexOf(englishWords, input);

//if (index == -1)
//{
//    Console.WriteLine("Khong tim thay");
//}
//else
//{
//    Console.WriteLine(vietnameseWords[index]);
//}