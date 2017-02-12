namespace LastThreeNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LastThreeNumbers
    {
        public static void Main()
        {
            string[] input = Console.ReadLine()
                .Split(' ');

            List<int> nums = input
                .Select(int.Parse)
                .ToList();

            var sortedNumbers = nums.OrderByDescending(x => x);
            var largest3Numbers = sortedNumbers.Take(3);

            Console.WriteLine(string.Join(" ", largest3Numbers));
        }
    }
}
