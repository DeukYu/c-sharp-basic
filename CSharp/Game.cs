using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public enum GameMode
    {
        None,
        Lobby,
        Town,
        Field,
    }
    internal class Game
    {
        private GameMode mode = GameMode.Lobby;
        private Player? player = null;
        private Monster? monster = null;
        private Random rand = new Random();

        public void Process()
        {
            switch(mode)
            {
                case GameMode.Lobby:
                    ProcessLobby();
                    break;
                case GameMode.Town:
                    ProcessTown();
                    break;
                case GameMode.Field:
                    ProcessField();
                    break;
            }
        }

        private void ProcessLobby()
        {
            Console.WriteLine("직업을 선택하세요.");
            Console.WriteLine("[1] 기사 [2] 궁수 [3] 법사");
            switch(Console.ReadLine())
            {
                case "1":
                    player = new Knight();
                    mode = GameMode.Town;
                    break;
                case "2":
                    player = new Archer();
                    mode = GameMode.Town;
                    break;
                case "3":
                    player = new Mage();
                    mode = GameMode.Town;
                    break;
            }
        }
        private void ProcessTown()
        {
            Console.WriteLine("마을에 입장하였습니다.");
            Console.WriteLine("[1]  필드로 가기 [2] 로비로 돌아가기");

            switch (Console.ReadLine())
            {
                case "1":
                    mode = GameMode.Field;
                    break;
                case "2":
                    mode = GameMode.Lobby;
                    break;
            }
        }
        private void ProcessField()
        {
            Console.WriteLine("필드에 입장하였습니다.");
            Console.WriteLine("[1] 싸우기 [2] 일정 확률로 마을로 돌아가기");

            CreateRandomMonster();

            switch(Console.ReadLine())
            {
                case "1":
                    ProcessFight();
                    break;
                case "2":
                    TryEscape();
                    break;
            }
        }

        private void CreateRandomMonster()
        {
            int randVal = rand.Next(0, 3);
            switch (randVal)
            {
                case 0:
                    monster = new Slime();
                    Console.WriteLine("슬라임이 생성되었습니다.");
                    break;
                case 1:
                    monster = new Orc();
                    Console.WriteLine("오크가 생성되었습니다.");
                    break;
                case 2:
                    monster = new Skelton();
                    Console.WriteLine("스켈레톤이 생성되었습니다.");
                    break;
            }
        }

        private void ProcessFight()
        {
            while(true)
            {
                int damage = player.GetAttack();
                monster.OnDamaged(damage);
                if (monster.IsDead())
                {
                    Console.WriteLine("승리했습니다.");
                    Console.WriteLine($"HP : {player.GetHp()}");
                    break;
                }

                damage = monster.GetAttack();
                player.OnDamaged(damage);
                if(player.IsDead())
                {
                    Console.WriteLine("패배했습니다.");
                    mode = GameMode.Lobby;
                    break;
                }
            }
        }

        private void TryEscape()
        {
            int randVal = rand.Next(0, 101);
            if(randVal < 33)
            {
                mode = GameMode.Town;
            }
            else
            {
                ProcessFight();
            }
        }
    }
}
