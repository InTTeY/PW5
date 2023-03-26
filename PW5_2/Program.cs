using System;
namespace PW5_1
{
    class program
    {
        static void Main()
        {
            List<IHello> Greeting = new List<IHello>();
            Greeting.Add(new RUS());
            Greeting.Add(new AZE());
            Greeting.Add(new HRV());
            Greeting.Add(new FRA());
            Greeting.Add(new KAZ());

            foreach (IHello language in Greeting)
            {
                language.SayHello();
            }

            Console.ReadKey(true);
        }
    }
    interface IHello
    {
        void SayHello();
    }
    class RUS : IHello
    {
        public void SayHello()
        {
            Console.WriteLine("Привет");
        }
    }
    class AZE : IHello
    {
        public void SayHello()
        {
            Console.WriteLine("Salam");
        }
    }
    class HRV : IHello
    {
        public void SayHello()
        {
            Console.WriteLine("Bok.");
        }

    }
    class FRA : IHello
    {
        public void SayHello()
        {
            Console.WriteLine("Salut");
        }
    }
    class KAZ : IHello
    {
        public void SayHello()
        {
            Console.WriteLine("Сaлем");
        }
    }
}