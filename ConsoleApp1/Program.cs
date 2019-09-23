using System;

namespace ConsoleApp1
{
    /// <summary>
    /// Console app til at interagere med en User
    /// </summary>
    class Program
    {
        /// <summary>
        /// Main metoden
        /// </summary>
        static void Main(string[] args)
        {
            // ny User instans
            User user = new User();
            // spørg til Users navn
            Console.WriteLine("Hvad hedder du?");
            // indlæs Users navn
            user.Name = Console.ReadLine();
            //spørg til Users fødselsdato
            Console.WriteLine("Hvornår er du født?");
            // indlæs og sat Users fødselsdato fra consolen
            user.Birthdate = user.GetBirthDate(Console.ReadLine());
            // hvis brugeren ikke indtaster dato i dette format: "01-02-1234", så siger vi noget... pænt til vedkommende
            if (user.GetAge() == 0)
                Console.WriteLine("Du er en idiot");
            // ellers takker vi pænt og viser Users alder
            else
                Console.WriteLine("Tak, " + user.Name + ". Du er " + user.GetAge() + " år gammel.");
        }
    }
}
