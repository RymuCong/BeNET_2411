using System.Text;
using Bai10_OOP.Bai1;

namespace QuanLySach;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
     
        Book book1 = new Book { ItemID = "B001", Title = "C# Programming", Author = "John Doe", Genre = "Education", AvailableCopies = 5 };
        Book book2 = new Book { ItemID = "B002", Title = "Java Fundamentals", Author = "Jane Doe", Genre = "Education", AvailableCopies = 3 };
        Magazine magazine1 = new Magazine { ItemID = "M001", Title = "Tech Today", IssueNumber = 1, PublicationDate = new DateTime(2023, 1, 1), AvailableCopies = 10 };
        Magazine magazine2 = new Magazine { ItemID = "M002", Title = "Science Monthly", IssueNumber = 2, PublicationDate = new DateTime(2024, 2, 1), AvailableCopies = 8 };
        
        Library library = new Library();
        library.AddItem(book1);
        library.AddItem(book2);
        library.AddItem(magazine1);
        library.AddItem(magazine2);
        
        Console.WriteLine("Hiển thị thông tin tất cả các tài liệu:");
        library.DisplayAllItems();
        
        Console.WriteLine("\nMượn một quyển sách:");
        book1.BorrowItem();
        book1.DisplayInfo();
        
        Console.WriteLine("\nTrả sách:");
        book1.ReturnItem();
        book1.DisplayInfo();
        
        Console.WriteLine("\nHiển thị các tạp chí theo năm xuất bản 2023:");
        library.FilterByPublicationYear(2023);
    }
}