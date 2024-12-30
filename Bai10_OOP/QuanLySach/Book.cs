namespace Bai10_OOP.Bai1;

public class Book : LibraryItem
{
    public string Author { get; set; }
    public string Genre { get; set; }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Tiêu đề: {Title}, Tác giả: {Author}, Thể loại: {Genre}, Số lượng: {AvailableCopies}");
    }

    public void BorrowItem() 
    {
        if (AvailableCopies > 0)
            AvailableCopies--;
        else
            Console.WriteLine("Hết sách để mượn");
    }
}