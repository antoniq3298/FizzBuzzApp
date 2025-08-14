using System;
using System.Text;
using System.Text.RegularExpressions;

namespace FizzBuzzApp
{
    public class FizzBuzzDetector
    {
        public FizzBuzzResult GetOverlappings(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                throw new ArgumentException("Input string cannot be null or empty");

            if (input.Length < 7 || input.Length > 100)
                throw new ArgumentException("Input length must be between 7 and 100 characters");

            string[] words = Regex.Split(input, "(\\W+)"); // split but keep separators
            int wordCounter = 0;
            int fizzBuzzCount = 0;

            for (int i = 0; i < words.Length; i++)
            {
                if (Regex.IsMatch(words[i], "^[a-zA-Z0-9]+$"))
                {
                    wordCounter++;
                    bool isThird = (wordCounter % 3 == 0);
                    bool isFifth = (wordCounter % 5 == 0);

                    if (isThird && isFifth)
                    {
                        words[i] = "FizzBuzz";
                        fizzBuzzCount++;
                    }
                    else if (isThird)
                    {
                        words[i] = "Fizz";
                        fizzBuzzCount++;
                    }
                    else if (isFifth)
                    {
                        words[i] = "Buzz";
                        fizzBuzzCount++;
                    }
                }
            }

            string output = string.Join("", words);
            return new FizzBuzzResult(output, fizzBuzzCount);
        }
    }
}
