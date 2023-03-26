using System;

namespace PW5_4
{
    interface IShare
    {
        void Draw(int size);
    }

    class VerticalLine : IShare
    {
        public void Draw(int size)
        {
            Console.WriteLine($"Нарисована вертикальная линия, размером {size}*");
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("*");
            }
        }
    }

    class HorizontalLine : IShare
    {
        public void Draw(int size)
        {
            Console.WriteLine($"Нарисована горизонтальная линия, размером {size}*");
            for (int i = 0; i < size; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    class Square : IShare
    {
        public void Draw(int size)
        {
            Console.WriteLine($"Нарисован квадрат, размером {size}* на {size}*");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
    class program
    {
        static void Main()
        {
            Console.Write("Введите размер элемента(в *): ");
            int size = Convert.ToInt32(Console.ReadLine());
            IShare verticalline = new VerticalLine();
            verticalline.Draw(size);
            IShare horizontalline = new HorizontalLine();
            horizontalline.Draw(size);
            IShare square = new Square();
            square.Draw(size);
        }
    }
}