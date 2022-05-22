using System;

namespace CSharp // Note: actual namespace depends on the project name.
{
    class Program
    {
        class Map
        {
            int[,] titles =
            {
                {1, 1,1,1, 1 },
                {1, 0,0,0, 1 },
                {1, 0,0,0, 1 },
                {1, 0,0,0, 1 },
                {1, 1,1,1, 1 }
            };

            public void Render()
            {
                ConsoleColor defaultColor = Console.ForegroundColor;
                for(int i = 0; i < titles.GetLength(1); i++)
                {
                    for(int j = 0; j < titles.GetLength(0); j++)
                    {
                        if (titles[j, i] == 1)
                            Console.ForegroundColor = ConsoleColor.Red;
                        else
                            Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write('\u25cf');
                    }
                    Console.WriteLine();
                }
                Console.ForegroundColor = defaultColor;
            }
        }
        static void Main(string[] args)
        {
            Map map = new Map();
            map.Render();
        }
    }
}