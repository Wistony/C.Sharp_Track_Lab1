using System;
using System.Collections.Generic;

namespace Lab1_CreationalPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            UnitCreator director = new UnitCreator();
            Choose_Unit(director);
        }

        static void Choose_Unit(UnitCreator director)
        {
            Console.WriteLine("1) Infantry \n" +
                "2) Shooter \n" +
                "3) Cavalry \n" +
                "4) Tank \n" +
                "5) Plane");
            Console.Write("Choose type of units: ");
            string str = Console.ReadLine();
            int choice = Convert.ToInt32(str);

            switch (choice)
            {
                case 1:
                    {
                        Unit infantry = director.CreateUnit(new InfantryBuilder());
                        Choose_Action(infantry, director);
                        break;
                    }
                case 2:
                    {
                        Unit shooter = director.CreateUnit(new ShooterBuilder());
                        Choose_Action(shooter, director);
                        break;
                    }
                case 3:
                    {
                        Unit cavalry = director.CreateUnit(new CavalryBuilder());
                        Choose_Action(cavalry, director);
                        break;
                    }
                case 4:
                    {
                        Unit tank = director.CreateUnit(new TankBuilder());
                        Choose_Action(tank, director);
                        break;
                    }
                case 5:
                    {
                        Unit plane = director.CreateUnit(new PlaneBuilder());
                        Choose_Action(plane, director);
                        break;
                    }
                default:
                    break;
            }
        }
        static void Choose_Action(Unit unit, UnitCreator director)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("1) Move\n" +
                              "2) Hit\n" +
                              "3) Weapon damage for hit\n" +
                              "4) Weapon durability\n" +
                              "5) Weapon accuracy\n" +
                              "6) Receive Damage\n" +
                              "7) Go back");
                Console.Write($"{unit.Type} actions: ");
                string str = Console.ReadLine();
                int choice = Convert.ToInt32(str);

                switch (choice)
                {
                    case 1:
                        {
                            unit.Move();
                            break;
                        }
                    case 2:
                        {
                            unit.Hit();
                            break;
                        }
                    case 3:
                        {
                            unit.Weapon.GetHitDamage();
                            break;
                        }
                    case 4:
                        {
                            unit.Weapon.GetDurability();
                            break;
                        }
                    case 5:
                        {
                            unit.Weapon.GetAccuracy();
                            break;
                        }
                    case 6:
                        {
                            Console.Write("Enter how much damage will be received:");
                            string damage = Console.ReadLine();
                            int dmg = Convert.ToInt32(damage); 
                            unit.ReceiveDamage(dmg);
                            break;
                        }
                    case 7:
                        {
                            flag = false;
                            Console.Clear();
                            Choose_Unit(director);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("*** Incorrect number, please try again! ***");
                            break;
                        }
                }
            }  
        }
    }
}