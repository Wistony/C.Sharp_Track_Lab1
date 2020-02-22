using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1_CreationalPatterns
{
    public interface IAttackable
    {
        int StartHealth { get;}
        int HealthLeft { get;}
       
        void ReceiveDamage(int damageAmount);
    }

    public class Unit : IAttackable
    {
        public string Type { get; set; }
        public int StartHealth { get; set; }
        public int HealthLeft { get; set; }
        public Movement MovementLogic { get; set; }
        public Weapon Weapon { get; set; }

        public void Hit()
        {
            if (HealthLeft > 0)
            {
                Weapon.Hit();
            }
            else
            {
                Console.WriteLine("Unit dead");
            }
        }

        public void ReceiveDamage(int damageAmount)
        {
            HealthLeft -= damageAmount;
            if (HealthLeft <= 0)
            {
                Console.WriteLine("I`m died");
            }
            else
            {
                Console.WriteLine($"{HealthLeft} points of healths are left");
            }
        }

        public void Move()
        {
            if (HealthLeft > 0)
            {
                MovementLogic.Move();
            }
            else
            {
                Console.WriteLine("Unit dead");
            }
        }
    }
}
