using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    internal class InputManager
    {
        public delegate void OnInputKey();
        public event OnInputKey InputKey;
        public void Update()
        { 
            if(false == Console.KeyAvailable)
            {
                return;
            }

            ConsoleKeyInfo info = Console.ReadKey();
            if(info.Key != ConsoleKey.A)
            {
                InputKey();
            }
        }
    }
}
