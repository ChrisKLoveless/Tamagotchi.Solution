using System.Collections.Generic;

namespace Tamagotchi.Models
{
  public class Tama
  {
    public string Name { get; set; }
    public int Hunger { get; set; }
    public int Sleep { get; set; }
    public int Happy { get; set; }

    public Tama (string name, int hunger, int sleep, int  happy)
    {
      Name = name;
      Hunger = hunger;
      Sleep = sleep;
      Happy = Happy;
    }

    public void PassTime()
    {
      this.Hunger -= 1;
      this.Sleep -= 1;
      this.Happy -= 1;
    }
  }
}