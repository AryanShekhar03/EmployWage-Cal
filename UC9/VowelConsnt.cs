using System;
using System.Collections.Generic;
using System.Text;

namespace Alphabet
{
    public class VowelConsnt
    {
        public void printVowel()
        {
            Console.WriteLine("Enter the alphabet:");
            char ch = char.Parse(Console.ReadLine());
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {
                Console.WriteLine("Alphabet is Vowel");
            }
            else if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
            {
                Console.WriteLine("Alphabet is Consonant");
            }
            else
            {
                Console.WriteLine("Is not Alphabet");
            }
        }
    }
}