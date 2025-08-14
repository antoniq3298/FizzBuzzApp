# FizzBuzz Detector

## Description
This is a C# console application that processes a given text and replaces:
- Every **third** alphanumeric word with `"Fizz"`
- Every **fifth** alphanumeric word with `"Buzz"`
- Words that are both third and fifth (i.e. divisible by 15) are replaced with `"FizzBuzz"`

The program also counts how many replacements were made (counting `"Fizz"`, `"Buzz"`, and `"FizzBuzz"` equally as 1).

## Features
- Handles only **alphanumeric** words (punctuation and whitespace are ignored in counting positions).
- Works with input strings between 7 and 100 characters.
- Returns both:
  1. The transformed string
  2. The total count of replacements
- Includes **unit tests** (NUnit) with at least 5 test cases covering common and edge scenarios.

## Example
**Input:**
Mary had a little lamb
Little lamb, little lamb
Mary had a little lamb
It's fleece was white as snow

**Output:**
Mary had Fizz little Buzz
Fizz lamb, little Fizz
Buzz had Fizz little lamb
FizzBuzz fleece was Fizz as Buzz

**Count:** 9

## How to Run
1. Clone the repository.
2. Open the solution in **Visual Studio** or **Rider**.
3. Set `FizzBuzzApp` as the startup project.
4. Run the project — you can modify the input text inside `Program.cs`.

## How to Test
1. Make sure you have **NUnit** installed (NuGet restore will handle this).
2. Run the tests from Visual Studio's Test Explorer or via:


## Notes
- No built-in FizzBuzz detection utilities or third-party libraries were used — the logic is implemented manually.
- The code follows Google Style Guidelines where applicable.
- Implemented in under 2 hours as per task requirements.
