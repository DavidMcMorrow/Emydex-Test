using System;

namespace FarmSystem.Test1
{
    public class Animal
    {
        
        private string _id;
        private int _noOfLegs;

        public Animal()
        {
            _id = Guid.NewGuid().ToString();
            _noOfLegs = 4;
        }


        public string Id
        {
            get { return _id; }
            set
            {
                _id = value;
            }
        }

        public int NoOfLegs
        {
            get
            {
                return _noOfLegs;
            }
            set
            {
                _noOfLegs = 4;
            }
        }

        public void EnteredFarm(object animal)
        {
            Cow cow = new Cow();
            Hen hen = new Hen();
            Horse horse = new Horse();
            Sheep sheep = new Sheep();

            if (animal.GetType() == typeof(Cow))
            {
                cow.EnteredFarm();
            }
            else if (animal.GetType() == typeof(Hen))
            {
                hen.EnteredFarm();
            }
            else if (animal.GetType() == typeof(Horse))
            {
                horse.EnteredFarm();
            }
            else
            {
                sheep.EnteredFarm();
            }
        }

        public void talk(object animal)
        {
            Cow cow = new Cow();
            Hen hen = new Hen();
            Horse horse = new Horse();
            Sheep sheep = new Sheep();

            if (animal.GetType() == typeof(Cow))
            {
                cow.Talk();
            }
            else if (animal.GetType() == typeof(Hen))
            {
                hen.Talk();
            }
            else if (animal.GetType() == typeof(Horse))
            {
                horse.Talk();
            }
            else
            {
                sheep.Talk();
            }
        }

        public void leave(object animal)
        {
            Cow cow = new Cow();
            Hen hen = new Hen();
            Horse horse = new Horse();
            Sheep sheep = new Sheep();

            if (animal.GetType() == typeof(Cow))
            {
                cow.LeavingFarm();
            }
            else if (animal.GetType() == typeof(Hen))
            {
                hen.LeavingFarm();
            }
            else if (animal.GetType() == typeof(Horse))
            {
                horse.LeavingFarm();
            }
            else
            {
                sheep.LeavingFarm();
            }
        }
    }
}