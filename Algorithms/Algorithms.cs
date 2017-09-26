using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
    public class Algorithms : IAlgorithms
    {
        public object[][] ChunkArrayInGroups(object[] numbers, int counter)
        {
            if (numbers.Length % counter == 0)
            {
                object[][] result = new object[numbers.Length / counter][];
                for (int i = 0; i < result.Length; i++)
                {
                    result[i] = new object[counter];
                }
                return result;
            }
            else
            {
                object[][] result = new object[((numbers.Length - numbers.Length % counter) / counter) + 1][];
                for (int i = 0; i < result.Length; i++)
                {
                    result[i] = new object[counter];
                }
                return result;
            }
        }

        public bool ConfirmEnding(string sentence, string end)
        {
            if (sentence.EndsWith(end))
                return true;
            else
                return false;
        }

        public object[] Destroyer(object[] numbers, params object[] obj)
        {
            return numbers.Where(n => !obj.Contains(n)).ToArray();
        }

        public long Factorialize(int number)
        {
            if (number == 0)
            {
                return 1;
            }
            if (number == 1)
            {
                return 1;
            }
            else
            {
                return number * Factorialize(number - 1);
            }
        }

        public int FindLongestWord(string sentence)
        {
            string[] arrayOfWords = sentence.Split();

            int max = 0;
            foreach (string word in arrayOfWords)
            {
                if (word.Length > max)
                {
                    max = word.Length;
                }
            }
            return max;
        }

        public int GetIndexToIns(object[] numbers, float number)
        {
            Array.Sort(numbers);

            if (number > Convert.ToDouble(numbers[numbers.Length - 1]))
            {
                return numbers.Length;
            }
            else
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (number > Convert.ToDouble(numbers[i]) && number <= Convert.ToDouble(numbers[i + 1]))
                    {
                        return i + 1;
                    }
                }
            }
            return 0;
        }

        public int[] LargestOfFour(int[][] numbers)
        {
            int max = 0; ;
            List<int> result = new List<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                max = 0;
                for (int j = 0; j < numbers[i].Length; j++)
                {
                    if (numbers[i][j] > max)
                    {
                        max = numbers[i][j];
                    }
                }
                result.Add(max);
            }

            return result.ToArray();
        }

        public bool Palindrome(string word)
        {
            string w = word.Replace(" ", "").ToLower();

            string wordOnlyWithLetters = string.Join("", w.Where(c => char.IsLetterOrDigit(c)).ToArray());

            string reverse = string.Join("", wordOnlyWithLetters.ToArray().Reverse());

            if (wordOnlyWithLetters.Equals(reverse))
            {
                return true;
            }
            else
                return false;
        }

        public string RepeatStringNumTimes(string word, int counter)
        {
            if (counter <= 0)
            {
                return "";
            }
            else
            {
                string[] result = new string[counter];
                for (int i = 0; i < counter; i++)
                {
                    result[i] = word;
                }
                return string.Join("", result);
            }
        }

        public string ReverseString(string word)
        {
            return new string(word.ToCharArray().Reverse().ToArray());
        }

        // Caesars Cipher
        public string Rot13(string word)
        {
            char[] buffer = word.ToCharArray();
            for (int i = 0; i < buffer.Length; i++)
            {
                if (char.IsLetter(buffer[i]))
                {
                    // Letter.
                    char letter = buffer[i];
                    // Add shift to all.
                    letter = (char)(letter - 13);

                    // Subtract 26 on overflow.
                    // Add 26 on underflow.
                    if (letter > 'Z')
                    {
                        letter = (char)(letter - 26);
                    }
                    else if (letter < 'A')
                    {
                        letter = (char)(letter + 26);
                    }
                    // Store.
                    buffer[i] = letter;
                }

            }
            return new string(buffer).ToUpper();

        }

        public object[] Slasher(object[] numbers, int counter)
        {
            return numbers.Skip(counter).ToArray();
        }

        public string TitleCase(string sentence)
        {
            string[] arrayOfSentence = sentence.ToLower().Split();

            for (int i = 0; i < arrayOfSentence.Length; i++)
            {
                char[] word = arrayOfSentence[i].ToCharArray();
                word[0] = char.ToUpper(word[0]);
                arrayOfSentence[i] = new string(word);
            }

            return string.Join(" ", arrayOfSentence);
        }

        public string TruncateString(string word, int counter)
        {
            if (counter <= 3)
            {
                return string.Join("", word.ToArray().Take(counter).Concat("..."));
            }
            if (counter >= word.Length)
            {
                return word;
            }
            else
            {
                return string.Join("", word.ToArray().Take(counter - 3).Concat("..."));
            }
        }
    }
}