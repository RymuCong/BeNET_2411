namespace Buoi6_List;

public class Bai1
{
    public static void Main()
    {
        List<Student> students = new()
        {
            new Student { Name = "Alice", Math = 9, Physics = 8, Chemistry = 7 },
            new Student { Name = "Bob", Math = 6, Physics = 8, Chemistry = 9 },
            new Student { Name = "Charlie", Math = 1, Physics = 7, Chemistry = 7 },
            new Student { Name = "David", Math = 9, Physics = 10, Chemistry = 8 },
            new Student { Name = "Eve", Math = 6, Physics = 3, Chemistry = 9 }
        };

        students.Sort((a, b) => b.Average.CompareTo(a.Average));
        students.ForEach(Console.WriteLine);
    }
}

class Student
{
    public string Name { get; set; }
    public double Math { get; set; }
    public double Physics { get; set; }
    public double Chemistry { get; set; }
    public double Average => (Math + Physics + Chemistry) / 3;
    public override string ToString() => $"{Name} - {Average}"; 
}