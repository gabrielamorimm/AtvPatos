using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AtvPOO1
{
    abstract class Forma
    {

        public abstract double CalcularArea();
        public abstract double CalcularPerimetro();


        abstract class Quadrado : Forma
        {
            public double Base { get; set; }
            public double Altura { get; set; }

            public Quadrado(double Base, double Altura)
            {
                this.Base = Base;
                this.Altura = Altura;
            }

            public override double CalcularArea()
            {
                return Base * Altura;
            }

            public override double CalcularPerimetro()
            {
                return Base * 4;
            }
        }

        abstract class Octagono : Forma
        {
            public double lado { get; set; }
            public double Apotema { get; set; }

            public Octagono(double lado, double Apotema)
            {
                this.lado = lado;
                this.Apotema = Apotema;
            }

            public override double CalcularArea()
            {
                return (CalcularPerimetro() * Apotema) / 2;
            }
            public override double CalcularPerimetro()
            {
                double perimetro;
                perimetro = lado * 8;
                return perimetro;
            }

        }

        abstract class Pentagono : Forma
        {
            public double lado { get; set; }
            public double Apotema { get; set; }

            public Pentagono(double lado, double apotema)
            {
                this.lado = lado;
                Apotema = apotema;
            }

            public override double CalcularArea()
            {
                return (CalcularPerimetro() * Apotema) / 2;
            }

            public override double CalcularPerimetro()
            {
                double perimetro;
                perimetro = lado * 5;
                return perimetro;
            }
        }

        abstract class Retangulo : Forma
        {
            public double Largura { get; set; }
            public double Altura { get; set; }

            public Retangulo(double Largura, double Altura)
            {
                this.Largura = Largura;
                this.Altura = Altura;
            }

            public override double CalcularArea()
            {
                return Largura * Altura;
            }

            public override double CalcularPerimetro()
            {
                return 2 * (Largura + Altura);
            }
        }

        abstract class Triangulo : Forma
        {
            public double Base { get; set; }
            public double Altura { get; set; }

            public Triangulo(double Base, double Altura)
            {
                this.Base = Base;
                this.Altura = Altura;
            }

            public override double CalcularArea()
            {
                return (Base * Altura) / 2;
            }

            public override double CalcularPerimetro()
            {
                return Base * 3;
            }

        }

        abstract class Circulo : Forma
        {
            public double raio { get; set; }
            public double diametro { get; set; }

            public Circulo(double raio, double diametro)
            {
                this.raio = raio;
                this.diametro = diametro;
            }

            public override double CalcularArea()
            {
                return 3.14 * Math.Pow(raio, 2);
            }

            public override double CalcularPerimetro()
            {
                return 3.14 * diametro;
            }


        }

        abstract class Hexagono : Forma
        {
            public double lado { get; set; }

            public Hexagono(double lado)
            {
                this.lado = lado;
            }

            public override double CalcularArea()
            {
                return (3 * Math.Sqrt(3) / 2) * lado * lado;
            }

            public override double CalcularPerimetro()
            {
                return lado * 6;
            }
        }
    }
}
