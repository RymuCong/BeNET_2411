namespace Bai10_OOP.Bai1;

public abstract class LibraryItem
{
    public string ItemID { get; set; }
    public string Title { get; set; }
    public int AvailableCopies { get; set; } 

    public abstract void DisplayInfo();
    public void ReturnItem()
    {
        AvailableCopies++;
    }
}
