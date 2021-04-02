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
        public string Name { get; protected set; }
        public string Nickname { get; protected set; }

        public Types Type { get; protected set; }


    }
}
