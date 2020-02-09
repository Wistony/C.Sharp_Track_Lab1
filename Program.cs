using System;

namespace Lab1_CreationalPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            UnitCreator director= new UnitCreator();

            InfantryBuilder infBuilder = new InfantryBuilder();
            Unit infantry = director.CreateUnit(infBuilder);
            infantry.Move();
            infantry.Hit();

            Unit tank = director.CreateUnit(new TankBuilder());
            tank.Hit();
            tank.Move();

        }
    }
}





