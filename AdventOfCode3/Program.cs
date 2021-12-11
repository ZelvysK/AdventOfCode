using System;
using System.IO;
using System.Linq;

namespace AdventOfCode3
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = File.ReadAllLines("Prefab.txt");
            var lineLength = data.First().Length;

            var countOfOnes = GetCountOfOnes(data, lineLength);
            var countOfZeros = GetCountOfZeros(data, lineLength);

            var gammaRate = GetGammaRate(countOfOnes, countOfZeros, lineLength);
            var epsilonRate = GetEpsilonRate(countOfOnes, countOfZeros, lineLength);

            var oxyRating = GetOxyRate(data, lineLength);
            var co2Rating = GetCo2Rate(data, lineLength);


            Console.WriteLine($"Count of Ones: {string.Join(",", countOfOnes)}");
            Console.WriteLine($"Count of Zeros: {string.Join(",", countOfZeros)}\n");
            Console.WriteLine($"Gamma Rate: {string.Join(",", gammaRate)}");
            Console.WriteLine($"Epsilon Rate: {string.Join(",", epsilonRate)}\n");
            //Console.WriteLine($"Oxygen rate: {string.Join(",", oxyRating)}");
            //Console.WriteLine($"CO2 rate: {string.Join(",", co2Rating)}");
        }

        public static int[] GetCountOfOnes(string[] data, int length)
        {
            var Ones = new int[length];

            foreach (var character in data)
            {
                //Console.WriteLine($"Bits: {character}; Length: {character.Length};");

                for (int i = 0; i < character.Length; i++)
                {
                    if (character[i] == '1')
                        Ones[i]++;
                }
            }

            return Ones;
        }

        public static int[] GetCountOfZeros(string[] data, int length)
        {
            var countOfZeros = new int[length];

            foreach (var character in data)
            {
                //Console.WriteLine($"Bits: {character}; Length: {character.Length};");

                for (int i = 0; i < character.Length; i++)
                {
                    //Console.WriteLine($"Char: {character[i]};");
                    if (character[i] == '0')
                        countOfZeros[i]++;
                }
                //Console.WriteLine($"Count of Zeros: {countOfZeros[0]}");
            }

            return countOfZeros;
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

        public static char[] GetOxyRate(string[] data, int length)
        {
            var oxyRate = new char[length];

            for (int i = 0; i < data.Length; i++)
            {
                var line = data[i];

                Console.WriteLine(data[i]);

                for (int j = 0; j < line.Length; j++)
                {

                }
            }

            return oxyRate;
        }

        public static char[] GetCo2Rate(string[] data, int length)
        {
            var co2Rate = new char[length];



            return co2Rate;
        }

    }
}
