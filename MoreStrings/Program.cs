using System;

namespace MoreStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            // programm kusib kasutajal sisestada eesnime ja perekonnanime 
            //programm tervitab kasutajat kasutades tema imitsiaale
            //initsiaalid lõpevad punktiga
            //--> Harry Potter --> H. P
            Console.WriteLine("Palun sisesta oma nimi:");
            string username = Console.ReadLine();

            Console.WriteLine("Palun sisesta oma perekonna nimi:");
            string usernamelast = Console.ReadLine();

            Console.WriteLine($"Hello, {username[0]}. {usernamelast[0]}.! ");

        }
    }
}
