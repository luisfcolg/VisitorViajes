using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorViajes.Visitor;

namespace VisitorViajes
{
    class Program
    {
        static void Main(string[] args)
        {
            var key = new ConsoleKeyInfo();
            Usuario usuario = new UsuarioCasual();
            Visitor.Visitor visitor = new CostoVisitor();
            int tipoUsuario = 0;

            key = ShowMenu();
            switch(key.Key)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    usuario = new UsuarioCasual();
                    tipoUsuario = 1;
                    break;

                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    usuario = new UsuarioPremium();
                    tipoUsuario = 2;
                    break;

                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    usuario = new UsuarioAgenciaViajes();
                    tipoUsuario = 3;
                    break;

                default:
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Seleccione un numero valido. Pulse cualquier tecla para salir...");
                    Console.ReadKey();
                    return;
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Introduzca el número de kilómetros a recorrer:");
            string km = Console.ReadLine();

            if(km == "" || Convert.ToDouble(km) < 0)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Introduzca un valor válido. Pulse cualquier tecla para salir...");
                Console.ReadKey();
                return;
            }

            if (tipoUsuario == 1) ((UsuarioCasual)usuario).Kilometros = Convert.ToDouble(km);
            else if (tipoUsuario == 2) ((UsuarioPremium)usuario).Kilometros = Convert.ToDouble(km);
            else if (tipoUsuario == 3) ((UsuarioAgenciaViajes)usuario).Kilometros = Convert.ToDouble(km);
            Console.WriteLine();
            Console.WriteLine();

            usuario.Aceptar(visitor);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Pulse cualquier tecla para salir...");
            Console.ReadKey();
        }

        private static ConsoleKeyInfo ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("Seleccione el tipo de usuario.");
            Console.WriteLine("1. Usuario casual");
            Console.WriteLine("2. Usuario premium");
            Console.WriteLine("3. Usuario agencia de viajes");

            return Console.ReadKey();
        }
    }
}
