using System;

namespace DesafioFrameworkDigital
{
    class Program
    {
        static void Main(string[] args)
        {
            Desafio desafio = new Desafio();

            bool repeti = true;
            while (repeti)
            {
                // Entrafa de valor
                Console.WriteLine("Informe um número:");
                int number = int.Parse(Console.ReadLine());

                // Array dos valores divisores
                var dividersNumber = desafio.FindsDividers(number);

                // Exibe divisores
                Console.WriteLine("Números divisores");
                desafio.PrintList(dividersNumber);

                // Array dos valores primos
                var primeNumbers = desafio.FindsPrimeNumebers(dividersNumber);

                // Exibe primos
                Console.WriteLine("Números primos:");
                desafio.PrintList(primeNumbers);

                int response = 2;
                while (response == 2)
                {
                    Console.WriteLine("Deseja continuar: (1-SIM ou 2-NAO)");
                    response = int.Parse(Console.ReadLine());

                    if (response == 2)
                    {
                        response = 1;
                        repeti = false;
                        Console.WriteLine("BY");
                    }

                    if (response != 1 && response != 2)
                    {
                        response = 2;
                        Console.WriteLine("OPCAO INVALIDA");
                    }
                }

            }
        }
    }
}
