using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1_CreationalPatterns
{
    public class UnitCreator
    {
        public Unit CreateUnit(UnitBuilder unitBuilder)
        {
            unitBuilder.CreateBuilder();
            unitBuilder.SetMovement();
            unitBuilder.SetWeapon();
            unitBuilder.SetType();
            unitBuilder.SetHealth();
            return unitBuilder.Unit;
        }
    }
}
