using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode3
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = File.ReadAllLines("Data.txt");
            var lineLength = data.First().Length;

            //var countOfOnes = GetCountOfOnes(data, lineLength);
            //var countOfZeros = GetCountOfZeros(data, lineLength);

            //var gammaRate = GetGammaRate(countOfOnes, countOfZeros, lineLength);
            //var epsilonRate = GetEpsilonRate(countOfOnes, countOfZeros, lineLength);

            var oxyRating = GetOxyRate(data, lineLength);
            var co2Rating = GetCo2Rate(data, lineLength);


            //Console.WriteLine($"Count of Ones: {string.Join(",", countOfOnes)}");
            //Console.WriteLine($"Count of Zeros: {string.Join(",", countOfZeros)}\n");
            //Console.WriteLine($"Gamma Rate: {string.Join(",", gammaRate)}");
            //Console.WriteLine($"Epsilon Rate: {string.Join(",", epsilonRate)}\n");
            Console.WriteLine($"Oxygen rate: {string.Join(",", oxyRating)}");
            Console.WriteLine($"CO2 rate: {string.Join(",", co2Rating)}");
        }

        public static int[] GetCountOfOnes(string[] data, int length)
        {
            var Ones = new int[length];

            foreach (var character in data)
            {
                for (int i = 0; i < character.Length; i++)
                {
                    if (character[i] == '1')
                        Ones[i]++;
                }
            }
            Console.WriteLine($"Count of Ones: {string.Join(",", Ones)}");


            return Ones;
        }

        public static int[] GetCountOfZeros(string[] data, int length)
        {
            var Zeros = new int[length];

            foreach (var character in data)
            {
                for (int i = 0; i < character.Length; i++)
                {
                    if (character[i] == '0')
                        Zeros[i]++;
                }
            }
            Console.WriteLine($"Count of Zeros: {string.Join(",", Zeros)}");

            return Zeros;
        }

        public static int[] GetGammaRate(int[] countOfOnes, int[] countOfZeros, int length)
        {
            var gammaRate = new int[length];
            for (int i = 0; i < length; i++)
            {
                if (countOfOnes[i] > countOfZeros[i])
                {
                    gammaRate[i] = 1;
                }
                else
                {
                    gammaRate[i] = 0;
                }
            }
            //Console.WriteLine($"Gamma Rate: {string.Join(",", gammaRate)}");
            return gammaRate;
        }

        public static int[] GetEpsilonRate(int[] countOfOnes, int[] countOfZeros, int length)
        {
            var epsilonRate = new int[length];
            for (int i = 0; i < length; i++)
            {
                if (countOfOnes[i] > countOfZeros[i])
                {
                    epsilonRate[i] = 0;
                }
                else
                {
                    epsilonRate[i] = 1;
                }
            }
            //Console.WriteLine($"Epsilon Rate: {string.Join(",", epsilonRate)}");
            return epsilonRate;
        }

        public static int[] GetOxyRate(string[] data, int length)
        {
            var subset = new List<string>(data);

            for (int i = 0; i < length; i++)
            {
                if (subset.Count == 1) break;

                var zeros = subset.Count(x => x[i] == '0');
                var ones = subset.Count(x => x[i] == '1');
                var looikngFor = zeros == ones ? '1' : zeros > ones ? '0' : '1';

                subset = subset.Where(x => x[i] == looikngFor).ToList();
            }

            var result = subset.First().Select(x => int.Parse(x.ToString())).ToArray();

            return result;
        }

        public static int[] GetCo2Rate(IEnumerable<string> data, int length)
        {
            var subset = new List<string>(data);

            for (int i = 0; i < length; i++)
            {
                if (subset.Count == 1) break;

                var zeros = subset.Count(x => x[i] == '0');
                var ones = subset.Count(x => x[i] == '1');
                var looikngFor = zeros == ones ? '0' : zeros > ones ? '1' : '0';

                subset = subset.Where(x => x[i] == looikngFor).ToList();
            }

            var result = subset.First().Select(x => int.Parse(x.ToString())).ToArray();

            return result;
        }
    }
}
