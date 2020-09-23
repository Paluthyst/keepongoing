using System;
using System.Runtime.CompilerServices;

namespace keepongoing
{
    class Program
    {
        static void Main(string[] args)
        {
            bool pumpItUp = true;
            int numberOfPumps = 0;
            

            while(pumpItUp){

                Console.WriteLine("You've got to pump it up! don't you know pump it up?");
                numberOfPumps ++;
                Console.Write("Wanna keep pumping it up? Yes or No?");
                pumpItUp = getInput();
                
            }
        }
        public static bool getInput()
        {
            string keepPumping = Console.ReadLine();
            bool pumpItUp = true;

            if(keepPumping == "No" || keepPumping == "no" || keepPumping == "n" || keepPumping == "N")
            {
                Console.WriteLine("You've stopped pumping it up");
                
                pumpItUp = false;
            }

            return pumpItUp;
        }
    }
}
