using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1_CreationalPatterns
{
    public abstract class Movement
    {
        public abstract int Speed { get; }
        public abstract void Move();
    }

    public class RunMovement : Movement
    {
        public override int Speed => 12;
        public override void Move()
        {
            Console.WriteLine($"Run at speed {Speed} km/h");
        }
    }

    class JumpMovement : Movement
    {
        public override int Speed => 20;

        public override void Move()
        {
            Console.WriteLine($"Jump at speed {Speed} km/h");
        }
    }

    class RideMovement : Movement
    {
        public override int Speed => 25;

        public override void Move()
        {
            Console.WriteLine($"Ride at speed {Speed} km/h");
        }
    }

    class FlyMovement : Movement
    {
        public override int Speed => 40;

        public override void Move()
        {
            Console.WriteLine($"Fly at speed {Speed} km/h");
        }
    }
}
