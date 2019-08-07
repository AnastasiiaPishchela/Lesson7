using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTask7._1
{
    //    Есть отношения наследования: фигура(Shape) – базовый класс, треугольник (Triangle), круг (Circle),
    //прямоугольник (Rectangle) – производные классы от Shape, равнобедренный треугольник
    //(IsoscelesTriangle) – от треугольника, квадрат (Square) – от прямоугольника.Shape имеет методы
    //GetАrea() – возвращает площадь фигуры и GetName() – возвращает название фигуры1
    //.В каждом из
    //производных классов можно определить площадь и узнать имя фигуры. Разработать консольное
    //приложение для демонстрации принципа полиморфизма, используя вывод текстовых сообщений о
    //названии и площади фигуры.
    //Выполнить задание при условии, что фигура (Shape) – интерфейс
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle(3, 5, 7);
            Circle circle = new Circle(15);
            Rectangle rectangle = new Rectangle(7, 13);
            IsoscelesTriangle isoscelesTriangle = new IsoscelesTriangle(5, 8);
            Square square = new Square(4);
            Console.WriteLine($"Shape name: {triangle.GetName()}  Shape square: {triangle.GetArea()}");
            Console.WriteLine($"Shape name: {circle.GetName()}  Shape square: {circle.GetArea()}");
            Console.WriteLine($"Shape name: {rectangle.GetName()}  Shape square: {rectangle.GetArea()}");
            Console.WriteLine($"Shape name: {isoscelesTriangle.GetName()}  Shape square: {isoscelesTriangle.GetArea()}");
            Console.WriteLine($"Shape name: {square.GetName()}  Shape square: {square.GetArea()}");
            Console.ReadKey();
        }
    }

    public interface Shape
    {

        double GetArea();
        string GetName();

    }

    public class Triangle : Shape
    {
        int a;
        int b;
        int c;

        public Triangle(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public double GetArea()
        {
            double p = (a + b + c) / 2.0;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public virtual string GetName()
        {
            return "Triangle";
        }

    }

    public class Circle : Shape
    {
        int radious;

        public Circle(int radious)
        {
            this.radious = radious;
        }
        public double GetArea()
        {
            return 3.14 * radious * radious;
        }

        public string GetName()
        {
            return "Circle";
        }

    }

    public class Rectangle : Shape
    {
        int oneSide;
        int twoSide;

        public Rectangle(int oneSide, int twoSide)
        {
            this.oneSide = oneSide;
            this.twoSide = twoSide;
        }
        public double GetArea()
        {
            return oneSide * twoSide;
        }

        public virtual string GetName()
        {
            return "Rectangle";
        }

    }

    public class IsoscelesTriangle : Triangle
    {

        public IsoscelesTriangle(int baseSide, int equalSide) : base(baseSide, equalSide, equalSide)
        {

        }

        public override string GetName()
        {
            return "IsoscelesTriangle";
        }

    }

    public class Square : Rectangle
    {

        public Square(int side) : base(side, side)
        {

        }

        public string GetName()
        {
            return "Square";
        }
    }


}