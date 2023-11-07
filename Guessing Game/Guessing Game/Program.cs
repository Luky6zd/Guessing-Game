using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guessing_Game
{
    class GuessingGame
    {
        static void Main(string[] args)
        {
            string secretWord = "car";
            string guess = ""; // prazna vrijednost striga
            int guessCounter = 0; // brojac pogadanja
            int guessLimit = 4; // limit broja pogadanja je 4
            bool outOfGuesses = false; // ako igrac ostane bez pokusaja pogadanja vrijednost je true, ako ima jos pokusaja vrijednost je false

            while(guess != secretWord && !outOfGuesses) //  igra se vrti sve dok igrac ne pogodi tajnu rijec i dok ima pokusaja pogadanja
            {
                // ako igrac ima pokusaja pogadanja (max je 4 pokusaja)
                if(guessCounter < guessLimit)
                {
                    Console.Write("Enter your guess: ");
                    guess = Console.ReadLine();
                    guessCounter++;
                }
                // ako igracu ponestane pokusaja pogadanja
                else
                {
                    // "boolean flag", igrac prestaje sa igrom
                    outOfGuesses = true;
                }
                
            }

            if(outOfGuesses)
            {
                Console.Write("You Lose :( ");
            }
            else
            {
                Console.WriteLine("You Win!!!");
            }
            Console.ReadLine();
        }
    }
}
