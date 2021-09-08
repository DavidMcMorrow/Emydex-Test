using System;

namespace FarmSystem.Test1
{
    public class Hen : Animal
    {
        
        public void Talk()
        {
            Console.WriteLine("Hen say CLUCKAAAAAWWWWK!");
        }

        public void Run()
        {
            Console.WriteLine("Hen is running");
        }

        public void EnteredFarm()
        {
            Console.WriteLine("Hen has entered the farm");
        }

        public void LeavingFarm()
        {
            Console.WriteLine("Hen has left the farm");
        }
    }
}