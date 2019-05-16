using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio1_Connect4
{
    class Program
    {
        static Thread hiloCaptura;
        static Juego juegoActual = new Juego();

        static void InicializarJuego()
        {
            juegoActual.Estado = Juego.eEstadoJuego.MostrandoMenu;
            Console.CursorVisible = false;
            hiloCaptura = new Thread(new ThreadStart(CapturarTeclado));
            hiloCaptura.Start();
        }

        static void Main(string[] args)
        {
            InicializarJuego();

            while(juegoActual.Estado != Juego.eEstadoJuego.JuegoFinalizado)
            {
                // Primero: verificamos la entrada del usuario.

                // Segundo: actualizamos valores en funcion del estado actual.

                // Tercero: renderizamos el juego.
                Renderizar();
                Thread.Sleep(50);
                
            }

            Console.WriteLine("Gracias por jugar!");

            Console.ReadKey();
        }

        static void Renderizar() {
            switch (juegoActual.Estado)
            {
                case Juego.eEstadoJuego.MostrandoMenu:
                    Console.SetCursorPosition(0, 0);
                    Console.WriteLine("Seleccione una opcion del menu: ");
                    Console.WriteLine("\n\t1: Jugar.");
                    Console.WriteLine("\n\t2: Salir.");
                    break;
                    /*
                case Juego.eEstadoJuego.EjecutandoJuego:
                    break;
                case Juego.eEstadoJuego.JuegoFinalizado:
                    break;
                    */
            }
        }

        static void CapturarTeclado()
        {
            string capturaActual;
            while (true)
            {
                capturaActual = Console.ReadLine();
                switch (juegoActual.Estado)
                {
                    case Juego.eEstadoJuego.MostrandoMenu:
                        if (capturaActual == "2")
                            juegoActual.Estado = Juego.eEstadoJuego.JuegoFinalizado;
                        break;
                }
            }
        }
    }
}
