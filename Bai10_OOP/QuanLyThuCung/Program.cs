using System.Text;

namespace QuanLyThuCung;

public class Program
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        PetStore petStore = new PetStore();
        
        Dog dog1 = new Dog { PetID = "D001", Name = "Buddy", Age = 3, Breed = "Labrador" };
        Dog dog2 = new Dog { PetID = "D002", Name = "Charlie", Age = 2, Breed = "Beagle" };
        petStore.AddPet(dog1);
        petStore.AddPet(dog2);
        
        Cat cat1 = new Cat { PetID = "C001", Name = "Whiskers", Age = 5, Color = "Black" };
        Cat cat2 = new Cat { PetID = "C002", Name = "Shadow", Age = 4, Color = "Grey" };
        petStore.AddPet(cat1);
        petStore.AddPet(cat2);
        
        Console.WriteLine("Hiển thị danh sách thú cưng:");
        petStore.DisplayAllPets();
        
        Console.WriteLine("\nHiển thị danh sách chó:");
        var dogs = petStore.GetPetsByType<Dog>();
        foreach (Pet pet in dogs)
        {
            if (pet is Dog)
            { 
                Dog dog = (Dog)pet;
                Console.WriteLine($"Tên: {dog.Name}, Giống: {dog.Breed}");
                dog.Speak();
                dog.Feed();
            }
        }
        
        Console.WriteLine("\nHiển thị danh sách mèo:");
        var cats = petStore.GetPetsByType<Cat>();
        foreach (Pet pet in cats)
        {
            if (pet is Cat)
            {
                Cat cat = (Cat)pet;
                Console.WriteLine($"Tên: {cat.Name}, Màu: {cat.Color}");
                cat.Speak();
                cat.Feed();
            }
        }
    }
}