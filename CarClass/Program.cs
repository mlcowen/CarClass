using System;

namespace CarClass
{
    class Program
    {
        static void Main(string[] args)
        {


            /*Create a program with a Car class that has a gas level, a method to add gas that takes a single
            float value and adds this amount to the current gas level, a fill up method that fills the car up to its max value of 13.0 and returns how much gas was added.The class should have a constructor that fills the car with a random amount of gas to start up to 13.0.
            */

            // create Car class
            // generate randomAmountOfGas to start with
            // create 2 methods
            //method addGas (but not completely filling tank: 
            // you need to add currentgas amount plus whatever number is passed in, but remember you can only hold a total of 13.0 gallons
            // method fillGasCompletely
            // you to to get current gas - subtract maxTanksize (13 gallons) return the result as that is how much gas you can hold

            Random rnd = new Random();
            float randomGasLevel = rnd.Next(0, 14);
            Console.WriteLine($"The current gas level is {randomGasLevel}.");
            float currentGasLevel = randomGasLevel;


            float getSomeGas = Car.addGas(currentGasLevel, 5.0f);

            Console.WriteLine("Adding some gas:");
            Console.WriteLine($"The current gas level is {getSomeGas}.");

            float fullTank = Car.fillGasTank(currentGasLevel);
            Console.WriteLine($"The amount of gas added was {fullTank}.");


            Console.ReadLine();


        }
    }

    public class Car
    {
        public static float addGas(float currentGasLevel, float amountToAdd)
        {
            //Do some math to a have method to add gas that takes a single float value and adds this amount to the current gas level, a fill up method that fills the car up to its max value of 13.0 and returns how much gas was added.
            float newGasLevel = (currentGasLevel + amountToAdd);

            if (currentGasLevel + amountToAdd < 13.0f)
            {
                newGasLevel = currentGasLevel + amountToAdd;
                return newGasLevel;
            }

            else
            {
                Console.WriteLine("That filled up the tank!");
                return newGasLevel = 13.0f; //returns a full tank since currentGasLevel plus amountToAdd is greater than capacity of tank
            }

        }
        // method fillGasCompletely
        // you to to get current gas - subtract max tank size (13 gallons) return the result as that is how much gas you can hold
        public static float fillGasTank(float currentGasLevel)
        {
            float amtOfGasAdded = (13.0f - currentGasLevel);
            return amtOfGasAdded;

        }


    }
    
}
