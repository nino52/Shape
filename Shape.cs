using System;

namespace ShapeApp
{
    // Clase abstracta Shape
    abstract class Shape
    {
        protected double width;
        protected double height;

        public Shape(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        // Método abstracto para calcular el área
        public abstract double CalculateSurface();
    }

    // Clase Rectangle que hereda de Shape
    class Rectangle : Shape
    {
        public Rectangle(double width, double height) : base(width, height)
        {
        }

        // Implementación del cálculo de área para rectángulo
        public override double CalculateSurface()
        {
            return width * height;
        }
    }

    // Clase Triangle que hereda de Shape
    class Triangle : Shape
    {
        public Triangle(double width, double height) : base(width, height)
        {
        }

        // Implementación del cálculo de área para triángulo
        public override double CalculateSurface()
        {
            return (width * height) / 2;
        }
    }

    // Clase Circle que hereda de Shape
    class Circle : Shape
    {
        public Circle(double radius) : base(radius, radius) // Usamos el radio para ambos campos
        {
        }

        // Implementación del cálculo de área para círculo
        public override double CalculateSurface()
        {
            return Math.PI * width * width; // Área del círculo = π * r^2
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Crear una lista de diferentes Shape
            Shape[] shapes = {
                new Rectangle(5, 10),
                new Triangle(6, 8),
                new Circle(7)
            };

            // Calcular el área de cada forma y mostrarla
            for (int i = 0; i < shapes.Length; i++)
            {
                Console.WriteLine($"Área de la forma {i + 1}: {shapes[i].CalculateSurface():F2}");
            }

            Console.ReadKey(); // Espera una tecla para cerrar el programa
        }
    }

    public class Class1
    {
    }
}
