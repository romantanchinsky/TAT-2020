﻿using System;
using System.Text;

namespace DEV_2_ConsoleString
{
    public class StringEstimator
    {
        private const char SYMBOL_A_LOWERCASE = 'a',
                           SYMBOL_Z_LOWERCASE = 'z',
                           SYMBOL_ZERO = '0',
                           SYMBOL_NINE = '9';
        private int CountMaxConsecutiveIdenticalSymbols(string checkedString, Predicate<char> additionalСondition)
        {
            if (!String.IsNullOrEmpty(checkedString))
            {
                int maxLength, currentLength;
                bool IsFirstElementOfCurrentSequence = true;
                maxLength = currentLength = additionalСondition(checkedString[0]) ? 1 : 0;
                for (int i = 1; i < checkedString.Length; i++)
                {
                    if (additionalСondition(checkedString[i - 1]) && checkedString[i] == checkedString[i - 1])
                    {
                        if (IsFirstElementOfCurrentSequence)
                        {
                            IsFirstElementOfCurrentSequence = false;
                            currentLength = 1;
                        }
                        currentLength++;
                    }
                    else if (!IsFirstElementOfCurrentSequence)
                    {
                        if (currentLength > maxLength)
                        {
                            maxLength = currentLength;
                        }
                        IsFirstElementOfCurrentSequence = true;
                        currentLength = 0;
                    }
                }
                return maxLength > currentLength ? maxLength : currentLength;
            }
            return 0;
        }

        private bool IsLatinLetter(char symbol)
        {
            return symbol >= SYMBOL_A_LOWERCASE && symbol <= SYMBOL_Z_LOWERCASE;
        }

        private bool IsNumber(char symbol)
        {
            return symbol >= SYMBOL_ZERO && symbol <= SYMBOL_NINE;
        }

        public int CountMaxConsecutiveIdenticalLatinLetters(string checkedString)
        {
            return checkedString != null ? CountMaxConsecutiveIdenticalSymbols(checkedString.ToLower(), IsLatinLetter) : throw new ArgumentNullException();
        }

        public int CountMaxConsecutiveIdenticalNumbers(string checkedString)
        {
            return checkedString != null ? CountMaxConsecutiveIdenticalSymbols(checkedString, IsNumber) : throw new ArgumentNullException();
        }

        public int CountMaxConsecutiveUnequalSymbols(string checkedString)
        {
            int maxLength = 0;
            if (!String.IsNullOrEmpty(checkedString))
            {
                StringBuilder currentUnequalSequence = new StringBuilder();
                currentUnequalSequence.Append(checkedString[0]);
                int symbolPosition;
                for (int i = 1; i < checkedString.Length; i++)
                {
                    symbolPosition = currentUnequalSequence.ToString().IndexOf(checkedString[i]);
                    if (symbolPosition != -1)
                    {
                        if (currentUnequalSequence.Length > maxLength)
                        {
                            maxLength = currentUnequalSequence.Length;
                        }
                        currentUnequalSequence.Remove(0, symbolPosition + 1);
                    }
                    currentUnequalSequence.Append(checkedString[i]);
                }
                return maxLength > currentUnequalSequence.Length ? maxLength : currentUnequalSequence.Length;
            }
            return maxLength;
        }
    }
}
