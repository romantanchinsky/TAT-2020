using System;
using System.Text;

namespace DEV_2_ConsoleString
{
    public class StringEstimator
    {
        private int CountMaxConsecutiveIdenticalSymbols(string checkedString, Predicate<char> additionalСondition)
        {
            int maxLength = 0;
            if (String.IsNullOrEmpty(checkedString))
            {
                int currentLength = 1;
                for (int i = 1; i < checkedString.Length; i++)
                {
                    if (checkedString[i] == checkedString[i - 1] && additionalСondition(checkedString[i]))
                    {
                        currentLength++;
                    }
                    else
                    {
                        if (currentLength > maxLength)
                        {
                            maxLength = currentLength;
                        }
                        currentLength = 1;
                    }
                }
                return maxLength > currentLength ? maxLength : currentLength;
            }
            return maxLength;
        }

        private bool IsLatinLetter(char symbol)
        {
            return symbol >= 'a' && symbol <= 'z' || symbol >= 'A' && symbol <= 'Z';
        }

        private bool IsNumber(char symbol)
        {
            return symbol >= '1' && symbol <= '9';
        }

        public int CountMaxConsecutiveIdenticalLatinLetters(string checkedString)
        {
            return checkedString != null ? CountMaxConsecutiveIdenticalSymbols(checkedString, IsLatinLetter) : throw new ArgumentNullException();
        }

        public int CountMaxConsecutiveIdenticalNumbers(string checkedString)
        {
            return CountMaxConsecutiveIdenticalSymbols(checkedString, IsNumber);
        }

        public int CountMaxConsecutiveUnequalSymbols(string checkedString)
        {
            int maxLength = 0;
            if (!String.IsNullOrEmpty(checkedString))
            {
                StringBuilder currentUnequalSequence = new StringBuilder(checkedString[0]);
                int symbolPosition = -1;
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
