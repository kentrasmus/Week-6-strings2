using System;

namespace HOLCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab mitu 'h','o'
            //ja 'l' tahte on lauses "hello, world!"

            string helloworld = "Hello, World";

            int counter1 = 0;
            int counter2 = 0;
            int counter3 = 0;
            foreach (char character in helloworld)
            {
                if (character == 'h')
                {
                    counter1++;
                }

                //counter++; counter = counter + 1;
            }

            foreach (char character in helloworld)
            {
                if (character == 'o')
                {
                    counter2++;
                }

                //counter++;
            }

            foreach (char character in helloworld)
            {
                if (character == 'l')
                {
                    counter3++;
                }

                //counter++;
            }
            Console.WriteLine($"{helloworld} on {counter1} h tahte, {counter2} o tahte, {counter3} l tahte.");
        }
    }
}
