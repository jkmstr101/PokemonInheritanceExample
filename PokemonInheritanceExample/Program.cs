using System;
using PokemonInheritanceExample.Classes;

namespace PokemonInheritanceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Welcome to Pokemon! \nChoose your starter!\n\n1: Bulbasaur\n2: Charmander\n3: Squirtle\n");
            int selection = Convert.ToInt32(Console.ReadLine());


            //Only Bulbasaur is programmed at this time.
            switch(selection)
            {
                case 1:
                    Bulbasaur bulbasaur = new Bulbasaur();
                    Console.WriteLine($"You chose {bulbasaur.Name}!");
                    Console.WriteLine("Would you like to set a nickname for your new Pokemon? (y or n)");
                    
                    if(Console.ReadLine() == "y")
                    {
                        Console.Write("Enter your nickname: ");
                        bulbasaur.SetNickname(Console.ReadLine());
                        Console.WriteLine($"Your {bulbasaur.Name} will now go by {bulbasaur.Nickname}");
                    }

                    break;
                case 2:
                    break;
                case 3:
                    break;
                default:
                    break;
            }
            
            
        }
    }
}
