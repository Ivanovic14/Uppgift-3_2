using System;
using System.ComponentModel.Design;
using System.Xml;

namespace Uppgift_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej! Vi försöker anställa nya arbetare, men har vissa krav!");
            Console.WriteLine("Har du gått ur gymnasiet? Skriv ett " + "j" + " för ett ja, och ett " + "n" + " för ett nej...");

            string janej = Console.ReadLine();
            char svar = char.Parse(janej);

            switch (svar)//Början på kravcheck
            {
                case 'j'://Ifall usern svarar med ett j, alltå ja, så händer allt detta fram till rad 32
                    Console.WriteLine("Okej, du är välkommen in.");
                    Console.WriteLine("Men hur gammal är du?");
                    string ålder = Console.ReadLine();
                    int age =int.Parse(ålder);
                    if (age < 22) //Vad som ska stå om usern är under 22.
                    {
                        Console.WriteLine("Tyvärr, men du är för ung, kom tillbaka när du är 22");//Konsekvens till att usern är yngre än 22
                    }
                    else//Om usern är äldre än 22, så ska detta hända
                    {
                        Console.WriteLine("Vi vill gärna anställa dig.");//Det som sägs om usern är över 22 år gammal.
                    }
                    break;//Slut på villkorkollen.

                case 'n'://Vad som händer ifall usern matar in bokstaven n, som står för nej.
                    Console.WriteLine("Vi letar tyvärr efter annann personal just nu.");
                    break;
            }

        }
    }
}