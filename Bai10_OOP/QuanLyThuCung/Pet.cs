namespace QuanLyThuCung;

public abstract class Pet
{
    public string PetID { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }

    public abstract void Speak();
    public void Feed()
    {
        Console.WriteLine($"{Name} được cho ăn.");
    }
    public int CalculateHumanAge()
    {
        return Age * 7;
    }
}