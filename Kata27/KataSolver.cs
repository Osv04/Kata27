using System;
using System.Collections.Generic;
using System.Text;

namespace Kata27
{
    public class KataSolver
    {
        public string Solver(string word) 
        {
            char[] letters = word.ToCharArray();

            for (int i = 0; i < letters.Length; i++)
            {
                if (letters[i] == 'a' || letters[i] == 'A')
                {
                    letters[i] = 'a';
                }
                if (letters[i] == 'b' || letters[i] == 'B')
                {
                    letters[i] = 'b';
                }
                if (letters[i] == 'c' || letters[i] == 'C')
                {
                    letters[i] = 'c';
                }
                if (letters[i] == 'd' || letters[i] == 'D')
                {
                    letters[i] = 'd';
                }
                if (letters[i] == 'e' || letters[i] == 'e')
                {
                    letters[i] = 'E';
                }
                if (letters[i] == 'f' || letters[i] == 'F')
                {
                    letters[i] = 'f';
                }
                if (letters[i] == 'g' || letters[i] == 'G')
                {
                    letters[i] = 'g';
                }
                if (letters[i] == 'h' || letters[i] == 'H')
                {
                    letters[i] = 'h';
                }
                if (letters[i] == 'i' || letters[i] == 'I')
                {
                    letters[i] = 'i';
                }
                if (letters[i] == 'j' || letters[i] == 'J')
                {
                    letters[i] = 'j';
                }
                if (letters[i] == 'k' || letters[i] == 'K')
                {
                    letters[i] = 'k';
                }
                if (letters[i] == 'l' || letters[i] == 'L')
                {
                    letters[i] = 'l';
                }
                if (letters[i] == 'm' || letters[i] == 'M')
                {
                    letters[i] = 'm';
                }
                if (letters[i] == 'n' || letters[i] == 'N')
                {
                    letters[i] = 'n';
                }
                if (letters[i] == 'o' || letters[i] == 'O')
                {
                    letters[i] = 'o';
                }
                if (letters[i] == 'p' || letters[i] == 'P')
                {
                    letters[i] = 'p';
                }
                if (letters[i] == 'q' || letters[i] == 'Q')
                {
                    letters[i] = 'q';
                }
                if (letters[i] == 'R' || letters[i] == 'r')
                {
                    letters[i] = 'r';
                }
                if (letters[i] == 's' || letters[i] == 'S')
                {
                    letters[i] = 's';
                }
                if (letters[i] == 't' || letters[i] == 'T')
                {
                    letters[i] = 't';
                }
                if (letters[i] == 'u' || letters[i] == 'U')
                {
                    letters[i] = 'u';
                }
                if (letters[i] == 'v' || letters[i] == 'V')
                {
                    letters[i] = 'v';
                }
                if (letters[i] == 'w' || letters[i] == 'W')
                {
                    letters[i] = 'w';
                }
                if (letters[i] == 'x' || letters[i] == 'X')
                {
                    letters[i] = 'x';
                }
                if (letters[i] == 'y' || letters[i] == 'Y')
                {
                    letters[i] = 'y';
                }
                if (letters[i] == 'z' || letters[i] == 'Z')
                {
                    letters[i] = 'z';
                }
            }

            string resultado = new string(letters);

            return resultado;
        }
    }
}
