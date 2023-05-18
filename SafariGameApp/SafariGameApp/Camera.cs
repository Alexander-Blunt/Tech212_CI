namespace SafariGameApp;
public class Camera : IShootable
{
    public uint Score { get; private set;}
    public Camera() { }
    public string Shoot(Animal target)
    {
        Score += target.PointsValue;
        return $"Click, you have taken a picture of {target.Name} the {target.ToString().ToLower()}.";
    }
}
