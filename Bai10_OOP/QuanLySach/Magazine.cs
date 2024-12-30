namespace Bai10_OOP.Bai1;

public class Magazine : LibraryItem
{
    public int IssueNumber { get; set; }
    public DateTime PublicationDate { get; set; }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Tiêu đề: {Title}, Số báo: {IssueNumber}, Ngày xuất bản: {PublicationDate.ToShortDateString()}, Số lượng: {AvailableCopies}");
    }

    public void BorrowItem()
    {
        if (AvailableCopies > 0)
            AvailableCopies--;
        else
            Console.WriteLine("Hết tạp chí để mượn");
    }
}