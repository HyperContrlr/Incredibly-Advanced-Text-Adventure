using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Advanced_Text_Adventure
{
    [Serializable]
    internal partial class Program
    {
        public static petBit MyBit;
        static void Main(string[] args)
        {
            MyBit = genericBit;
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
            else if (playerName == "Polaris")
            {
                Console.WriteLine("I hope you're less sadistic than the Polaris I know.");
            }
            else if (playerName == "Jermy")
            {
                 Console.WriteLine("Well, that'll be confusing.");
            }
            else if (playerName == "Xenon")
            {
                Console.WriteLine("Huh, I have a friend named Xenon, he's pretty chill");
            }
            else if (playerName == "Oatis")
            {
                Console.WriteLine("I think you'd like my friend, Xenon");
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
                MyBit.name = Console.ReadLine();
                if (MyBit.name == ("Byte"))
                {
                    MyBit = bitOne;
                    Console.WriteLine("Ah Byte, the boy. You know, Byte wasn't the first bit ever made,");
                    System.Threading.Thread.Sleep(3000);
                    Console.WriteLine("But he was the only bit to not receive Purge Protocol");
                    System.Threading.Thread.Sleep(2000);
                    break;
                }
                else if ("Michael" == MyBit.name)
                {
                    MyBit = bitTwo;
                    Console.WriteLine("Michael, eh? He's a bit who survived the Purge Protocol.");
                    System.Threading.Thread.Sleep(3000);
                    Console.WriteLine("Easier to take care of compared to the others,");
                    System.Threading.Thread.Sleep(2000);
                    Console.WriteLine("But, harder to make trust you. Kind of sad, really.");
                    System.Threading.Thread.Sleep(1000);
                    break;
                }
                else if ("Bit byte" == MyBit.name)
                {
                    MyBit = bitThree;
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
            Console.WriteLine("I have to go, so I entrust " + MyBit.name + " to you.");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Good luck");
            System.Threading.Thread.Sleep(1000);

        }
    }
}
