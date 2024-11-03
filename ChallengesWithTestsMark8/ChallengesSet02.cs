using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            return vals.Length % 2 == 0;
        }

        public bool IsNumberEven(int number)
        {
            return number % 2 == 0;
        }

        public bool IsNumberOdd(int num)
        {
            return num % 2 != 0;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null || !numbers.Any())
            {
                return 0; 
            }
            double min = numbers.Min();
            double max = numbers.Max();
            return min + max;
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1 == null || str2 == null)
            {
                return 0; // Handle null cases if you want a specific behavior for null strings
            }

            return Math.Min(str1.Length, str2.Length);
        }

        public int Sum(int[] numbers)
        {
            numbers = numbers ?? new int[0];
            return numbers.Sum();
        }

        public int SumEvens(int[] numbers)
        {
           if(numbers==null || numbers.Length==0)
           {
               return 0;
           }
           else
           {
               return numbers.Where(n => n % 2 == 0).Sum();
           }
        }

        public bool IsSumOdd(List<int> numbers)
        {if (numbers == null || numbers.Count == 0)
            {
                return false; // If there are no numbers, we assume the sum is not odd
            }

            int sum = numbers.Sum();
            return sum % 2 != 0;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            {
                if (number <= 0)
                {
                    return 0; 
                }

                int count = 0;
                for (int i = 1; i < number; i += 2)
                {
                    count++;
                }

                return count;
            }
        }
    }
}
