using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonInheritanceExample.Abstracts
{
    abstract class Pokemon
    {

        /* 
          Using 3 basic types for this demo.
         */
        public enum Types { Grass, Fire, Water };

        //Every pokemon must have a battle cry.
        public abstract void BattleCry();
        
        //Every pokemon can have a nickname. This is how it will be set.
        public abstract void SetNickname(string s);
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
