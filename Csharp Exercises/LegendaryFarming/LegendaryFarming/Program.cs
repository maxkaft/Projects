using System;
using System.Collections.Generic;
using System.Linq;

namespace _0._Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string material = "";
            int quantity = 0;
            bool end = false;

            var legendary = new Dictionary<string, int>();
            legendary.Add("motes", 0);
            legendary.Add("fragments", 0);
            legendary.Add("shards", 0);

            var junk = new Dictionary<string, int>();

            while (end == false)
            {
                string[] input = Console.ReadLine().Split().ToArray();

                for (int i = 0; i < input.Length; i += 2)
                {
                    material = input[i + 1].ToLower();
                    quantity = int.Parse(input[i]);

                    if (material == "motes" || material == "shards" || material == "fragments")
                    {
                        legendary[material] += quantity;

                        if (legendary[material] >= 250)
                        {
                            legendary[material] -= 250;
                            end = true;
                            break;
                        }
                    }
                    else
                    {
                        if (!junk.ContainsKey(material))
                        {
                            junk.Add(material, quantity);
                        }
                        else
                        {
                            junk[material] += quantity;
                        }
                    }

                }

            }

            string result = "";

            if (material == "motes")
            {
                result = "Dragonwrath obtained!";
            }
            else if (material == "fragments")
            {
                result = "Valanyr obtained!";
            }
            else
            {
                result = "Shadowmourne obtained!";
            }

            Console.WriteLine(result);

            foreach (var pair in legendary.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }

            foreach (var junkItem in junk.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{junkItem.Key}: {junkItem.Value}");
            }


        }
    }
}




