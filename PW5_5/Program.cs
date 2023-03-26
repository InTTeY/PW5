using System;
namespace PW5_5
{
    interface IUseable
    {
        void Use();
    }

    class MagicPotion : IUseable
    {
        private string Name;
        public int MagicPoint;
        public MagicPotion(string name, int magicPoint)
        {
            Name = name;
            MagicPoint = magicPoint;
        }
        public void Use()
        {
            Console.WriteLine($"Использовано {Name} x1, оно прибавило {MagicPoint} очков маны вашему персонажу");
        }
    }

    class MagicSpell : IUseable
    {
        private string Name;
        public int MagicCost;
        private string Effect;
        private int MagicDamage;
        public MagicSpell(string name, int magicCost, string effect, int magicDamage)
        {
            Name = name;
            MagicCost = magicCost;
            Effect = effect;
            MagicDamage = magicDamage;
        }
        public void Use()
        {
            Console.Write($" использует заклинание {Name}, затратив {MagicCost} единиц маны. Эффект от заклинания - {Effect}, нанёс противнику {MagicDamage} единиц урона.");
        }
        public void ErrorUse()
        {
            Console.Write($" пытается использовать заклинание {Name}. ");
        }
    }

    class Characters
    {
        public string Name;
        public int MagicPoint;

        public Characters(string name, int magicPoint)
        {
            Name = name;
            MagicPoint = magicPoint;
        }
        public void CastMagicSpell(MagicSpell MagicSpell, MagicPotion MagicPotion)
        {
            if (MagicPoint >= MagicSpell.MagicCost)
            {
                Console.Write($"Персонаж {Name}");
                MagicSpell.Use();
                Console.WriteLine();
                MagicPoint -= MagicSpell.MagicCost;
            }
            else
            {
                while (MagicPoint < MagicSpell.MagicCost)
                {
                    Console.Write($"Персонаж {Name}");
                    MagicSpell.ErrorUse();
                    int LackMagicPoint = MagicSpell.MagicCost - MagicPoint;
                    Console.Write($"Не хватает {LackMagicPoint} единиц маны. Выпейти зелье!");
                    Console.WriteLine();
                    MagicPotion.Use();
                    Console.WriteLine();
                    MagicPoint = MagicPoint + MagicPotion.MagicPoint;
                }
                Console.Write($"Персонаж {Name}");
                MagicSpell.Use();
                Console.WriteLine();
                MagicPoint -= MagicSpell.MagicCost;
            }
        }
    }

    class Program
    {
        static void Main()
        {
            IUseable Firebolt = new MagicSpell("Огненная стрела", 41, "Выстрел сгустка огня", 25);
            IUseable Fireball = new MagicSpell("Огненный шар", 133, "Выстрел взрывающегося сгустка огня", 40);
            IUseable SmallPotion = new MagicPotion("Слабое зелье магии", 25);
            Characters DragonBorn = new Characters("Довакин", 120);

            DragonBorn.CastMagicSpell((MagicSpell)Firebolt, (MagicPotion)SmallPotion);
            DragonBorn.CastMagicSpell((MagicSpell)Fireball, (MagicPotion)SmallPotion);

            Console.ReadKey(true);
        }
    }

}