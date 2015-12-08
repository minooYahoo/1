// Minoo Meshgin  LAB random guessed number

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random ranGen = new Random();
            int ranNum=ranGen.Next(0,100);
          
            int guessedNum=-1;
            int countOfGuesses=0;
            
            while(guessedNum!=ranNum)
            {
              Console.WriteLine(" Guess another number ");
              guessedNum =Int32.Parse(Console.ReadLine()); 

                if(guessedNum<ranNum)
                {
                    Console.WriteLine(" Guess number  is Lower than Random number ");
                }
                else if (guessedNum==ranNum)
                {
                  Console.WriteLine(" Guess number  is EQUAL to the Random number ");
                }
                else
                {
                Console.WriteLine(" Guess number  is Higher than Random number ");

                }
                countOfGuesses++;
                
            }
            Console.WriteLine("This many guesses you have made " +countOfGuesses);
            Console.ReadLine();
        }
    }
}


