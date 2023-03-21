using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bossfight
{
    public class GameCharacter
    {
        public string Name { get; private set; }
        public int Health { get; private set; }
        public int Strength { get; private set; }
        public int Stamina { get; private set; }

        public GameCharacter(string name, int health, int strength, int stamina)
        {
            Name = name;
            Health = health;
            Strength = strength;
            Stamina = stamina;
        }

        public void Fight(GameCharacter enemy)
        {
            enemy.Health -= Strength;
            Stamina -= 10;

            Console.Write($"{Name} hit {enemy.Name} with {Strength} damage, ");
            Console.WriteLine($"{enemy.Name} has {enemy.Health} health left.");
        }

        public void Recharge(int staminaAmount)
        {
            Console.WriteLine($"{Name} is recharging stamina...");
            Stamina = staminaAmount;
        }
    }
}
