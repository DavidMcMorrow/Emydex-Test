using System;

namespace FarmSystem.Test1
{
    public class Horse : Animal
    {
        
        public void Talk()
        {
            Console.WriteLine("Horse says neigh!");
        }

        public void Run()
        {
            Console.WriteLine("Horse is running");
        }

        public void EnteredFarm()
        {
            Console.WriteLine("Horse has entered the farm");
        }

        public void LeavingFarm()
        {
            Console.WriteLine("Horse has left the farm");
        }
        
    }
}