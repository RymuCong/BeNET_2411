using System.Text;

namespace QuanLyHinhHoc;

public class Program
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        List<Shape> shapes = new List<Shape>();
        
        Circle circle1 = new Circle { Radius = 5 };
        Circle circle2 = new Circle { Radius = 10 };
        shapes.Add(circle1);
        shapes.Add(circle2);
        
        Rectangle rectangle1 = new Rectangle { Width = 4, Height = 6 };
        Rectangle rectangle2 = new Rectangle { Width = 8, Height = 3 };
        shapes.Add(rectangle1);
        shapes.Add(rectangle2);
        
        foreach (var shape in shapes)
        {
            if (shape is Circle)
            {
                Console.WriteLine("Hình tròn:");
            }
            else if (shape is Rectangle)
            {
                Console.WriteLine("Hình chữ nhật:");
            }
            Console.WriteLine($"Diện tích: {Math.Round(shape.CalculateArea(), 2)}, Chu vi: {Math.Round(shape.CalculatePerimeter(), 2)}");
        }
    }
}