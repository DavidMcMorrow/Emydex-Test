using System;

namespace FarmSystem.Test1
{
    public class Sheep : Animal
    {
       
        public void Talk()
        {
            Console.WriteLine("Sheep says baa!");
        }
        
        public void Run()
        {
            Console.WriteLine("Sheep is running");
        }

        public void EnteredFarm()
        {
            Console.WriteLine("Sheep has entered the farm");
        }

        public void LeavingFarm()
        {
            Console.WriteLine("Sheep has left the farm");
        }
    }

}