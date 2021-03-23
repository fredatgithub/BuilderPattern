using System.Collections.Generic;

namespace BuilderDemo
{
  class SuperSandwichBuilder : SandwichBuilder
  {
    public override void PrepareBread()
    {
      sandwich.BreadType = BreadType.White;
      sandwich.IsToasted = true;
    }

    public override void ApplyMeatAndCheese()
    {
      sandwich.CheeseType = CheeseType.Swiss;
      sandwich.MeatType = MeatType.Turkey;
    }

    public override void ApplyVegetables()
    {
      sandwich.Vegetables = new List<string> { "Tomato", "Onion", "Lettuce", "pepperoni" };
    }

    public override void AddCondiments()
    {
      sandwich.HasMayo = true;
      sandwich.HasMustard = true;
    }
  }
}
