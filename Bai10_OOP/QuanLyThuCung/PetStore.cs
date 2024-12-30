namespace QuanLyThuCung;

public class PetStore
{
    private List<Pet> pets = new List<Pet>();

    public void AddPet(Pet pet)
    {
        pets.Add(pet);
    }

    public void DisplayAllPets()
    {
        foreach (var pet in pets)
        {
            Console.WriteLine($"Pet ID: {pet.PetID}, Tên: {pet.Name}, Tuổi: {pet.CalculateHumanAge()}");
            pet.Speak();
        }
    }
    
    public List<Pet> GetPetsByType<T>() where T : Pet
    {
        return pets.OfType<Pet>().ToList();
    }
}