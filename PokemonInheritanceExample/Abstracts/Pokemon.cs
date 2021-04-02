using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonInheritanceExample.Abstracts
{
    abstract class Pokemon
    {
        public enum Types { Grass, Fire, Water };
        public abstract void BattleCry();
        public abstract void SetNickname(string s);
        public abstract void SetType();
        public abstract void SetXPTable();
        public abstract void AddXP(int s);
        public string Name { get; protected set; }
        public string Nickname { get; protected set; }

        public string Level { get; protected set; }
        public int CurrentXP { get; protected set; }
        public int[] xpTable { get; protected set; }

        public Types Type { get; protected set; }


    }
}
