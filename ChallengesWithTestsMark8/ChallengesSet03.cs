using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            if (vals == null)
            {
                return false;
            }

            foreach (var item in vals)
            {
                if (item == false)
                {
                    return true;
                }
            }

            return false;

        }






        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
            {
                throw new NotImplementedException();
            }

            public bool PasswordContainsUpperLowerAndNumber(string password)
            {
                throw new NotImplementedException();
            }

            public char GetFirstLetterOfString(string val)
            {
                throw new NotImplementedException();
            }

            public char GetLastLetterOfString(string val)
            {
                throw new NotImplementedException();
            }

            public decimal Divide(decimal dividend, decimal divisor)
            {
                throw new NotImplementedException();
            }

            public int LastMinusFirst(int[] nums)
            {
                throw new NotImplementedException();
            }

            public int[] GetOddsBelow100()
            {
                throw new NotImplementedException();
            }

            public void ChangeAllElementsToUppercase(string[] words)
            {
                throw new NotImplementedException();
            }
        
    }
}
