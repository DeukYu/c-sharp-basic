using System;

namespace CSharp // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void OnInputTest()
        {
            Console.WriteLine("Input Received!");
        }
        static void Main(string[] args)
        {
            InputManager inputManager = new InputManager();

            inputManager.InputKey += OnInputTest;

            while(true)
            {
                inputManager.Update();
            }
        }
    }
}