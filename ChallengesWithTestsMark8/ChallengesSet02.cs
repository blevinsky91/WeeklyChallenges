using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            var letters = "abcdefghijklmnopqrstuvwxyz";
            if (letters.Contains(Char.ToLower(c)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            var count = vals.Length;
            if (count % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
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
            if (numbers == null)
            {
                return 0;
            }
            if (numbers.Count() == 1)
            {
                return numbers.First() + numbers.First();
            }

            double max = 0;
            double min = 0;

            foreach (double number in numbers)
            {
                
                if (number > max)
                {
                    max = number;
                }
                if (number < min)
                {
                    min = number;
                }
                
            }
            return max + min;
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length > str2.Length)
            {
                return str2.Length;
            }
            else
            {
                return str1.Length;
            }
        }

        public int Sum(int[] numbers)
        {
            if(numbers == null)
            {
                return 0;
            }
            int result = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                result += numbers[i];
            }
            return result;
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            int result = 0;
            foreach (int item in numbers)
            {
                if (item % 2 == 0)
                {
                    result += item;
                }
            }
            return result;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            int result = 0;
            foreach (int number in numbers)
            {
                result += number;
            }
            return (result % 2 != 0);
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            return number < 0 ? 0 : number / 2;
        }
    }
}
