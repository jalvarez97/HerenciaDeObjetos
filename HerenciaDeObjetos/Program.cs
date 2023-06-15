using System;

namespace HerenciaDeObjetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool bSeguir = true;
            Diagrama oDiagrama = new Diagrama();

            while (bSeguir)
            {
                oDiagrama.SeleccionarOpcion();
                oDiagrama.InsertarFormarSeleccionada();                   
                oDiagrama.MostrarDiagrama(false);

                Console.WriteLine("  ");
                Console.WriteLine("  Pulse cualquier tecla para continuar. . .");
                Console.WriteLine("  Pulse ESC para mostrar el Area y el Perimetro total de las figuras diagrama. . .");

                if (Console.ReadKey().Key == ConsoleKey.Escape)
                {
                    oDiagrama.MostrarAreaPerimetroTotal();

                    Console.WriteLine(" ");
                    Console.WriteLine("Pulse cualquier tecla para volver al menu. . .");
                    Console.WriteLine("Pulse ESC para salir. . .");

                    if (Console.ReadKey().Key == ConsoleKey.Escape)
                    {
                        bSeguir = false;
                        Console.Clear();
                    }
                }               

            }
        }        
    }
}
