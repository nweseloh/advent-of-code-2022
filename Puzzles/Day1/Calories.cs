using System;
using System.Collections.Generic;
using System.Linq;

namespace Puzzles.Day1
{
    public class Calories
    {
        public int GetHighestCalories(IEnumerable<string> input, int numberOfElves = 1)
        {
            // make sure to flush result at the end of string
            input = input.Append(string.Empty);

            List<string> caloriesOfCurrentElf = new List<string>();
            List<int> results = new List<int>();
            
            foreach (string inputItem in input)
            {
                if (inputItem == string.Empty)
                {
                    results.Add(caloriesOfCurrentElf.Sum(int.Parse));
                    caloriesOfCurrentElf.Clear();
                }
                else
                {
                    caloriesOfCurrentElf.Add(inputItem);
                }
            }

            return results.OrderByDescending(i => i).Take(numberOfElves).Sum();
        }
    }
}