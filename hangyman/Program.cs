using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;






Console.WriteLine("");
Console.WriteLine("Welcome to HANGMAN!");
Console.WriteLine("");

int level = 0;
int theme = 0;

int a = 1;


while (a == 1)
{


    Console.WriteLine("Begin by choosing a difficulty level");
    Console.WriteLine("");
    Console.WriteLine("LEVEL 1 (EASY): 8 guesses      LEVEL 2 (INTERMEDIATE): 5 guesses      LEVEL 3 (HARD): 3 guesses");
    level = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("");

    Console.WriteLine("Select a word theme by entering the corresponding number");
    Console.WriteLine("1. Colours");
    Console.WriteLine("2. Food");
    Console.WriteLine("3. Countries");
    Console.WriteLine("4. Animals");
    Console.WriteLine("5. Sports");
    theme = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("");


    // theme 1: colours
    if (theme == 1)
    {
        Random random = new Random();
        string[] colours = { "blue", "brown", "yellow", "orange", "green", "purple", "red", "pink", "teal", "gold" };
        string wordToGuess = colours[random.Next(0, 10)];

        StringBuilder displayToPlayer = new StringBuilder(wordToGuess.Length); //from https://social.msdn.microsoft.com
        for (int i = 0; i < wordToGuess.Length; i++)
            displayToPlayer.Append('-');

        List<char> correctGuesses = new List<char>(); //Lesson for lists found at https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=net-6.0


        int lives = 0;

        if (level == 1)
        {
            lives = 8;
        }
        if (level == 2)
        {
            lives = 5;
        }
        if (level == 3)
        {
            lives = 3;
        }

        bool won = false; //Lesson for booleans found at https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool
        int lettersRevealed = 0;
        string input;
        char guess;

        while (!won && lives > 0)
        {
            Console.Write("Enter your guess: ");

            input = Console.ReadLine();
            guess = input[0];

            if (correctGuesses.Contains(guess)) //Lesson for .Contains method found at https://docs.microsoft.com/en-us/dotnet/api/system.string.contains?view=net-6.0
            {
                lettersRevealed = lettersRevealed - 1;
            }


            if (wordToGuess.Contains(guess))
            {
                correctGuesses.Add(guess);

                for (int i = 0; i < wordToGuess.Length; i++)
                {
                    if (wordToGuess[i] == guess)
                    {
                        displayToPlayer[i] = wordToGuess[i];
                        lettersRevealed = lettersRevealed + 1;
                    }
                }

                Console.WriteLine("guesses left: " + lives);

                if (lettersRevealed == wordToGuess.Length)
                    won = true;
            }
            else
            {
                lives = lives - 1;
                Console.WriteLine("guesses left: " + lives);
            }

            Console.WriteLine(displayToPlayer.ToString());
            Console.WriteLine("");
        }

        if (won)
        {
            Console.WriteLine("You won! :)");
            Console.WriteLine("To play again, press enter");
        }
        else
        {
            Console.WriteLine("You lost! :( It was '{0}'", wordToGuess);
            Console.WriteLine("To play again, press enter");
        }


        Console.ReadLine();
    }

    //theme 2: food
    if (theme == 2)
    {
        Random random = new Random();
        string[] food = { "pizza", "fries", "apple", "cupcake", "samosa", "burger", "hotdog", "sausage", "salad", "curry" };
        string wordToGuess = food[random.Next(0, 10)];

        StringBuilder displayToPlayer = new StringBuilder(wordToGuess.Length); //from https://social.msdn.microsoft.com
        for (int i = 0; i < wordToGuess.Length; i++)
            displayToPlayer.Append('-');

        List<char> correctGuesses = new List<char>(); //Lesson for lists found at https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=net-6.0


        int lives = 0;

        if (level == 1)
        {
            lives = 8;
        }
        if (level == 2)
        {
            lives = 5;
        }
        if (level == 3)
        {
            lives = 3;
        }

        bool won = false; //Lesson for booleans found at https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool
        int lettersRevealed = 0;

        string input;
        char guess;

        while (!won && lives > 0)
        {
            Console.Write("Enter your guess: ");

            input = Console.ReadLine();
            guess = input[0];

            if (correctGuesses.Contains(guess)) //Lesson for .Contains method found at https://docs.microsoft.com/en-us/dotnet/api/system.string.contains?view=net-6.0
            {
                lettersRevealed = lettersRevealed - 1;
            }


            if (wordToGuess.Contains(guess))
            {
                correctGuesses.Add(guess);

                for (int i = 0; i < wordToGuess.Length; i++)
                {
                    if (wordToGuess[i] == guess)
                    {
                        displayToPlayer[i] = wordToGuess[i];
                        lettersRevealed = lettersRevealed + 1;
                    }
                }

                Console.WriteLine("guesses left: " + lives);

                if (lettersRevealed == wordToGuess.Length)
                    won = true;
            }
            else
            {
                lives = lives - 1;
                Console.WriteLine("guesses left: " + lives);
            }

            Console.WriteLine(displayToPlayer.ToString());
            Console.WriteLine("");
        }

        if (won)
        {
            Console.WriteLine("You won! :)");
            Console.WriteLine("To play again, press enter");
        }
        else
        {
            Console.WriteLine("You lost! :( It was '{0}'", wordToGuess);
            Console.WriteLine("To play again, press enter");
        }


        Console.ReadLine();
    }

    //theme 3: countries
    if (theme == 3)
    {
        Random random = new Random();
        string[] countries = { "canada", "india", "philippines", "america", "england", "switzerland", "mexico", "vietnam", "russia", "egypt" };
        string wordToGuess = countries[random.Next(0, 10)];

        StringBuilder displayToPlayer = new StringBuilder(wordToGuess.Length); //from https://social.msdn.microsoft.com
        for (int i = 0; i < wordToGuess.Length; i++)
            displayToPlayer.Append('-');

        List<char> correctGuesses = new List<char>(); //Lesson for lists found at https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=net-6.0


        int lives = 0;

        if (level == 1)
        {
            lives = 8;
        }
        if (level == 2)
        {
            lives = 5;
        }
        if (level == 3)
        {
            lives = 3;
        }

        bool won = false; //Lesson for booleans found at https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool
        int lettersRevealed = 0;
        string input;
        char guess;

        while (!won && lives > 0)
        {
            Console.Write("Enter your guess: ");

            input = Console.ReadLine();
            guess = input[0];

            if (correctGuesses.Contains(guess)) //Lesson for .Contains method found at https://docs.microsoft.com/en-us/dotnet/api/system.string.contains?view=net-6.0
            {
                lettersRevealed = lettersRevealed - 1;
            }


            if (wordToGuess.Contains(guess))
            {
                correctGuesses.Add(guess);

                for (int i = 0; i < wordToGuess.Length; i++)
                {
                    if (wordToGuess[i] == guess)
                    {
                        displayToPlayer[i] = wordToGuess[i];
                        lettersRevealed = lettersRevealed + 1;
                    }

                }

                Console.WriteLine("guesses left: " + lives);

                if (lettersRevealed == wordToGuess.Length)
                    won = true;
            }
            else
            {
                lives = lives - 1;
                Console.WriteLine("guesses left: " + lives);
            }

            Console.WriteLine(displayToPlayer.ToString());
            Console.WriteLine("");
        }

        if (won)
        {
            Console.WriteLine("You won! :)");
            Console.WriteLine("To play again, press enter");
        }
        else
        {
            Console.WriteLine("You lost! :( It was '{0}'", wordToGuess);
            Console.WriteLine("To play again, press enter");
        }


        Console.ReadLine();
    }

    //theme 4: animals
    if (theme == 4)
    {
        Random random = new Random();
        string[] animals = { "jaguar", "elephant", "kitten", "giraffe", "tiger", "panda", "raccoon", "mouse", "puppy", "koala" };
        string wordToGuess = animals[random.Next(0, 10)];

        StringBuilder displayToPlayer = new StringBuilder(wordToGuess.Length); //from https://social.msdn.microsoft.com
        for (int i = 0; i < wordToGuess.Length; i++)
            displayToPlayer.Append('-');

        List<char> correctGuesses = new List<char>(); //Lesson for lists found at https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=net-6.0


        int lives = 0;

        if (level == 1)
        {
            lives = 8;
        }
        if (level == 2)
        {
            lives = 5;
        }
        if (level == 3)
        {
            lives = 3;
        }

        bool won = false; //Lesson for booleans found at https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool
        int lettersRevealed = 0;

        string input;
        char guess;

        while (!won && lives > 0)
        {
            Console.Write("Enter your guess: ");

            input = Console.ReadLine();
            guess = input[0];

            if (correctGuesses.Contains(guess)) //Lesson for .Contains method found at https://docs.microsoft.com/en-us/dotnet/api/system.string.contains?view=net-6.0
            {
                lettersRevealed = lettersRevealed - 1;
            }


            if (wordToGuess.Contains(guess))
            {
                correctGuesses.Add(guess);

                for (int i = 0; i < wordToGuess.Length; i++)
                {
                    if (wordToGuess[i] == guess)
                    {
                        displayToPlayer[i] = wordToGuess[i];
                        lettersRevealed = lettersRevealed + 1;
                    }
                }

                Console.WriteLine("guesses left: " + lives);

                if (lettersRevealed == wordToGuess.Length)
                    won = true;
            }
            else
            {
                lives = lives - 1;
                Console.WriteLine("guesses left: " + lives);
            }

            Console.WriteLine(displayToPlayer.ToString());
            Console.WriteLine("");
        }

        if (won)
        {
            Console.WriteLine("You won! :)");
            Console.WriteLine("To play again, press enter");
        }
        else
        {
            Console.WriteLine("You lost! :( It was '{0}'", wordToGuess);
            Console.WriteLine("To play again, press enter");
        }


        Console.ReadLine();
    }

    //theme 5: sports
    if (theme == 5)
    {
        Random random = new Random();
        string[] sports = { "soccer", "lacrosse", "basketball", "baseball", "boxing", "swimming", "cheerleading", "dancing", "karate", "skating" };
        string wordToGuess = sports[random.Next(0, 10)];

        StringBuilder displayToPlayer = new StringBuilder(wordToGuess.Length); //from https://social.msdn.microsoft.com
        for (int i = 0; i < wordToGuess.Length; i++)
            displayToPlayer.Append('-');

        List<char> correctGuesses = new List<char>(); //Lesson for lists found at https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=net-6.0


        int lives = 0;

        if (level == 1)
        {
            lives = 8;
        }
        if (level == 2)
        {
            lives = 5;
        }
        if (level == 3)
        {
            lives = 3;
        }

        bool won = false; //Lesson for booleans found at https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool
        int lettersRevealed = 0;

        string input;
        char guess;

        while (!won && lives > 0)
        {
            Console.Write("Enter your guess: ");

            input = Console.ReadLine();
            guess = input[0];

            if (correctGuesses.Contains(guess)) //Lesson for .Contains method found at https://docs.microsoft.com/en-us/dotnet/api/system.string.contains?view=net-6.0
            {
                lettersRevealed = lettersRevealed - 1;
            }


            if (wordToGuess.Contains(guess))
            {
                correctGuesses.Add(guess);

                for (int i = 0; i < wordToGuess.Length; i++)
                {
                    if (wordToGuess[i] == guess)
                    {
                        displayToPlayer[i] = wordToGuess[i];
                        lettersRevealed = lettersRevealed + 1;
                    }
                }

                Console.WriteLine("guesses left: " + lives);

                if (lettersRevealed == wordToGuess.Length)
                    won = true;
            }
            else
            {
                lives = lives - 1;
                Console.WriteLine("guesses left: " + lives);
            }

            Console.WriteLine(displayToPlayer.ToString());
            Console.WriteLine("");
        }

        if (won)
        {
            Console.WriteLine("You won! :)");
            Console.WriteLine("To play again, press enter");
        }
        else
        {
            Console.WriteLine("You lost! :( It was '{0}'", wordToGuess);
            Console.WriteLine("To play again, press enter");
        }


        Console.ReadLine();
    }


    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");


}

