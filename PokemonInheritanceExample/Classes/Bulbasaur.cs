using System;
using System.Collections.Generic;
using System.Text;
using PokemonInheritanceExample.Abstracts;
using PokemonInheritanceExample.Interfaces;

namespace PokemonInheritanceExample.Classes
{
    class Bulbasaur : Pokemon, ICutable
    {
       
        public Bulbasaur()
        {
            Name = "Bulbasaur";
            SetType();
            CurrentXP = 0;
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

        public override void SetXPTable()
        {
            xpTable = new int[100];
            for(int i = 0; i <= 99; i++)
            {
                xpTable[i] = i * 100;
            }
        }

        public override void AddXP(int s)
        {
            CurrentXP += s;
        }

        public void Cut()
        {
            Console.WriteLine($"{Nickname} used Cut!");
        }
        

    }
}
