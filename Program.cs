using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            string UserName = "";

            Console.Write("Hello what is your name?: ");
            UserName = Console.ReadLine();

            Console.WriteLine(UserName + " would you like to play a game?");
            
            bool DoesHeWantToPlay = Console.ReadKey().Key == ConsoleKey.Y;

            if (DoesHeWantToPlay)
            {
                Console.WriteLine("\r\n Awsome " + UserName + "\r\n I love games.  \r\n lets play a randomnumber game.  Guess what i picked"  );

                int number;                         //Tell the computer that we need a place to keep a number for us
                number = new Random().Next(50);     //as the objecxt called Random tro give us a number nad store the result in out variable calledf number

                string usernumber;                  //Tell the computer that we need a place to keep TEXT for us
                bool didusematchournumber = false;

                do
                {
                    usernumber = Console.ReadLine();    //ask the console to read what the user typed and then store the result in our variable called usernumber

                    int usernumber2 = int.Parse(usernumber);  // create a variabler to hold a number and.


                    if (usernumber2 < number)
                        Console.WriteLine("You picked a number too low");

                    if (usernumber2 > number)
                        Console.WriteLine("You picked a number too high");

                    if (usernumber2 == number)
                    {
                        Console.WriteLine("Wow  that was amazing how did you know");
                        didusematchournumber = true;
                    }
                } while (didusematchournumber == false);

            }
            else
                Console.WriteLine("Thank you anyway. Talk to you next time " + UserName);



            //int ComputerNumber = new Random().Next(11);

            //Console.WriteLine("Hello I picked " + ComputerNumber);
            Console.WriteLine("thgx  bye");
            Console.ReadKey();

        }
    }
}
