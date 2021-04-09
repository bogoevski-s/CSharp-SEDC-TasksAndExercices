using System;

namespace Homework_Class_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Car[] cars = new Car[4] {
                new Car("Ferrari", 290),
                new Car("Mercedes", 305),
                new Car("Redbull", 300),
                new Car("Mclaren", 298),
            };

            Driver[] drivers = new Driver[4]
            {
                new Driver("Hamilton",9),
                new Driver("Verstapen",10),
                new Driver("Lecler",8),
                new Driver("Norris",10),
            };
            /*
            Console.WriteLine("Please select first car from 1-4 ");

            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {cars[i].Model}");
            }
            string firstCarSelection = Console.ReadLine();
            bool firstCarSelectionParsed = int.TryParse(firstCarSelection, out int firstCarNo);
            if (!firstCarSelectionParsed || firstCarNo > 4 || firstCarNo < 1)
            {
                Console.WriteLine("\nWrong input!!\n");
            }
            else
            {
                Console.WriteLine($"You select {cars[firstCarNo - 1].Model}\n");
            }

            Console.WriteLine("Please select driver from 1-4 ");
            for (int i = 0; i < drivers.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {drivers[i].Name}");
            }
            string firstDriverSelection = Console.ReadLine();
            bool firstDriverSelectionParsed = int.TryParse(firstDriverSelection, out int firstDriverNo);
            if (!firstDriverSelectionParsed || firstDriverNo > 4 || firstDriverNo < 1)
            {
                Console.WriteLine("\nWrong input!!\n");
            }
            else
            {
                Console.WriteLine($"You select {drivers[firstDriverNo - 1].Name}\n");
            }

            Console.WriteLine("Please select second car from 1-4 ");

            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {cars[i].Model}");
            }
            string secondCarSelection = Console.ReadLine();
            bool secondCarSelectionParsed = int.TryParse(secondCarSelection, out int secondCarNo);
            if (!secondCarSelectionParsed || secondCarNo > 4 || secondCarNo < 1)
            {
                Console.WriteLine("\nWrong input!!\n");
            }
            else
            {
                Console.WriteLine($"You select {cars[secondCarNo - 1].Model}\n");
            }

            Console.WriteLine("Please select second driver for second car from 1-4 ");
            for (int i = 0; i < drivers.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {drivers[i].Name}");
            }
            string secondDriverSelection = Console.ReadLine();
            bool secondDriverSelectionParsed = int.TryParse(secondDriverSelection, out int secondDriverNo);
            if (!secondDriverSelectionParsed || secondDriverNo > 4 || secondDriverNo < 1)
            {
                Console.WriteLine("\nWrong input!!\n");
            }
            else
            {
                Console.WriteLine($"You select {drivers[secondDriverNo - 1].Name}\n");
            }

            Car playerOneCar = cars[firstCarNo - 1];
            playerOneCar.SetDriver(drivers[firstDriverNo - 1]);

            Car PlayerTwoCar = cars[secondCarNo - 1];
            PlayerTwoCar.SetDriver(drivers[secondDriverNo - 1]);

            RaceCar(playerOneCar, PlayerTwoCar);
            */

            int firstCar = CarSelect(cars);
            int firstDriver = DriverSelect(drivers);
            Car firstRaceCar = cars[firstCar];
            Driver firstDriverCar = drivers[firstDriver];
            firstRaceCar.SetDriver(firstDriverCar);

            int secondCar = CarSelect(cars);
            int secondDriver = DriverSelect(drivers);
            Car secondRaceCar = cars[secondCar];
            Driver secondDrvierCar = drivers[secondDriver];
            secondRaceCar.SetDriver(secondDrvierCar);

            Race(firstRaceCar, secondRaceCar);

        }
        
        static int CarSelect(Car[] cars)
        {
            Console.WriteLine("Please select first car from 1-4 ");

            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {cars[i].Model}");
            }
            string firstCarSelection = Console.ReadLine();
            bool firstCarSelectionParsed = int.TryParse(firstCarSelection, out int firstCarNo);
            if (!firstCarSelectionParsed || firstCarNo > 4 || firstCarNo < 1)
            {
                Console.WriteLine("\nWrong input!!\n");
                return 0;
            }
            else
            {
                Console.WriteLine($"You select {cars[firstCarNo - 1].Model}\n");
                return firstCarNo - 1;
            }
        }
        
        static int DriverSelect(Driver[] drivers)
        {
            Console.WriteLine("Please select driver from 1-4 ");
            for (int i = 0; i < drivers.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {drivers[i].Name}");
            }
            string secondDriverSelection = Console.ReadLine();
            bool secondDriverSelectionParsed = int.TryParse(secondDriverSelection, out int secondDriverNo);
            if (!secondDriverSelectionParsed || secondDriverNo > 4 || secondDriverNo < 1)
            {
                Console.WriteLine("\nWrong input!!\n");
                return 0;
            }
            else
            {
                Console.WriteLine($"You select {drivers[secondDriverNo - 1].Name}\n");
                return secondDriverNo - 1;
            }
        }
        
        static Car Race(Car car1, Car car2)
        {
            if(car1.CalculateSpeed() > car2.CalculateSpeed())
            {
                Console.WriteLine($"\nThe winner is {car1.Driver.Name} with {car1.Model} --> speed: {car1.CalculateSpeed()}\n");
                return car1;
            }
            else if(car2.CalculateSpeed() > car1.CalculateSpeed())
            {
                Console.WriteLine($"\nThe winner is {car2.Driver.Name} with {car2.Model} --> speed: {car1.CalculateSpeed()}\n");
                return car2;
            }
            return null;
        }
    }
}
