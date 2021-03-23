using System;

namespace BuilderDemo
{
  class Program
  {
    static void Main()
    {
      var sandwichMaker = new SandwichMaker(new MySandwichBuilder());
      sandwichMaker.BuildSandwich();
      var sandwich1 = sandwichMaker.GetSandwhich();

      sandwich1.Display();

      var sandwichMaker2 = new SandwichMaker(new ClubSandwichBuilder());
      sandwichMaker2.BuildSandwich();
      var sandwich2 = sandwichMaker2.GetSandwhich();

      sandwich2.Display();
      Console.ReadKey();
    }
  }
}
