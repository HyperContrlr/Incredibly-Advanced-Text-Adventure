using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Advanced_Text_Adventure
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name");
            string playerName = Console.ReadLine();                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           //hehehaha
            if (playerName == "IRS")
            {
                Console.WriteLine("You're not supposed to be here");
                System.Threading.Thread.Sleep(3000);
                Environment.Exit(0);
            }
            else if (playerName == "irs")
            {
                Console.WriteLine("You're not supposed to be here");
                System.Threading.Thread.Sleep(3000);
                Environment.Exit(0);
            }
            else if (playerName == "Jermy")
            {
                 Console.WriteLine("Well, that'll be confusing.");
            }
            else
            {
                Console.WriteLine("Your name is " + playerName + "?");
            }
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Alrighty then, " + playerName + ". I'm Jermy, creator of these little guys, and I'm entrusting one to you." );
            System.Threading.Thread.Sleep(5000);

            while (true)
            {
                Console.WriteLine("Take your pick:");
                Console.WriteLine(bitOne.name + ", " + bitTwo.name + ", " + bitThree.name);
                string SelectedBit = Console.ReadLine();
                if (("Byte") == SelectedBit)
                {
                    Console.WriteLine("Ah Byte, the boy. You know, Byte wasn't the first bit ever made,");
                    System.Threading.Thread.Sleep(3000);
                    Console.WriteLine("But he was the lone survivior of the Purge Protocol");
                    System.Threading.Thread.Sleep(2000);
                    break;
                }
                else if ("Michael" == SelectedBit)
                {
                    Console.WriteLine("Placeholder");
                    break;
                }
                else if ("BitByte" == SelectedBit)
                {
                    Console.WriteLine("Placeholder");
                    break;
                }
                else
                {
                    Console.WriteLine("... did you misspell something?");
                    System.Threading.Thread.Sleep(1000);
                }
            }
            Console.WriteLine("Good Choice!");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("But now, you're on your own. ");

        }
        
    }
}
