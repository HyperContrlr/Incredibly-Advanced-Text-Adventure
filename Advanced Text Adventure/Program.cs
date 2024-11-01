using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Advanced_Text_Adventure
{
    internal partial class Program
    {
        public static string MyBit;
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name");
            string playerName = Console.ReadLine();                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           //hehehaha
            if (playerName == "IRS")
            {
                Console.WriteLine("You're not supposed to be here");
                Environment.Exit(0);
            }
            else if (playerName == "irs")
            {
                Console.WriteLine("You're not supposed to be here");
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
                MyBit = Console.ReadLine();
                if (("Byte") == MyBit)
                {
                    Console.WriteLine("Ah Byte, the boy. You know, Byte wasn't the first bit ever made,");
                    System.Threading.Thread.Sleep(3000);
                    Console.WriteLine("But he was the only bit to not receive Purge Protocol");
                    System.Threading.Thread.Sleep(2000);
                    break;
                }
                else if ("Michael" == MyBit)
                {
                    Console.WriteLine("Michael, eh? He's a bit who survived the Purge Protocol.");
                    System.Threading.Thread.Sleep(3000);
                    Console.WriteLine("Easier to take care of compared to the others,");
                    System.Threading.Thread.Sleep(2000);
                    Console.WriteLine("But, harder to make trust you. Kind of sad, really.");
                    System.Threading.Thread.Sleep(1000);
                    break;
                }
                else if ("BitByte" == MyBit)
                {
                    Console.WriteLine("Oh? BitByte? Interesting...");
                    System.Threading.Thread.Sleep(1500);
                    Console.WriteLine("I never truly expected it, but I guess he does have some appeal.");
                    System.Threading.Thread.Sleep(2000);
                    Console.WriteLine("He's a lot easier to make love you, but he's a bit harder to take care of.");
                    System.Threading.Thread.Sleep(2500);
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
            Console.WriteLine("But now, you're on your own.");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("I have to go, so I entrust " + MyBit + " to you.");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Good luck");
            System.Threading.Thread.Sleep(1000);
        }
    }
}
