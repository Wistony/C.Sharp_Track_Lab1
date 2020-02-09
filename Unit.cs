using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1_CreationalPatterns
{
    public interface IAttackable
    {
        int StartHealth { get; }
        int HealthLeft { get; }

        void ReceiveDamage(int damageAmount);
    }

    public class Unit : IAttackable
    {
        public string Type { get; set; }
        public int StartHealth { get; set; }
        public int HealthLeft { get; set; }
        public Movement MovementLogic { get; set; }
        public Weapon weapon { get; set; }

        public void Hit()
        {
            weapon.Hit();
        }

        public void ReceiveDamage(int damageAmount)
        {
            HealthLeft -= damageAmount;
            if (HealthLeft <= 0)
            {
                Console.WriteLine("I`m died");
            }
        }

        public void Move()
        {
            MovementLogic.Move();
        }
    }
}
