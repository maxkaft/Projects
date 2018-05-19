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
            List<string> games = Console.ReadLine().Split(' ').ToList();

            while (true)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();

                if (input[0] == "Play!")
                {
                    break;
                }

                string command = input[0];

                if (command == "Install")
                {
                    string game = input[1];

                    if (!games.Contains(game))
                    {
                        games.Add(game);
                    }
                }
                else if (command == "Uninstall")
                {
                    string game = input[1];

                    if (games.Contains(game))
                    {
                        games.Remove(game);
                    }
                }
                else if (command == "Update")
                {
                    string game = input[1];

                    if (games.Contains(game))
                    {
                        games.Remove(game);
                        games.Add(game);
                    }
                }
                else if (command == "Expansion")
                {
                    string[] tokens = input[1].Split('-').ToArray();
                    string game = tokens[0];
                    string expansion = tokens[1];

                    if (games.Contains(game))
                    {
                        for (int i = 0; i < games.Count; i++)
                        {
                            if (games[i] == game)
                            {
                                games[i] = games[i].Replace(games[i], $"{game} {game}:{expansion}");
                            }
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(' ', games));
        }
    }
}
