using System;
using System.Collections.Generic;

namespace DesafioFrameworkDigital
{
    public interface IDesafio
    {
        /// <summary>
        /// Encontra os divisores
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        List<int> FindsDividers(int number);

        /// <summary>
        /// Encontra os números primos
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        List<int> FindsPrimeNumebers(List<int> numbers);

        /// <summary>
        /// Exibir listas
        /// </summary>
        /// <param name="list"></param>
        void PrintList(List<int> list);
    }
}