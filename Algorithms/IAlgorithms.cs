using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public interface IAlgorithms
    {

        string ReverseString(string word);

        long Factorialize(int number);

        bool Palindrome(string word);

        int FindLongestWord(string sentence);

        string TitleCase(string word);

        int[] LargestOfFour(int[][] numbers);

        bool ConfirmEnding(string word, string end);

        string RepeatStringNumTimes(string word, int counter);

        string TruncateString(string word, int counter);

        object[][] ChunkArrayInGroups(object[] numbers, int counter);

        object[] Slasher(object[] numbers, int counter);

        object[] Destroyer(object[] numbers, params object[] obj);

        int GetIndexToIns(object[] numbers, float number);

        string Rot13(string word);

    }
}
