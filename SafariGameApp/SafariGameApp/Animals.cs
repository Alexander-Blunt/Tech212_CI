namespace SafariGameApp;
public abstract class Animal : IMovable
{
    public string Name { get; set; }

    public uint PointsValue { get; }

    public virtual string Call()
    {
        return "ah";
    }

    public Animal(string name, uint pointsValue)
    {
        Name = name;
        PointsValue = pointsValue;
    }

    public int Position { get; private set; }

    public int Speed { get; init; }

    public abstract string Move();
    public abstract string Move(int times);

    public abstract string Eats();

    int IMovable.Move()
    {
        Position += Speed;
        return Position;
    }

    int IMovable.Move(int times)
    {
        Position += times * Speed;
        return times;    
    }
    
}

public class Cat : Animal
{
    public Cat(string name) : base(name, 2) { }
    public override string Call()
    {
        return "Meow";
    }

    public override string Move()
    {
        return "saunters";
    }

    public override string Eats()
    {
        return "fish";
    }
    public override string Move(int times)
    {
        return Move() + $"{times} times"; 
    }

}

public class Dog : Animal
{
    public Dog(string name) : base (name, 1) { }
    public override string Call()
    {
        return "Woof";
    }

    public override string Move()
    {
        return "runs";
    }
    public override string Eats()
    {
        return "meat";
    }

    public override string Move(int times)
    {
        return Move() + $"{times} times";
    }
}

public class Kangaroo : Animal
{
    public Kangaroo(string name) : base(name, 5) { }

    public override string Call()
    {
        return "Good'day";
    }

    public override string Move()
    {
        return "jumps";
    }
    public override string Eats()
    {
        return "grass";
    }
    public override string Move(int times)
    {
        return $"The kangaroo jumped {times} times";
    }
}

public class Bear : Animal
{
    public Bear(string name) : base(name, 10) { }

    public override string Eats()
    {
        return "Bear eats you! Game over.";
    }

    public override string Move()
    {
        return "Pads";
    }

    public override string Move(int times)
    {
        return $"The bear padded {times} times";
    }
}