using System;

namespace CSharp // Note: actual namespace depends on the project name.
{
    class Program
    {
        class Knight
        {
            public int hp;
            public int attack;

            public void Move()
            {
                Console.WriteLine("Knight Move");
            }

            public void Attack()
            {
                Console.WriteLine("Knight Attack");
            }

        }

        struct Mage
        {
            public int hp;
            public int attack;
        }

        static void KillMage(Mage mage)
        {
            mage.hp = 0;
        }

        static void KillKnight(Knight knight)
        {
            knight.hp = 0;
        }
        static void Main(string[] args)
        {
            Mage mage;
            mage.hp = 100;
            mage.attack = 50;
            KillMage(mage);

            Knight knight = new Knight();

            knight.hp = 100;
            knight.attack = 10;
            KillKnight(knight); 
        }
    }
}