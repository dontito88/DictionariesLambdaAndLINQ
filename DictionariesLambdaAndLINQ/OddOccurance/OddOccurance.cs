namespace OddOccurance
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class OddOccurance
    {
        public static void Main()
        {
            var words = Console.ReadLine().ToLower().Split(' ');

            var wordCount = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (!wordCount.ContainsKey(word))
                {
                    wordCount[word] = 0;
                }
                wordCount[word]++;
            }
            var result = new List<string>();
            foreach (var item in wordCount)
            {
                if (item.Value % 2 != 0)
                {
                    result.Add(item.Key);
                }
            }
            Console.WriteLine(string.Join(", ", result ));
        }
    }
}
