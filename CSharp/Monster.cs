﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public enum MonsterType
    {
        None = 0,
        Slime = 1,
        Orc = 2,
        Skelton = 3,
    }
    internal class Monster : Creature
    {
        protected MonsterType type = MonsterType.None;
        protected Monster(MonsterType type) : base(CreatureType.Monster)
        {
            this.type = type;
        }

        public MonsterType GetMonsterType() { return type; } 
    }

    class Slime : Monster
    {
        public Slime()  :base(MonsterType.Slime) { SetInfo(10, 10); }
    }

    class Orc : Monster
    {
        public Orc() :base(MonsterType.Orc) { SetInfo(20, 15); }
    }
    class Skelton : Monster
    {
        public  Skelton() :base(MonsterType.Skelton) { SetInfo(15, 25); }    
    }
}
