using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Random rnd = new Random();
            int min = 0;
            int max = 100;

            Console.WriteLine("Witaj w grze\n");
            var randomNumber = rnd.Next(min, max);
            //Console.WriteLine(randomNumber);

            checkNumber(randomNumber);


        }

        private static int checkNumber(int randomNumber)
        {
            int numberOfTries = 1;
            while (true)
            {
                Console.WriteLine("\n\n-----Próba nr " + numberOfTries + ". Odgadnij liczbę: -----");
                var yourNumber = GetNumber();

                if (yourNumber == randomNumber)
                {
                    Console.WriteLine("\nBrawo !!! Ogadłeś liczbę w " + numberOfTries + " próbie.");
                }
                else if (yourNumber < randomNumber)
                {
                    Console.WriteLine("\nPodałeś zbyt małą liczbę. Spróbuj ponownie.");
                    numberOfTries++;
                    continue;
                }
                else if(yourNumber > randomNumber) 
                {
                    Console.WriteLine("\nPodałeś zbyt wysoką liczbę. Spróbuj ponownie.");
                    numberOfTries++;
                    continue;
                }
                return numberOfTries;
    
            }

        }

        private static int GetNumber()
        {
            while (true)
            {
                if(!int.TryParse(Console.ReadLine(), out int yourNumber) || yourNumber < 0 || yourNumber > 100)
                {
                    Console.WriteLine("Podaj liczbę całkowitą z zakresu 1-100 !");
                    continue;
                }

                return yourNumber;
                

            }
        }
    }
}
