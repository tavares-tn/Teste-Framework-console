using System;
using System.Collections.Generic;

namespace DesafioFrameworkDigital
{
    public class Desafio : IDesafio
    {
        /// <summary>
        /// Encontra os divisores
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public List<int> FindsDividers(int number)
        {
            var resultFindsDivider = new List<int>();

            int i = 1;
            while (number >= i)
            {
                if (((number / i) * i) == number)
                    resultFindsDivider.Add(number / i);
                i++;
            }

            return resultFindsDivider;
        }

        /// <summary>
        /// Encontra os números primos
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public List<int> FindsPrimeNumebers(List<int> numbers)
        {
            var resultFindsPrimeNumebers = new List<int>();

            foreach (int x in numbers)
            {
                int cont = 0;
                for (int a = 1; a <= x; a++)
                {
                    if ((x % a) == 0)
                    {
                        cont++;
                    }
                }

                if (cont == 2)
                    resultFindsPrimeNumebers.Add(x);
            }

            return resultFindsPrimeNumebers;
        }

        /// <summary>
        /// Exibir listas
        /// </summary>
        /// <param name="list"></param>
        public void PrintList(List<int> list)
        {
            foreach (int l in list)
                Console.WriteLine(l);
        }
    }
}