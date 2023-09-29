using System.Security.Cryptography.X509Certificates;

namespace Entidades
{
    public static class Class1
    {
        private static string nombre = "Juan";
        public static string WriteName()
        {
            return Console.ReadLine();
        }

        public static int WriteNumber() 
        {
            Console.WriteLine("Escribe un numero: ");

            if (int.TryParse(Console.ReadLine(), out int numero))
            {
                return numero;
            } else
            {
                Console.WriteLine("No funciona");
                return 0;
            }
        }
    }
}