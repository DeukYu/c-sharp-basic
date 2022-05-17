using System;

namespace CSharp // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Knight();
            Monster monster = new Orc();

            int damage = player.GetAttack();
            monster.OnDamaged(damage);
        }
    }
}