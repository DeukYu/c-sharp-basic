using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int aiChoice = rand.Next(0, 3);

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 0:
                    Console.WriteLine("컴퓨터의 선택은 가위입니다. ");
                    break;
                case 1:
                    Console.WriteLine("컴퓨터의 선택은 바위입니다. ");
                    break;
                case 2:
                    Console.WriteLine("컴퓨터의 선택은 보입니다. ");
                    break;
            }

            // 승리 무승부 패배
            if (choice == aiChoice)
                Console.WriteLine("무승부");
            else
            {
                if ((aiChoice == 0 && choice == 1) || (aiChoice == 1 && choice == 2) || (aiChoice == 2 && choice == 0))
                    Console.WriteLine("승리");
                else
                    Console.WriteLine("패배");
            }
        }
    }
}