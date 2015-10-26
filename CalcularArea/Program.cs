using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularArea
{
    class Program
    {

        static void Main(string[] args)
        {
            string TipoForma;

            Console.WriteLine("1 - Quadrado");
            Console.WriteLine("2 - Traiangulo");
            Console.WriteLine("3 - Retangulo");
            Console.WriteLine("4 - Circulo");
            Console.WriteLine("5 - Losangulo");
            Console.WriteLine("6 - Paralelograma");
            Console.WriteLine("7 - Trapezio");
            TipoForma = Console.ReadLine();


            switch (TipoForma)
            {

                case "1":
            Quadrado NovoQuadrado = new Quadrado();
            Console.WriteLine("Informe o valor do lado do quadrado em metros.");
            NovoQuadrado.Lado = float.Parse(Console.ReadLine());
            NovoQuadrado.CalcularArea();
            NovoQuadrado.CalcularPerimetro();
            Console.WriteLine("A área do quadrado é : " + NovoQuadrado.Area + " m2 ");
            Console.WriteLine("O perímetro do quadrado é : " + NovoQuadrado.Perimetro + " m ");
            Console.ReadKey();

                    break;



                case "2":
                    Triangulo NovoTriangulo = new Triangulo();

                    Console.WriteLine("Informe o valor do lado do triangulo em metros.");
                    NovoTriangulo.Lado = float.Parse(Console.ReadLine());
                    NovoTriangulo.CalcularArea();
                    NovoTriangulo.CalcularPerimetro();
                    Console.WriteLine("A área do triangulo é : " + NovoTriangulo.Area + " m2 ");
                    Console.WriteLine("O perímetro do triangulo é : " + NovoTriangulo.Perimetro + " m ");
                    Console.ReadKey();

                    break;



                case "3":
                    Retangulo NovoRetangulo = new Retangulo();

                    Console.WriteLine("Informe o valor do lado do retangulo em metros.");
                    NovoRetangulo.Lado = float.Parse(Console.ReadLine());
                    Console.WriteLine("Informe o valor da base do retangulo em metros.");
                    NovoRetangulo.Base = float.Parse(Console.ReadLine());
                    NovoRetangulo.CalcularArea();
                    NovoRetangulo.CalcularPerimetro();
                    Console.WriteLine("A área do retangulo é : " + NovoRetangulo.Area + " m2 ");
                    Console.WriteLine("O perímetro do retangulo é : " + NovoRetangulo.Perimetro + " m ");
                    Console.ReadKey();

                    break;


                case "4":
                    Circulo Novocirculo = new Circulo();

                    Console.WriteLine("Informe o valor do lado do circulo em metros.");
                    Novocirculo.Raio = float.Parse(Console.ReadLine());
                    Novocirculo.CalcularArea();
                    Novocirculo.CalcularPerimetro();
                    Console.WriteLine("A área do circulo é : " + Novocirculo.Area + " m2 ");
                    Console.WriteLine("O perímetro do circulo é : " + Novocirculo.Perimetro + " m ");
                    Console.ReadKey();

                    break;

                case "5":
                    Losango NovoLosangulo = new Losango();

                    Console.WriteLine("Informe o valor do lado do losangulo em metros.");
                    NovoLosangulo.Lado = float.Parse(Console.ReadLine());
                    NovoLosangulo.CalcularArea();
                    NovoLosangulo.CalcularPerimetro();
                    Console.WriteLine("A área do losangulo é : " + NovoLosangulo.Area + " m2 ");
                    Console.WriteLine("O perímetro do losangulo é : " + NovoLosangulo.Perimetro + " m ");
                    Console.ReadKey();

                    break;


                case "6":
                    Paralelograma NovoParalelograma = new Paralelograma();

                    Console.WriteLine("Informe o valor do lado do paralelograma em metros.");
                    NovoParalelograma.Lado = float.Parse(Console.ReadLine());
                    NovoParalelograma.CalcularArea();
                    NovoParalelograma.CalcularPerimetro();
                    Console.WriteLine("A área do paralelograma é : " + NovoParalelograma.Area + " m2 ");
                    Console.WriteLine("O perímetro do paralelograma é : " + NovoParalelograma.Perimetro + " m ");
                    Console.ReadKey();

                    break;

                case "7":
                    Trapezio NovoTrapezio = new Trapezio();

                    Console.WriteLine("Informe o valor da Base Menor do Trapezio em metros.");
                    NovoTrapezio.BaseMenor = float.Parse(Console.ReadLine());
                    Console.WriteLine("Informe o valor da Base Maior do Trapezio em metros.");
                    NovoTrapezio.BaseMaior = float.Parse(Console.ReadLine());
                    Console.WriteLine("Informe o valor da altura do Trapezio em metros.");
                    NovoTrapezio.Altura = float.Parse(Console.ReadLine());
                    NovoTrapezio.CalcularArea();
                    NovoTrapezio.CalcularPerimetro();
                    Console.WriteLine("A área do Trapezio é : " + NovoTrapezio.Area + " m2 ");
                    Console.WriteLine("O perímetro do Trapezio é : " + NovoTrapezio.Perimetro + " m ");
                    Console.ReadKey();

                    break;




            }

















        }


    }
}
