using System;

namespace PruebaAuto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aplicacion de Autito");
            Console.WriteLine("Usuario: admin");
            Console.Write("Ingrese la contraseña: ");

            {
                string contraseña = Console.ReadLine();

                while (contraseña != "abc123")
                {
                    Console.Write("Contraseña Incorrecta, Intente otra vez: ");
                    contraseña = Console.ReadLine();
                }
                Console.WriteLine("Contraseña Correcta");
            }
        }
    }
}