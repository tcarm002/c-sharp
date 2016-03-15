using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");
            Console.ReadLine();
            Food burger = new Food(2.50, "savory", 1.0, "burger");
            Console.WriteLine(burger.toString());

            Shape triangle = new Triangle("triangle",1.5, 6.0);

            Shape[] shapes = { new Triangle("triangle",1.5, 6.0), new Circle("circle",3.0) };

            foreach (Shape shape in shapes)
            {
                Console.WriteLine(String.Format("{0}'s area: {1:#.00}", shape.getName(), shape.area()));
            }
            
            Console.ReadLine();
        }
    }

    class Food
    {
        public double price { get; set; }
        public string taste { get; set; }
        public double weight { get; set; }

        public string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Food(double price, string taste, double weight, string name)
        {
            this.price = price;
            this.taste = taste;
            this.weight = weight;
            this.name = name;
        }

        static int numFood = 0;
        public static int getNumFood()
        {
            return numFood;
        }

        
        public string toString()
        {
            return String.Format("{0} costs ${1} and" +
               " tastes {2} with {3} lbs of weight", name, price, taste, weight);
        }
    }

    abstract class Shape
    {

        public abstract double area();
        public abstract string getName();
        
        public void concreteMethod()
        {
            Console.WriteLine("hello");
        }
    }

    public interface ShapeItem
    {
        double area();
    }

    class Triangle : Shape
    {
        private double triBase;
        private double height;
        private string name;

        public Triangle(string name, double triBase, double height)
        {
            this.name = name;
            this.triBase = triBase;
            this.height = height;
        }

        public override double area()
        {
            return 0.5 * triBase * height;
        }

        public override string getName()
        {
            return name;
        }
    }


    class Circle : Shape
    {
        private double radius;
        private string name;

        public Circle(string name, double radius)
        {
            this.name = name;
            this.radius = radius;
        }

        public override double area()
        {
            return Math.PI * Math.Pow(radius,2);
        }

        public override string getName()
        {
            return name;
        }
    }

}
