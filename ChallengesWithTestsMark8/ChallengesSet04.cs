using System;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int result = 0;

            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    result += number; // Add even numbers
                }
                else
                {
                    result -= number; // Subtract odd numbers
                }
            }

            return result;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            int len1 = str1.Length;
            int len2 = str2.Length;
            int len3 = str3.Length;
            int len4 = str4.Length;

            return Math.Min(Math.Min(len1, len2), Math.Min(len3, len4));

        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            return Math.Min(Math.Min(number1, number2), Math.Min(number3, number4));
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            return sideLength1 + sideLength2 > sideLength3 &&
                   sideLength1 + sideLength3 > sideLength2 &&
                   sideLength2 + sideLength3 > sideLength1;
        }

        public bool IsStringANumber(string input)
        {
            double num;
            return !string.IsNullOrEmpty(input) && double.TryParse(input, out num);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int nullCount = 0;
            foreach (object obj in objs)
            {
                if (obj == null)
                {
                    nullCount++;
                }
            }

            return nullCount > objs.Length / 2;
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }

            var evens = numbers.Where(n => n % 2 == 0);

            if (!evens.Any())
            {
                return 0;
            }

            return evens.Average();
        }

        public int Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            int result = 1;

            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}
