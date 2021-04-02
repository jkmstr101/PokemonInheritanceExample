using System;
using System.Collections.Generic;
using System.Text;
using PokemonInheritanceExample.Abstracts;
using PokemonInheritanceExample.Interfaces;

namespace PokemonInheritanceExample.Classes
{
    class Bulbasaur : Pokemon
    {
       
        public Bulbasaur()
        {
            Name = "Bulbasaur";
            SetType();
        }
        
        public override void BattleCry()
        {
            Console.WriteLine("BULBA!!");
        }

        public override void SetNickname(string s)
        {
             Nickname = s;
        }

        public override void SetType()
        {
            Type = Pokemon.Types.Grass;
        }
        

    }
}
