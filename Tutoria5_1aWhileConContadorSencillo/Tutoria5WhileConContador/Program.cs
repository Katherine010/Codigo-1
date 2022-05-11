using System;

namespace Tutoria5WhileConContador
{
    class Program
    {
        static void Main(string[] args)
        {
            Double NumeroLeido, Suma, Promedio;
            int Contador;
            Suma = 0;
            Contador=1;
            while (Contador<=5)
            {
                Console.WriteLine("Ingrese el numero: " + Contador);
                NumeroLeido = double.Parse(Console.ReadLine());
                Suma = Suma + NumeroLeido;
                Contador = Contador + 1;
            }
            Promedio = Suma / (Contador-1);
            Console.WriteLine("El Promedio es: " + Promedio);
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }
}
