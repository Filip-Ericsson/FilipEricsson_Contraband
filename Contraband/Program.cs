using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contraband
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Console.WriteLine("Hur många bilar? Skriv ett nummer");
            string userInput = "";
            int amountOfCars = 0;
            bool correctInput = false;
            
            Random generator = new Random();
            
            while (correctInput == false)
            {
                userInput = Console.ReadLine();
                correctInput = userInput.All(char.IsDigit);


                if (correctInput == true)
                {
                    amountOfCars = int.Parse(userInput);

                }
                else
                {
                    Console.WriteLine("Felaktig input, måste vara ett tal och större än 0!");
                }

            }
            Dictionary<string, Car> cars = new Dictionary<string, Car>();
            for (int i = 0; i < amountOfCars; i++)
            {
                
                if (generator.Next(0, 1) ==1)
                {
                    cars.Add(i.ToString(), new CleanCar());
                }
                else
                {
                    cars.Add(i.ToString(), new ContrabandCar());
                }

            }
            for (int i = 0; i < amountOfCars; i++)
            {
                if (car.Examine(cars[Console.ReadLine()].contrabandAmount)== true)
                {
                    Console.WriteLine("Has contraband ");
                }
                else
                {
                    Console.WriteLine("all good");
                }
                
            }
            

           
            Console.ReadLine();
        }
    }
}
