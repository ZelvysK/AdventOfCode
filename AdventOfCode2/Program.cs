using System;
using System.IO;

namespace AdventOfCode2
{
    class Program
    {
        static void Main(string[] args)
        {
            var commands = File.ReadAllLines("Data.txt");

            var position = 0;
            var depth = 0;

            foreach (var command in commands)
            {
                var data = command.Split(" ");


                if (data[0].Contains("forward"))
                {
                    position += int.Parse(data[1]);
                }
                else if (data[0].Contains("down"))
                {
                    depth += int.Parse(data[1]);
                }
                else if (data[0].Contains("up"))
                {
                    depth -= int.Parse(data[1]);
                }
            }

            Console.WriteLine($"Position: {position}; Depth: {depth}; Final result: {position * depth}");

            var commandsN = File.ReadAllLines("DataN.txt");

            var positionN = 0;
            var depthN = 0;
            var aimN = 0;

            foreach (var commandN in commandsN)
            {
                var data = commandN.Split(" ");

                if (data[0].Contains("forward"))
                {
                    positionN += int.Parse(data[1]);
                    depthN += aimN * int.Parse(data[1]);
                }
                else if (data[0].Contains("down"))
                {
                    //depthN += int.Parse(data[1]);
                    aimN += int.Parse(data[1]);
                }
                else if (data[0].Contains("up"))
                {
                    //depthN -= int.Parse(data[1]);
                    aimN -= int.Parse(data[1]);
                }
            }

            Console.WriteLine($"Position: {positionN}; Depth: {depthN}; Final result: {positionN * depthN}");
        }
    }
}
