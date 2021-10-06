using System;

namespace DontPanicNCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab mitu 'n' tahte on
            //lauses "dont panic"

            string dontpanic = "Don't panic".ToUpper();

            int counter = 0;

            foreach (char character in dontpanic)
            {
                if(character == 'N')
                {
                    counter = counter + 1;
                }
                
                //counter++;
            }
            Console.WriteLine($"{dontpanic} on {counter} N tahte.");
        }
    }
}
