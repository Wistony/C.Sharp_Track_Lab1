using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1_CreationalPatterns
{
    public abstract class Weapon
    {
        public abstract int Durability { get; }
        public abstract int HitDamage { get; }
        public abstract float Accuracy { get; }

        public abstract void Hit();
        public void GetDamage()
        {
            Console.WriteLine($"Caused {HitDamage} damage");
        }
    }

    public class Rifle : Weapon
    {
        public override int Durability => 300;
        public override int HitDamage => 50;
        public override float Accuracy => 0.7f;

        public override void Hit()
        {
            Console.WriteLine("Shoot with a rifle");
            GetDamage();
        }
    }

    public class SniperRifle : Weapon
    {
        public override int Durability => 200;
        public override int HitDamage => 100;
        public override float Accuracy => 0.95f;

        public override void Hit()
        {
            Console.WriteLine("Shoot with a sniper rifle");
            GetDamage();
        }
    }

    public class Sword : Weapon
    {
        public override int Durability => 150;
        public override int HitDamage => 75;
        public override float Accuracy => 0.6f;

        public override void Hit()
        {
            Console.WriteLine("Attack with a sword");
            GetDamage();
        }
    }

    public class TankGun : Weapon
    {
        public override int Durability => 500;
        public override int HitDamage => 100;
        public override float Accuracy => 0.65f;

        public override void Hit()
        {
            Console.WriteLine("Shoot with a tank gun");
            GetDamage();
        }
    }
}
