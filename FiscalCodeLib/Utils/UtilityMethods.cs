using System;
using System.Collections.Generic;

namespace FiscalCodeLib.Utils
{
    public static class UtilityMethods
    {
        public static readonly char[] Vowels = {'A', 'E', 'I', 'O', 'U'};

        public static readonly Dictionary<int, string> MonthMap = new Dictionary<int, string>
        {
            {1, "A"},
            {2, "B"},
            {3, "C"},
            {4, "D"},
            {5, "E"},
            {6, "H"},
            {7, "L"},
            {8, "M"},
            {9, "P"},
            {10, "R"},
            {11, "S"},
            {12, "T"}
        };

        public static readonly Dictionary<char, int> EvenPositionMap = new Dictionary<char, int>
        {
            {'A', 0},
            {'0', 0},
            {'B', 1},
            {'1', 1},
            {'C', 2},
            {'2', 2},
            {'D', 3},
            {'3', 3},
            {'E', 4},
            {'4', 4},
            {'F', 5},
            {'5', 5},
            {'G', 6},
            {'6', 6},
            {'H', 7},
            {'7', 7},
            {'I', 8},
            {'8', 8},
            {'J', 9},
            {'9', 9},
            {'K', 10},
            {'L', 11},
            {'M', 12},
            {'N', 13},
            {'O', 14},
            {'P', 15},
            {'Q', 16},
            {'R', 17},
            {'S', 18},
            {'T', 19},
            {'U', 20},
            {'V', 21},
            {'W', 22},
            {'X', 23},
            {'Y', 24},
            {'Z', 25}
        };
        public static readonly Dictionary<char, int> OddPositionMap = new Dictionary<char, int>
        {
            {'A', 1},
            {'0', 1},
            {'B', 0},
            {'1', 0},
            {'C', 5},
            {'2', 5},
            {'D', 7},
            {'3', 7},
            {'E', 9},
            {'4', 9},
            {'F', 13},
            {'5', 13},
            {'G', 15},
            {'6', 15},
            {'H', 17},
            {'7', 17},
            {'I', 19},
            {'8', 19},
            {'J', 21},
            {'9', 21},
            {'K', 2},
            {'L', 4},
            {'M', 18},
            {'N', 20},
            {'O', 11},
            {'P', 3},
            {'Q', 6},
            {'R', 8},
            {'S', 12},
            {'T', 14},
            {'U', 16},
            {'V', 10},
            {'W', 22},
            {'X', 25},
            {'Y', 24},
            {'Z', 23}
        };

        public static char GetCheckDigit(int accumulationResult)
        {
            if (accumulationResult < 0)
            {
                throw new ArgumentException("The parameter accumulationResult must be a positive integer in the range 0-25");
            }

            int addend = accumulationResult % 26;
            return ((char) ('A' + addend));
        }
    }
}