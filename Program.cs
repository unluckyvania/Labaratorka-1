using System;

// СНАЧАЛА основной код программы
Rectangle rect = new Rectangle();
rect.height = 2;
rect.width = 3;
rect.Show();
float p = rect.Perimetr();
Console.WriteLine("Perimeter: " + p);
Console.ReadKey();

// ПОТОМ объявление класса
class Rectangle
{
    public float height;
    public float width;

    public void Show()
    {
        Console.WriteLine("Rectangle:");
        Console.WriteLine("  Height: " + height);
        Console.WriteLine("  Width: " + width);
    }

    public float Perimetr()
    {
        return 2 * (height + width);
    }
}