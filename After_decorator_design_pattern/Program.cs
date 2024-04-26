using System;

class IceCream
{
    public virtual string Description => "Plain Ice Cream";
    public virtual decimal CalculateCost() => 2.0m;
}
class IceCreamDecorator : IceCream
{
    protected IceCream iceCream;

    public IceCreamDecorator(IceCream iceCream)
    {
        this.iceCream = iceCream;
    }
    public override string Description => iceCream.Description;
    public override decimal CalculateCost() => iceCream.CalculateCost();
}
class Sprinkles : IceCreamDecorator
{
    public Sprinkles(IceCream iceCream) : base(iceCream) { }
    public override string Description => base.Description + " with Sprinkles";
    public override decimal CalculateCost() => base.CalculateCost() + 0.5m;
}
class ChocolateChips : IceCreamDecorator
{
    public ChocolateChips(IceCream iceCream) : base(iceCream) { }
    public override string Description => base.Description + " with Chocolate Chips";
    public override decimal CalculateCost() => base.CalculateCost() + 0.7m;
}
class Program
{
    static void Main(string[] args)
    {
        IceCream iceCream = new ChocolateChips(new Sprinkles(new IceCream()));
        Console.WriteLine(iceCream.Description);
        Console.WriteLine($"Cost: {iceCream.CalculateCost():C}");
        Console.ReadLine();
    }
}
