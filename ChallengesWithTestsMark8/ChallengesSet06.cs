﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            bool containsWord = false;

            if (string.Equals(words, null) || words.Contains(null))
            {
                return false;
            }

            if (ignoreCase == true)
            {
                word = word.ToLower();

                List<string> lc = words.Select(x => x.ToLower()).ToList();

                containsWord = lc.Contains(word);
            }

            if (ignoreCase == false)
            {
                containsWord = words.Contains(word);
            }

            return containsWord;
        }

        public bool IsPrimeNumber(int num)
        {
            var isPrime = false;
        
            if (num >= 0 )
            {
                if (num % 2 != 0 && num % 3 != 0)
                {
                    isPrime = true; 
                }
            }
            if ((num == 2) || (num == 3))
            {
                isPrime = true;
            }

            if (num == 1)
            {
                isPrime = false;
            }

            return isPrime;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            int index = -1;
            bool uindex;

            for (int i = 0; i < str.Length; i++)
            {
                uindex = true;

                for (int x = 0; x < str.Length; x++)
                {
                    if (str[i] == str[x] && i != x)
                    {
                        uindex = false;
                    }
                }

                if (uindex == true)
                {
                    index = i;
                }
            }
            return index;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentCount = 1;
                
                for (int x = i + 1; x < numbers.Length; x++)
                {
                    if (numbers[i] != numbers[x])
                    {
                        break;
                    }
                    currentCount ++;
                }

                if (currentCount > count)
                {
                    count = currentCount;
                }
            }

            return count;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            if (elements == null || elements.Count == 0 || n < 0)
            {
                return new double[0];
            }

            List<double> result = new List<double>();

            for (int i = n - 1; i < elements.Count; i += n)
            {
                result.Add(elements[i]);
            }

            return result.ToArray();

        }
    }
}
