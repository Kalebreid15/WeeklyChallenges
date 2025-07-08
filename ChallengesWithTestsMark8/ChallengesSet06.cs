using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.Versioning;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words == null || word == null)
            {
                return false;
            }

            foreach (string w in words)
            {
                if (w == null)
                {
                    continue;
                }
                if (ignoreCase)
                {
                    if (string.Equals(w, word, StringComparison.OrdinalIgnoreCase))
                    {
                        return true;
                    }
                }
                else
                {
                    if (w == word)
                    {
                        return true;
                    }
                }
            }

            return false;
        }



        public bool IsPrimeNumber(int num)
        {
            if (num <= 1)
            {
                return false;
            }

            int boundary = (int)Math.Floor(Math.Sqrt(num));
            for (int i = 2; i <= boundary; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return -1;
            }

            Dictionary<char, int> charCount = new Dictionary<char, int>();

            foreach (char c in str)
            {
                if (charCount.ContainsKey(c))
                {
                    charCount[c]++;
                }
                else
                {
                    charCount[c] = 1;
                }
            }
            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (charCount[str[i]] == 1)
                {
                    return i;
                }
            }

            return -1;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }

            int maxCount = 1;
            int currentCount = 1;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    currentCount++;
                }
                else
                {
                    currentCount = 1;
                }
                if (currentCount > maxCount)
                {
                    maxCount = currentCount;
                }
            }

            return maxCount;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            if (elements == null || n <= 0)
            {
                return new double[] { };
            }

            List<double> result = new List<double>();

            for (int i = 0; i < elements.Count; i++)
            {
                if ((i + 1) % n == 0)
                {
                    result.Add(elements[i]);
                }
            }

            return result.ToArray();
        }

    }
}
