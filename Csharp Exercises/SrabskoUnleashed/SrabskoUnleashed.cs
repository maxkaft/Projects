using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _00._Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('@').ToArray();

            int people = 0;
            int price = 0;

            var concerts = new Dictionary<string, Dictionary<string, long>>();

            while (input[0] != "End")
            {
                string strInput = string.Join("@", input);
                var pattern = @"[A-Za-z]+ @[A-Za-z ]+ [\d]+ [\d]+";

                if (!Regex.IsMatch(strInput, pattern))
                {
                    input = Console.ReadLine().Split('@').ToArray();
                    continue;
                }

                string singer = input[0];
                string[] reversed = input.Skip(1).ToArray();
                reversed = string.Join(" ", reversed).Split().Reverse().ToArray();

                try
                {
                    people = int.Parse(reversed[0]);
                    price = int.Parse(reversed[1]);
                }
                catch (Exception)
                {
                    input = Console.ReadLine().Split('@').ToArray();
                    continue;
                }

                long profit = people * price;

                string city = string.Join(" ", reversed.Skip(2).Reverse());

                if (!concerts.ContainsKey(city))
                {
                    var helper = new Dictionary<string, long>();
                    helper.Add(singer, profit);
                    concerts.Add(city, helper);
                }
                else
                {
                    if (!concerts[city].ContainsKey(singer))
                    {
                        concerts[city].Add(singer, profit);
                    }
                    else
                    {
                        concerts[city][singer] += profit;
                    }
                }

                input = Console.ReadLine().Split('@').ToArray();
            }

            foreach (var town in concerts)
            {
                Console.WriteLine(town.Key);

                foreach (var singer in town.Value.OrderByDescending(s => s.Value))
                {
                    Console.WriteLine($"#  {singer.Key}-> {singer.Value}");
                }
            }
        }
    }
}
