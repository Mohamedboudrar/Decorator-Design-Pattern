using System;

namespace DP_WithoutDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            IceCream order = new IceCreamWithFruitMix();
            IceCream order1 = new IceCreamWithSprinkles();
            IceCream order2 = new IceCreamWithChocolateChips();

            Console.WriteLine(order);
            Console.WriteLine(order1);
            Console.WriteLine(order2);

            Console.ReadKey();
        }
    }
    public class IceCream
    {
        public virtual string Description => "Ice cream";
        public virtual decimal CalculateCost() => 3.5m;

        public override string ToString()
        {
            return $"{Description} ({CalculateCost().ToString("C")})";
        }
    }

    public class IceCreamWithSprinkles : IceCream
    {
        public override string Description => $"{base.Description} + Sprinkles";
        public override decimal CalculateCost() => base.CalculateCost() + .25m;
    }
    public class IceCreamWithChocolateChips : IceCream
    {
        public override string Description => $"{base.Description} + Chocolate Chips";
        public override decimal CalculateCost() => base.CalculateCost() + .45m;
    }

    public class IceCreamWithFruitMix : IceCream
    {
        public override string Description => $"{base.Description} + Fruit Mix";
        public override decimal CalculateCost() => base.CalculateCost() + .60m;
    }
}