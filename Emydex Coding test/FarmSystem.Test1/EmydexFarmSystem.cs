using System;

namespace FarmSystem.Test1
{
    public delegate void Notify();


    public class EmydexFarmSystem
    {
        
        //TEST 1
        public void Enter(object animal)
        {
            //TODO Modify the code so that we can display the type of animal (cow, sheep etc) 
            //Hold all the animals so it is available for future activities
            
            Animal animalClass = new Animal();

            animalClass.EnteredFarm(animal);
        }
     
        //TEST 2
        public void MakeNoise(Animal[] animalsOnTheFarm)
        {
            //Test 2 : Modify this method to make the animals talk
            Animal animalClass = new Animal();
            for (int i = 0; i < animalsOnTheFarm.Length; i++)
            {
                animalClass.talk(animalsOnTheFarm[i]);
            }
            
        }

        //TEST 3
        public void MilkAnimals()
        {
            Animal animalClass = new Animal();
            IMilkableAnimal obj = new Cow();
            obj.ProduceMilk();
        }

        public event Notify EventCompleted;

        //TEST 4
        public void ReleaseAllAnimals(Animal[] animalsOnTheFarm)
        {
            Animal animalClass = new Animal();
            for (int i = 0; i < animalsOnTheFarm.Length; i++)
            {
                animalClass.leave(animalsOnTheFarm[i]);
                animalsOnTheFarm[i] = null;
            }
           OnEventCompleted();
        }

        protected virtual void OnEventCompleted()
        {
            EventCompleted?.Invoke();
        }
    }
}