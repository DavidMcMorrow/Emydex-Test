﻿using System;

namespace FarmSystem.Test1
{
    internal class Program
    {
       
        private static void Main(string[] args)
        {
            Animal[] animalsOnTheFarm = new Animal[4];
            Excercise1(animalsOnTheFarm);
            Excercise2(animalsOnTheFarm);
            Excercise3(animalsOnTheFarm);
            Excercise4(animalsOnTheFarm);
            Console.ReadKey();
        }

/************************************************************************************************************
Exercise 1 : Apply OOP concepts (abstraction and encapsulation) to the classes 
modify the code to get the output below
Cow has entered the farm
Hen has entered the farm
Horse has entered the farm
Sheep has entered the farm
***************************************************************************************************************/
        private static void Excercise1(Animal[] animalsOnTheFarm)
        {
            Console.WriteLine("Exercise 1 : Press any key when it is time to open the Farm to animals");
            Console.ReadKey();
            var farm = new EmydexFarmSystem();

            Cow cow = new Cow();
            farm.Enter(cow);
            animalsOnTheFarm[0] = cow;

            Hen hen = new Hen();
            farm.Enter(hen);
            animalsOnTheFarm[1] = hen;

            Horse horse = new Horse();
            farm.Enter(horse);
            animalsOnTheFarm[2] = horse;

            Sheep sheep = new Sheep();
            farm.Enter(sheep);
            animalsOnTheFarm[3] = sheep;

            Console.ReadKey();
            
        }

/***************************************************************************************************************
 Test Excercise 2
 If you have completed the first test excercise, you can continue with the second one
 Modify the program and EmydexFarmSystem.MakeNoise() method to get the below output
 Expected Test 2 Program Output

 Exercise 2 : Press any key to scare the animals in the farm
    Cow has entered the farm
    Hen has entered the farm
    Horse has entered the farm
    Sheep has entered the farm
    Cow says Moo!
    Hen says CLUCKAAAAAWWWWK!
    Horse says Neigh!
    Sheep says baa!
 *****************************************************************************************************************/
        private static void Excercise2(Animal[] animalsOnTheFarm)
        {
            //TODO : Apply OOP concepts and modify the code below to get the required output 
            Console.WriteLine("Exercise 2 : Press any key to scare the animals in the farm");
            Console.ReadKey();
            var farm = new EmydexFarmSystem();

            Cow cow = new Cow();
            farm.Enter(cow);
            animalsOnTheFarm[0] = cow;

            Hen hen = new Hen();
            farm.Enter(hen);
            animalsOnTheFarm[1] = hen;

            Horse horse = new Horse();
            farm.Enter(horse);
            animalsOnTheFarm[2] = horse;

            Sheep sheep = new Sheep();
            farm.Enter(sheep);
            animalsOnTheFarm[3] = sheep;
            
            farm.MakeNoise(animalsOnTheFarm);
            Console.ReadKey();
        }

/*****************************************************************************************************************
Test Excercise 3
If you have completed the previous test excercise, you can continue with this one 
The project includes an interface IMilkableAnimal. Make use of this interface to implement on the relevant classes
so that calling the EmydexFarmSystem.MilkAnimals() method to get the below output

Expected Test 3 Program Output

Exercise 3 : Press any key when it is time to milk animals
Cow has entered the farm
Hen has entered the farm
Horse has entered the farm
Sheep has entered the farm
Cow was milked!
************************************************************************************************************/
        private static void Excercise3(Animal[] animalsOnTheFarm)
        {
            //TODO : Apply OOP concepts and modify the code below to get the required output 
            Console.WriteLine("Exercise 3 : Press any key when it is time to milk animals");
            Console.ReadKey();
            var farm = new EmydexFarmSystem();

            Cow cow = new Cow();
            farm.Enter(cow);
            animalsOnTheFarm[0] = cow;

            Hen hen = new Hen();
            farm.Enter(hen);
            animalsOnTheFarm[1] = hen;

            Horse horse = new Horse();
            farm.Enter(horse);
            animalsOnTheFarm[2] = horse;

            Sheep sheep = new Sheep();
            farm.Enter(sheep);
            animalsOnTheFarm[3] = sheep;

            farm.MilkAnimals();
            Console.ReadKey();
        }

/****************************************************************************************************
Test Excercise 4
Modify the EmydexFarmSystem.ReleaseAllAnimals() so that all animals are released (simply clear the collection )
Expose an event on the FarmSystem FarmEmpty which is invoked once all the animals are released
Subscribe to that event in the main to get the expected output

Expected Test 4 Program Output

Exercise 4: Press any key to free all animals
Cow has entered the farm
Hen has entered the farm
Horse has entered the farm
Sheep has entered the farm
Cow has left the farm
Hen has left the farm
Horse has left the farm
Sheep has left the farm
Emydex Farm is now empty
********************************************************************************************************************/
        private static void Excercise4(Animal[] animalsOnTheFarm)
        {
            //TODO : Apply OOP concepts and modify the code below to get the required output 
            Console.WriteLine("Exercise 4: Press any key to free all animals");
            Console.ReadKey();

            var farm = new EmydexFarmSystem();

            Cow cow = new Cow();
            farm.Enter(cow);
            animalsOnTheFarm[0] = cow;

            Hen hen = new Hen();
            farm.Enter(hen);
            animalsOnTheFarm[1] = hen;

            Horse horse = new Horse();
            farm.Enter(horse);
            animalsOnTheFarm[2] = horse;

            Sheep sheep = new Sheep();
            farm.Enter(sheep);
            animalsOnTheFarm[3] = sheep;

            farm.EventCompleted += EventCompleted; // register with an event
            farm.ReleaseAllAnimals(animalsOnTheFarm);

            Console.ReadKey();
        }

        public static void EventCompleted()
        {
            Console.WriteLine("Emydex Farm is now empty");
        }
    }
}