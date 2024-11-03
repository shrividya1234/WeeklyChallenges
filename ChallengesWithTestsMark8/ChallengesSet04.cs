using System;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
           if (numbers == null || numbers.Length == 0)
                {
                    return 0; // Return 0 if the array is null or empty
                }

                int result = 0;

                foreach (int number in numbers)
                {
                    if (number % 2 == 0) // Even number
                    {
                        result += number;
                    }
                    else // Odd number
                    {
                        result -= number;
                    }
                }
                return result;
            }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            return new[] { str1.Length, str2.Length, str3.Length, str4.Length }.Min();
        }
       
        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            return new[] { number1, number2, number3, number4 }.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            if (biz != null)
            {
                biz.Name = "TrueCoders";
            }
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            return (sideLength1 + sideLength2 > sideLength3) &&
                   (sideLength1 + sideLength3 > sideLength2) &&
                   (sideLength2 + sideLength3 > sideLength1);
        }

        public bool IsStringANumber(string input)
        {
            return double.TryParse(input, out _);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            if (objs == null || objs.Length == 0)
                return false;

            int nullCount = objs.Count(o => o == null);
            return nullCount > objs.Length / 2;
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
                return 0;

            var evens = numbers.Where(n => n % 2 == 0).ToArray();
    
            if (evens.Length == 0)
                return 0;

            return evens.Average();
        }

        public int Factorial(int number)
        {
            if (number < 0)
                throw new ArgumentOutOfRangeException("number", "Factorial is not defined for negative numbers.");

            int result = 1;

            for (int i = 2; i <= number; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}
