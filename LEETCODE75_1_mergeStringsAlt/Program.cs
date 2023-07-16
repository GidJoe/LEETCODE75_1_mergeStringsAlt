using System.Text;

namespace LEETCODE75_1_mergeStringsAlt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program pg = new Program();
            Console.WriteLine(pg.MergeAlternately("Marc", "Annaaaa"));

        }

        public string MergeAlternately(string word1, string word2)
        {
            int longestString = Math.Max(word1.Length, word2.Length);
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < longestString; i++)
            {
                if (i < word1.Length)
                {
                    sb.Append(word1[i]);

                }

                if (i < word2.Length)
                {
                    sb.Append(word2[i]);

                }

            }

            string result = sb.ToString();
            return result;
        }
    }
}
