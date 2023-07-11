using System;

namespace numberGuessingGame.classes
{
    public class Director
    {
        bool isPlaying = true;
        int numberOfGuesses;
        List<int> prevGuesses = new List<int>();
        public void BeginGame() {

            randomNumberGenerator randomNumber = new randomNumberGenerator();
            numberOfGuesses = 0;
            int randomNum = randomNumber.Draw();

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Welcome to my number guessing game!");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine(" ");
            Console.WriteLine("The objective of the game is to guess the number that the program has picked. Let's start!");
            Console.WriteLine(" ");

            do{
                Console.Write("Enter your guess: ");
                String userGuessString = Console.ReadLine();
                int userGuess = Convert.ToInt32(userGuessString);
                prevGuesses.Add(userGuess);

                numberOfGuesses++;

                if (userGuess == randomNum) {
                    Console.WriteLine($"Congrats! You successfully guessed the number in {numberOfGuesses} guesses!");
                    Console.WriteLine(string.Format("Your guesses: {0}", string.Join(", ", prevGuesses)));
                    Console.WriteLine(" ");
                    
                    Console.Write("Would you like to play again (Y/N)?: ");
                    string playAgain = Console.ReadLine().ToUpper();

                    if (playAgain == "Y") {
                        isPlaying = true;
                        randomNum = randomNumber.Draw();
                    }

                    else {
                        isPlaying = false;
                    }
                }

                else if (userGuess > randomNum) {
                    Console.WriteLine("You're a little high. Guess again!");
                    Console.WriteLine(string.Format("Previous guesses: {0}", string.Join(", ", prevGuesses)));
                    Console.WriteLine(" ");

                }

                else if (userGuess < randomNum) {
                    Console.WriteLine("You're a little low. Guess again!");
                    Console.WriteLine(string.Format("Previous guesses: {0}", string.Join(", ", prevGuesses)));
                    Console.WriteLine(" ");

                }
            } while(isPlaying);

            Console.WriteLine(" ");
            Console.WriteLine("Thanks for playing!");
        }
    }
}
