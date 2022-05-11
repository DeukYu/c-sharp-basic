using System;

namespace CSharp // Note: actual namespace depends on the project name.
{
    class Program
    {
        enum ClassType
        {
            None = 0,
            Knight=1,
            Archar=2,
            Mage=3,
        }

        struct Player
        {
            public int hp;
            public int attack;
        }

        static ClassType ChooseClass()
        {
            Console.WriteLine("직업을 선택하세요!");
            Console.WriteLine("[1]궁수");
            Console.WriteLine("[2]궁수");
            Console.WriteLine("[3]법사");

            string input = Console.ReadLine();
            ClassType choice = ClassType.None;
            switch (input)
            {
                case "1":
                    choice = ClassType.Knight;
                    break;
                case "2":
                    choice = ClassType.Archar;
                    break;
                case "3":
                    choice = ClassType.Mage;
                    break;
            }
            return choice;
        }

        static void CreatePlayer(ClassType choice, out Player player)
        {
            // 기사(100/10) 궁수(75/12 법사(50/15)
            switch (choice)
            {
                case ClassType.Knight:
                    player.hp = 100;
                    player.attack = 10;
                    break;
                case ClassType.Archar:
                    player.hp = 75;
                    player.attack = 12;
                    break;
                case ClassType.Mage:
                    player.hp = 50;
                    player.attack = 15;
                    break;
                default:
                    player.hp = 0;
                    player.attack = 0;
                    break;
            }
        }
        static void Main(string[] args)
        {       
            while (true)
            {
                ClassType choice = ClassType.None;
                choice = ChooseClass();
                if (choice != ClassType.None)
                {
                    // 캐릭터 생성
                    Player player;
                    CreatePlayer(choice, out player);

                    Console.WriteLine($"HP{player.hp} Attack{player.attack}");
                    // 필드로 가서 몬스터와 싸운다.
                }
            }
        }
    }
}