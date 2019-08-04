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
            {'R', 17}
            //todo Complete this
        };
    }
}