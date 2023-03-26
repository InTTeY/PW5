using System;
namespace PW5_1
{
    class program
    {
        static void PetAnimal(IAnimal animal)
        {
            Console.WriteLine("Гладим питомца, а он издаёт звук: ");
            animal.Voice();
        }
        static void Main()
        {
            List<IAnimal> myAnimals = new List<IAnimal>();
            myAnimals.Add(new Dog());
            myAnimals.Add(new Cat());
            myAnimals.Add(new Owl());
            myAnimals.Add(new Duck());
            myAnimals.Add(new Mouse());

            foreach (IAnimal animal in myAnimals)
            {
                PetAnimal(animal);
            }

            Console.ReadKey(true);
        }
    }
    interface IAnimal
    {
        void Voice();
    }
    class Dog : IAnimal 
    { 
        public void Voice() 
        { 
            Console.WriteLine("Гав!"); 
        } 
    }
    class Cat : IAnimal 
    { 
        public void Voice() 
        { 
            Console.WriteLine("Мяу!"); 
        } 
    }
    class Owl : IAnimal
    {
        private int GetCurrentTime()
        {
            try { return Convert.ToInt32(File.ReadAllText("current_time.txt")); }
            catch { return 0; }
        }
        public void Voice()
        {
            int currentTime = GetCurrentTime();
            if ((currentTime >= 8) && (currentTime <= 20))
            {
                Console.WriteLine("Тисе, я спю");
            }
            else { Console.WriteLine("Ух! Ух! Ух!"); }
        }

    }
    class Duck : IAnimal
    {
        public void Voice()
        {
            Console.WriteLine("Кря-кря!");
        }
    }
    class Mouse : IAnimal
    {
        public void Voice()
        {
            Console.WriteLine("Пи-пи-пи");
        }
    }
}