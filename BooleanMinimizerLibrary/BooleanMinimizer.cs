using System;
using System.Collections.Generic;

namespace BooleanMinimizerLibrary
{
    public class BooleanMinimizer
    {
        public static string MinimizeMKNF(string vector)
        {
            // Пример простой реализации МКНФ (можно использовать карту Карно или другой алгоритм)
            var minterms = GetMinterms(vector);
            return $" {string.Join(" ∨ ", minterms)}";
        }

        public static string MinimizeMDNF(string vector)
        {
            // Пример простой реализации МДНФ
            var maxterms = GetMaxterms(vector);
            return $" {string.Join(" ∧ ", maxterms)}";
        }

        private static List<string> GetMinterms(string vector)
        {
            var minterms = new List<string>();
            for (int i = 0; i < vector.Length; i++)
            {
                if (vector[i] == '1')
                {
                    minterms.Add($"m{i}");
                }
            }
            return minterms;
        }

        private static List<string> GetMaxterms(string vector)
        {
            var maxterms = new List<string>();
            for (int i = 0; i < vector.Length; i++)
            {
                if (vector[i] == '0')
                {
                    maxterms.Add($"M{i}");
                }
            }
            return maxterms;
        }
    }
}