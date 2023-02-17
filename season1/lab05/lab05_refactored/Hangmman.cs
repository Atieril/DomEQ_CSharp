using System;
using System.Collections.Generic;

namespace lab05_temp
{
    class Hangmen
    {
        string GetRandomWord()
        {
            Random ra = new Random();
            var words = new string[] { "cat", "dog", "whatever" };
            return words[ra.Next(words.Length)];
        }

         void DisplayAlphabet(string alphabet, List<char> guessedLetters)
        {
            for (var i = 0; i < alphabet.Length; i++)
            {
                if (guessedLetters.Contains(alphabet[i]))
                {
                    alphabet = alphabet.Replace(alphabet[i], '_');
                }
            }
            Console.WriteLine($"{alphabet}");
        }

         void DisplayWord(string word, List<char> guessedLetters)
        {
            for (var i = 0; i < word.Length; i++)
            {
                if (!guessedLetters.Contains(word[i]))
                {
                    word = word.Replace(word[i], '_');
                }
            }

            Console.WriteLine($"{word}");
        }

         bool AllRequiredLettersAreGuessed(string word, List<char> guessedLetters)
        {
            var allGuessed = true;
            for (var i = 0; i < word.Length; i++)
            {
                if (!guessedLetters.Contains(word[i]))
                {
                    allGuessed = false;
                }
            }

            return allGuessed;
        }

        public void Run()
        {

            var numberOfAttempts = 7;

            var word = GetRandomWord();
            var alphabet = "abcdefghijklmnopqrstuvxyz";

            var guessedLetters = new List<char>();



            while (true)
            {

                Console.WriteLine($"Attempts left: {numberOfAttempts}");
                DisplayAlphabet(alphabet, guessedLetters);

                DisplayWord(word, guessedLetters);

                var line = Console.ReadLine();

                var letter = line[0];

                guessedLetters.Add(letter);

                if (AllRequiredLettersAreGuessed(word, guessedLetters))
                {
                    Console.WriteLine("You won");
                    break;
                }
                else if (!word.Contains(letter))
                {
                    numberOfAttempts--;
                }

                if (numberOfAttempts == 0)
                {
                    Console.WriteLine("You lost");
                    break;
                }
            }
        }
    }
}
