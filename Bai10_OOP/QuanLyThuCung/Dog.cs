namespace QuanLyThuCung;

public class Dog : Pet
{
    public string Breed { get; set; }

    public override void Speak()
    {
        Console.WriteLine("Gâu gâu!");
    }
    
}