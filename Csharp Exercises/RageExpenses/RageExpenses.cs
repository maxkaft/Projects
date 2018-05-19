using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;

namespace _03._Lecture
{
    class Program
    {
        static void Main(string[] args)
        {

            string command = Console.ReadLine();
            var trimmed = new List<string>();
            StringBuilder lines = new StringBuilder();

            while (command != "Visual Studio crash")
            {
                lines.Append(command + ' ');
                command = Console.ReadLine();
            }
            string[] input = lines.ToString().Split(' ').ToArray();

            for (int i = 0; i < input.Length - 3; i++)
            {
                if (input[i] == "32656" && input[i + 1] == "19759" && input[i + 2] == "32763")
                {
                    int length = int.Parse(input[i + 4]);
                    trimmed = input.Skip(i + 6).Take(length).ToList();
                    StringBuilder result = new StringBuilder();

                    foreach (string code in trimmed)
                    {
                        int ascii = int.Parse(code);
                        result.Append((char)(ascii));
                    }
                    Console.WriteLine(result);
                }
            }

        }

    }
}
