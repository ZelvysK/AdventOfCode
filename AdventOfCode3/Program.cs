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

            var countOfOnes = new int[5];
            var countOfZeros = new int[5];
            //var gammaRate = new int[5];
            //var epsilonRate = new int[5];

            foreach (var character in data)
            {
                Console.WriteLine($"Bits: {character}; Length: {character.Length};");

                for (int i = 0; i < character.Length; i++)
                {
                    //Console.WriteLine($"Char: {character[i]};");
                    if (character[i] == '1')
                        countOfOnes[i]++;

                    if (character[i] == '0')
                        countOfZeros[i]++;
                }

                //Console.WriteLine($"Count of Ones: {countOfOnes[0]}");
                //Console.WriteLine($"Count of Zeros: {countOfZeros[0]}");


                //foreach (var c in character)
                //{
                //    Console.WriteLine($"Char: {c}");
                //    if (c == '1')
                //        countOfOnes[i]++;

                //    if (c == '0')
                //        countOfZeros[i]++;
                //}

                //for (int i = 0; i < character.Length; i++)
                //{
                //    Console.WriteLine(character[i]);
                //    //if (character[i] == '1')
                //    //    countOfOnes[character.Length - (character.Length - i)]++;

                //    //countOfZeros[character.Length - (character.Length - i)]++;
                //}
            }

            Console.WriteLine($"Count of Ones: {string.Join(",", countOfOnes)}");
            Console.WriteLine($"Count of Zeros: {string.Join(",", countOfZeros)}");

            //foreach (var character in data)
            //{
            //    for (int i = 0; i < character.Length; i++)
            //    {
            //        character
            //            .Where(s => countOfOnes[i] > countOfZeros[i]);
            //    }
            //}

            //for (int i = 0; i < 12; i++)
            //{
            //    if (countOfOnes[i] > countOfZeros[i])
            //    {
            //        gammaRate[i] = 1;
            //        epsilonRate[i] = 0;
            //    }
            //    else
            //    {
            //        gammaRate[i] = 0;
            //        epsilonRate[i] = 1;
            //    }
            //}

            //Console.WriteLine($"Gamma Rate: {string.Join(",", gammaRate)}");
            //Console.WriteLine($"Epsilon Rate: {string.Join(",", epsilonRate)}");
        }
    }
}
