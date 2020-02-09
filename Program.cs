abstract class Weapon
{
    int Durability { get; set; }
    int Damage { get; set; }
    double Accuracy { get; set; }

    public Weapon(int durability,int damage,double accuracy) 
    {
        Durability = durability;
        Damage = damage;
        Accuracy = accuracy;
    }

    public abstract void Hit();
    public void GetDamage()
    {
        Console.WriteLine($"Нанесено {Damage} одиниць пошкодження");
    }
}

class Rifl : Weapon
{
    public Rifl(int durability,int damage,double accuracy) : base(durability,damage,accuracy)
    {

    }
    public override void Hit()
    {
        Console.WriteLine("Стріляємо із гвинтівки");
    }
}

class SniperRifl : Weapon
{
    public SniperRifl(int durability, int damage, double accuracy) : base(durability, damage, accuracy)
    {

    }
    public override void Hit()
    {
        Console.WriteLine("Стріляємо із cнайперської гвинтівки");
    }
}

class Sword : Weapon
{
    public Sword(int durability, int damage, double accuracy) : base(durability, damage, accuracy)
    {

    }

    public override void Hit()
    {
        Console.WriteLine("Б'ємо мечем");
    }
}

class TankGun : Weapon
{
    public TankGun(int durability, int damage, double accuracy) : base(durability, damage, accuracy)
    {

    }

    public override void Hit()
    {
        Console.WriteLine("Стріляємо із танкової гармати");
        GetDamage();
    }
}

abstract class Movement
{
    int Speed { get; set; }
    public abstract void Move();
}

class RunMovement : Movement
{
    public override void Move()
    {
        Console.WriteLine("Біжимо");
    }
}

class JumpMovement : Movement
{
    public override void Move()
    {
        Console.WriteLine("Скачемо");
    }
}

class RideMovement : Movement
{
    public override void Move()
    {
        Console.WriteLine("Їдемо");
    }
}

abstract class UnitFactory
{
    public abstract Movement CreateMovement();
    public abstract Weapon CreateWeapon();
}

class InfantryFactory : UnitFactory
{
    public override Movement CreateMovement()
    {
        return new RunMovement();
    }

    public override Weapon CreateWeapon()
    {
        return new Rifl(300,50,0.7);
    }
}

class ShooterFactory : UnitFactory
{
    public override Movement CreateMovement()
    {
        return new RunMovement();
    }

    public override Weapon CreateWeapon()
    {
        return new SniperRifl(200,150,0.95);
    }
}

class HorseFactory : UnitFactory
{
    public override Movement CreateMovement()
    {
        return new JumpMovement();
    }

    public override Weapon CreateWeapon()
    {
        return new Sword(300,75,0.8);
    }
}

class TankFactory : UnitFactory
{
    public override Movement CreateMovement()
    {
        return new RideMovement();
    }

    public override Weapon CreateWeapon()
    {
        return new TankGun(500,250,0.65);
    }
}

class Unit
{
    int Health;
    Movement movement;
    Weapon weapon;

    public Unit(UnitFactory factory)
    {
        movement = factory.CreateMovement();
        weapon = factory.CreateWeapon();
    }

    public void Hit()
    {
        weapon.Hit();
    }
}
