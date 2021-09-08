using System;

namespace FarmSystem.Test1
{
    class Cow : Animal, IMilkableAnimal 
    {
        

        public void Talk()
        {
            Console.WriteLine("Cow says Moo!");
        }

        public void Walk()
        {
            Console.WriteLine("Cow is walking");
        }

        public void ProduceMilk()
        {
            Console.WriteLine("Cow produced milk");
        }

        public void Run()
        {
            Console.WriteLine("Cow is running");
        }

        public void EnteredFarm()
        {
            Console.WriteLine("Cow has entered the farm");
        }

        public void LeavingFarm()
        {
            Console.WriteLine("Cow has left the farm");
        }

    }
}