namespace SafariGameApp;

public class Hunter : Person
{
    public IShootable Shooter;

    public Hunter(string fName, string lName, IShootable shooter) : base(fName, lName)
    {
        Shooter = shooter;
    }
    public string Shoot(Animal target)
    {
        
        return Shooter.Shoot(target);
    }

    public override string ToString()
    {
        return $"{base.ToString()} {Shooter}";
    }


    public string PictureQuality(Animal target, int position)
    {
        Position = position;
        if(position <= target.Position - 30)
        {
            return $"{Shooter.Shoot(target)} picture quality is bad.";
        }
        else if (position <= target.Position - 10)
        {
            return $"{Shooter.Shoot(target)} picture quality is good.";
        }
        else if (position <= target.Position - 5)
        {
            return $"Too close may be eaten!";
        }
        else
        {
            return $"{Shooter.Shoot(target)} picture quality is amazing.";
        }
    }
}

