using System;
using System.Linq;
using System.ComponentModel;
using System.Globalization;

namespace Open_Lab_05._05
{
    public class StringTools
    {
        public string AlternatingCaps(string original)
        {
            original = original.ToLower();
            string modified = "";
            int i = 0;
            int pM = 0;

            while (i < original.Length)
            {
                if (original[i] == ' ' && i == 0)
                {
                    modified += original[0];
                }
                else if (i == 0 && original[i] != ' ')
                    modified += char.ToUpper(original[i]);
                else if (modified[i - 1] == char.ToUpper(original[i - 1]) && original[i] != ' ' && original[i - 1] != ' ')
                {
                    modified += char.ToLower(original[i]);
                }
                else if (modified[i - 1] == char.ToLower(original[i - 1]) && original[i - 1] != ' ')
                {
                    modified += char.ToUpper(original[i]);
                }
                else if (original[i] == ' ')
                {
                    modified += original[i];
                    pM++;

                }
                else if (original[i - 1] == ' ' && original[i] != ' ' && original[i - pM - 1] == modified[i - pM - 1] && i != 0)
                {
                    modified += char.ToUpper(original[i]);
                    pM = 0;
                }
                else if (original[i - 1] == ' ' && original[i] != ' ' && char.ToUpper(original[i - pM - 1]) == modified[i - pM - 1] && i != 0)
                {
                    modified += original[i];
                    pM = 0;
                }
                i++;
            }
            return modified;
        }
    }
}
