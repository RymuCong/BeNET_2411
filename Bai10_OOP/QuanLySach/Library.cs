namespace Bai10_OOP.Bai1;

public class Library
{
    private List<LibraryItem> items = new List<LibraryItem>();

    public void AddItem(LibraryItem item)
    {
        items.Add(item);
    }

    public void DisplayAllItems()
    {
        foreach (var item in items)
        {
            item.DisplayInfo();
        }
    }
    
    public void FilterByPublicationYear(int year)
    {
        bool hasItem = false;
        foreach (var item in items)
        {
            if (item is Magazine magazine && magazine.PublicationDate.Year == year)
            {
                magazine.DisplayInfo();
                hasItem = true;
            }
        }
        if (!hasItem)
        {
            Console.WriteLine("Không có tạp chí nào được xuất bản vào năm " + year);
        }
    }
}