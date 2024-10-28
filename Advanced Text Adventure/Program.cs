using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Advanced_Text_Adventure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name");
            string playerName = (Console.ReadLine());
            Console.WriteLine("Your name is " + playerName + "?");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Alrighty then. I'm Jermy, creator of these little guys,")
        }
    }
}
