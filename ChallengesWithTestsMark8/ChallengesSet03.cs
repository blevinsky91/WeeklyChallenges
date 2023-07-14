using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            if (vals == null || vals.Length == 0)
            {
                return false;
            }
            bool sum = false;
            foreach (bool item in vals)
            {
                if (item == false)
                {
                    sum = true;
                }
            }
            return sum;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null || numbers.Count() == 0)
            {
                return false;
            }

            bool ans;
            int sum = 0;
            foreach (var item in numbers)
            {
                if (item % 2 != 0)
                {
                    sum += item;
                }
            }
            if (sum % 2 == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
            
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            if (password == null)
            {
                return false;
            }

            bool isUpper = false;
            bool isLower = false;
            bool isNumber = false;

            foreach(var item in password)
            {
                if (Char.IsLower(item))
                {
                    isLower = true;
                }
                else if (Char.IsUpper(item))
                {
                    isUpper = true;
                }
                else if (Char.IsNumber(item))
                {
                    isNumber = true;
                }
                else if (Char.IsLower(item) && Char.IsUpper(item) && Char.IsNumber(item))
                {
                    return false;
                }
                else
                {
                    return false;
                }
            }
            return (isUpper && isUpper && isNumber);
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            return divisor == 0 ? 0: dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            var ans = new List<int>();

            for(int i = 0; i <= 100; i++)
            {
                if(i % 2 != 0)
                {
                    ans.Add(i);
                }
            }
            return ans.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
       
    }
}
