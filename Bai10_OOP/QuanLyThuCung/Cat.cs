namespace QuanLyThuCung;

public class Cat : Pet
{
    public string Color { get; set; }

    public override void Speak()
    {
        Console.WriteLine("Meow!");
    }
}