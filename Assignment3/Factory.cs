using System;
namespace Homework3
{
    public interface Shape
    {
        double Shape_area { get; }
        string Meg { get; }
        bool IsValid();
    }

    public class Square : Shape
    {
        public Square(double a)
        {
            A = a;
        }
        public double A { get; set; }
        public string Meg => $"正方形的边长：{A}.";

        public double Shape_area
        {
            get
            {
                if (!IsValid()) throw new InvalidOperationException("错误的形状！");
                return A * A;
            }
        }

        public bool IsValid()
        {
            return A > 0;
        }
    }
    public class Triangle : Shape
    {
        public Triangle(double a, double b, double c)
        {
            double[] newEdges = new double[3] { a, b, c };
            this.Edges = newEdges;
        }
        public double[] Edges { get; set; } = new double[3];

        public string Meg
        {
            get => $"三角形的各边长：a={Edges[0]},b={Edges[1]},c={Edges[2]}.";
        }
        public double Shape_area
        {
            get
            {
                if (!IsValid()) throw new InvalidOperationException("错误的形状");
                //海伦公式计算
                double p = (Edges[0] + Edges[1] + Edges[2]) / 2;
                return Math.Sqrt(p * (p - Edges[0]) * (p - Edges[1]) * (p - Edges[2]));
            }
        }
        public bool IsValid()
        {
            double a = Edges[0], b = Edges[1], c = Edges[2];
            return (a > 0 && b > 0 && c > 0 && (a + b > c) && (b + c > a) && (a + c > b));
        }
    }
    public class Rectangle : Shape
    {

        public Rectangle(double length, double width)
        {
            this.Length = length;
            this.Width = width;
        }

        public double Length { get; set; }

        public double Width { get; set; }

        public string Meg => $"矩形的长为：{Length},宽为：{Width}.";

        public double Shape_area
        {
            get
            {
                if (!IsValid()) throw new InvalidOperationException("错误的形状！");
                return Length * Width;
            }
        }

        public bool IsValid()
        {
            return Length > 0 && Width > 0;
        }
    }
    public class Circle : Shape
    {

        public Circle(double r)
        {
            R = r;
        }

        public double R { get; set; }

        public string Meg => $"园的半径为：{R}";

        public double Shape_area
        {
            get
            {
                if (!IsValid()) throw new InvalidOperationException("错误的形状！");
                return Math.PI * R * R;
            }
        }

        public bool IsValid()
        {
            return R > 0;
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<Shape> shapes = new List<Shape>();
                for (int i = 0; i < 10; i++)
                {
                    shapes.Add(ShapeFactory.CreateRandomShape());
                }
                shapes.ForEach(s => Console.WriteLine($"{s.Meg}, area={s.Shape_area}"));
                double total = shapes.Sum(s => s.Shape_area);
                Console.WriteLine($"total={total}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
    public class ShapeFactory
    {
        public enum ShapeType { Squre, Circle, Rectangle, Triangle };
        static readonly int[] edgeNumbers = { 6, 1, 2, 3 };
        static readonly Random random = new Random();
        public static Shape CreateShape(ShapeType type, double[] edges)
        {
            if (edges == null)
                throw new InvalidOperationException("edges cannot be null");
            int index = Convert.ToInt32(type);
            if (edges.Length != edgeNumbers[index])
            {
                throw new InvalidOperationException("invalid edge number");
            }
            Shape result = null;
            switch (type)
            {
                case ShapeType.Squre:
                    result = new Square(edges[0]);
                    break;
                case ShapeType.Circle:
                    result = new Circle(edges[0]);
                    break;
                case ShapeType.Rectangle:
                    result = new Rectangle(edges[0], edges[1]);
                    break;
                case ShapeType.Triangle:
                    result = new Triangle(edges[0], edges[1], edges[2]);
                    break;
                default:
                    throw new InvalidOperationException("Invalid shape type:" + type);
            }
            if (!result.IsValid())
            {
                throw new InvalidOperationException("Invalid shape arguments");
            }

            return result;
        }
        public static Shape CreateRandomShape()
        {
            int index = random.Next(0, 4);
            ShapeType type = (ShapeType)Enum.Parse(
                        typeof(ShapeType), index.ToString());
            double[] edges = new double[edgeNumbers[index]];

            Shape result = null;
            do
            {

                for (int i = 0; i < edgeNumbers[index]; i++)
                {
                    edges[i] = random.Next(200);
                }
                result = CreateShape(type, edges);
            } while (result == null);

            return result;
        }
    }
}