using HerenciaDeObjetos.Formas;
using HerenciaDeObjetos.Formas.Circulo;
using HerenciaDeObjetos.Formas.Poligonos;
using System;
using System.Collections.Generic;

namespace HerenciaDeObjetos
{
    internal class Diagrama
    {
        public List<Forma> Formas = new List<Forma>();
        public List<string> Opciones = new List<string>() {"Circulo", "Rectangulo", "Cuadrado", "Rombo", "Triangulo"};
        private int Opcion = 0;      

        public Diagrama()
        {

        }

        public void SeleccionarOpcion()
        {
            Console.Clear();
            Console.WriteLine("Diagrama APP");
            Console.WriteLine(" ¡Genera tu propio diagrama!");
            Console.WriteLine("  Elije la forma que deseas utilizar: ");
            Console.WriteLine("     1 - Circulo");
            Console.WriteLine("     2 - Rectangulo");
            Console.WriteLine("     3 - Cuadrado");
            Console.WriteLine("     4 - Rombo");
            Console.WriteLine("     5 - Triangulo");
            Console.WriteLine("  Introduzca un numero para seleccionar opción");

            while (Opcion == 0 || Opcion > 5)
            {
                while (!int.TryParse(Console.ReadLine(), out Opcion))
                    Console.WriteLine("  Debes introducir un número.");

                if (Opcion == 0 || Opcion > 5)
                {
                    Console.WriteLine("  Numero de opción inválido.");
                }
            }
        }
      
        public void InsertarFormarSeleccionada() 
        {
            Forma oForma = new Forma("");
            int nP1 = 0;
            int nP2 = 0;
            int nP3 = 0;
            int nP4 = 0;

            Console.Clear();
            Console.WriteLine("Diagrama APP");
            Console.WriteLine(" ¡Genera tu propio diagrama!");
            Console.WriteLine("  NºOpción: " + Opcion + " - " + Opciones[Opcion - 1]);

            switch (Opcion) 
            {
                case 1:
                    Console.WriteLine("  Introduzca el radio deseado para su circulo:");                    
                    while (!int.TryParse(Console.ReadLine(), out nP1))
                        Console.WriteLine("  Debes introducir un número.");

                    Circulo oCirculo = new Circulo(nP1);
                    oForma = oCirculo;
                    break;
                case 2:
                    Console.WriteLine("  Introduzca la base deseada para su rectangulo:");                    
                    while (!int.TryParse(Console.ReadLine(), out nP1))
                        Console.WriteLine("  Debes introducir un número.");

                    Console.WriteLine("  Introduzca la altura deseada para su rectangulo:");
                    while (!int.TryParse(Console.ReadLine(), out nP2))
                        Console.WriteLine("  Debes introducir un número.");

                    Rectangulo oRectangulo = new Rectangulo(nP1, nP2);
                    oForma = oRectangulo;
                    break;
                case 3:                    
                    Console.WriteLine("  Introduzca la base deseada para su cuadrado:");
                    while (!int.TryParse(Console.ReadLine(), out nP1))
                        Console.WriteLine("  Debes introducir un número.");

                    Rectangulo oCuadrado = new Rectangulo(nP1);
                    oForma = oCuadrado;
                    break;
                case 4:
                    Console.WriteLine("  Introduzca la diagonal mayor deseada para su rombo:");
                    while (!int.TryParse(Console.ReadLine(), out nP1))
                        Console.WriteLine("  Debes introducir un número.");

                    Console.WriteLine("  Introduzca la diagonal menor deseada para su rombo:");
                    while (!int.TryParse(Console.ReadLine(), out nP2))
                        Console.WriteLine("  Debes introducir un número.");

                    Console.WriteLine("  Introduzca la longitud del pimer lado para su rombo:");
                    while (!int.TryParse(Console.ReadLine(), out nP3))
                        Console.WriteLine("  Debes introducir un número.");

                    Console.WriteLine("  Introduzca la longitud del segundo lado para su rombo:");
                    while (!int.TryParse(Console.ReadLine(), out nP4))
                        Console.WriteLine("  Debes introducir un número.");

                    Rombo oRombo = new Rombo(nP1,nP2,nP3,nP4);
                    oForma = oRombo;
                    break;
                case 5:
                    Console.WriteLine("  Introduzca la altura deseada para su triangulo:");
                    while (!int.TryParse(Console.ReadLine(), out nP1))
                        Console.WriteLine("  Debes introducir un número.");

                    Console.WriteLine("  Introduzca la base deseada para su triangulo:");
                    while (!int.TryParse(Console.ReadLine(), out nP2))
                        Console.WriteLine("  Debes introducir un número.");

                    Console.WriteLine("  Introduzca la longitud del pimer lado para su triangulo:");
                    while (!int.TryParse(Console.ReadLine(), out nP3))
                        Console.WriteLine("  Debes introducir un número.");

                    Console.WriteLine("  Introduzca la longitud del segundo lado para su Triangulo:");
                    while (!int.TryParse(Console.ReadLine(), out nP4))
                        Console.WriteLine("  Debes introducir un número.");

                    Triangulo oTriangulo = new Triangulo(nP2, nP1, nP3, nP4);
                    oForma = oTriangulo;
                    break;                
            }
            Opcion = 0;
            Formas.Add(oForma);
        }

        public void MostrarDiagrama(bool bDefinitivo)
        {
            Console.Clear();
            Console.WriteLine("Diagrama APP");

            if(bDefinitivo)
                Console.WriteLine(" ¡Diagrama generado correctamente! ");
            else
                Console.WriteLine(" Vista previa del diagrama: ");

            for (int i = 0; i < Formas.Count; i++)
            {
                Console.WriteLine("  " + (i + 1) +". " + Formas[i].Nombre + " | Area: " 
                                + Formas[i].Area() + " | Perimetro: " + Formas[i].Perimetro());               
            }
        }

        public void MostrarAreaPerimetroTotal()
        {
            double nAreaTotal = 0;
            double nPerimetroTotal = 0;

            for (int i = 0; i < Formas.Count; i++)
            {
                nPerimetroTotal += Formas[i].Perimetro();
                nAreaTotal += Formas[i].Area();                
            }            

            MostrarDiagrama(true);

            Console.WriteLine(" ");
            Console.WriteLine("  " + "El area total del diagrama es: " + nAreaTotal);
            Console.WriteLine("  " + "El permitro total del diagrama es: " + nPerimetroTotal);
        }
    }
}
