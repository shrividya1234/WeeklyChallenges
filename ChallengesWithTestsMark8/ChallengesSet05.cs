using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        // Method to get the next number that is divisible by n after a given start number
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            int remainder = startNumber % n;
            return remainder == 0 ? startNumber + n : startNumber + (n - remainder);
        }

        // Method to change business names to "CLOSED" if their total revenue is zero or less
        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            if (businesses == null)
                throw new ArgumentNullException(nameof(businesses), "Input array cannot be null.");

            foreach (var business in businesses)
            {
                if (business.TotalRevenue <= 0)
                {
                    business.Name = "CLOSED"; // Change the business name to "CLOSED"
                }
            }
        }

        // Method to check if the numbers in an array are in ascending order
        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0) return false; // Handle null or empty case

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < numbers[i - 1])
                {
                    return false;
                }
            }

            return true;
        }

        // Method to sum elements that follow an even number in an array
        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers == null || numbers.Length < 2)
            {
                return 0; // If the array is null or has less than 2 elements, return 0
            }

            int sum = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] % 2 == 0) // Check if the current number is even
                {
                    sum += numbers[i + 1]; // Add the next number to the sum
                }
            }

            return sum;
        }

        // Method to turn an array of words into a single sentence
        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null)
            {
                return "";
            }

            // Join the words with a space, trim leading and trailing spaces, and remove extra spaces
            string result = string.Join(" ", words)
                .Trim() // Remove leading and trailing whitespace
                .Replace("  ", " "); // Replace multiple spaces with a single space

            // Handle the case of multiple spaces in the result
            while (result.Contains("  "))
            {
                result = result.Replace("  ", " ");
            }

            // Return the final result, ensuring it ends with a period
            return string.IsNullOrEmpty(result) ? "" : result + ".";
        }
    

// Method to get every fourth element from a list of doubles
        public double[] GetEveryFourthElement(List<double> elements)
        {
            if (elements == null || elements.Count == 0)
            {
                return new double[0]; // Return an empty array if the list is null or empty
            }

            List<double> result = new List<double>();

            for (int i = 3; i < elements.Count; i += 4) // Start at index 3 (the 4th element)
            {
                result.Add(elements[i]); // Add every 4th element
            }

            return result.ToArray(); // Convert the result list to an array
        }

        // Method to determine if two different elements in an array can sum to a target number
        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            if (nums == null || nums.Length < 2)
            {
                return false; // Return false if the array is null or has fewer than 2 elements
            }

            HashSet<int> seenNumbers = new HashSet<int>();

            foreach (int number in nums)
            {
                int complement = targetNumber - number;

                // Check if the complement has been seen before
                if (seenNumbers.Contains(complement))
                {
                    return true; // Found two different elements that sum to targetNumber
                }

                // Add the current number to the set
                seenNumbers.Add(number);
            }

            return false; // No such pair found
        }
    }

    
}
