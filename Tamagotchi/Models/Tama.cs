using System.Collections.Generic;

namespace Tamagotchi.Models
{
    public class Tama
    {
        public string Name { get; set; }
        public int Hunger { get; set; }
        public int Sleep { get; set; }
        public int Happy { get; set; }
        private static List<Tama> _team = new List<Tama> { };

        public static Dictionary<int, string> tamaImages = new Dictionary<int, string> { {1, "https://img.icons8.com/plasticine/2x/pikachu-pokemon.png"}, {2, "https://img.icons8.com/color/2x/jigglypuff.png"}, {3, "https://img.icons8.com/color/2x/psyduck.png"} };

        public Tama(string name)
        {
            Name = name;
            Hunger = 10;
            Sleep = 10;
            Happy = 10;
            _team.Add(this);
        }

        public static List<Tama> GetAll()
        {
            return _team;
        }

        public void PassTime()
        {
            this.Hunger -= 1;
            this.Sleep -= 1;
            this.Happy -= 1;
        }

        public static void ClearAll()
        {
            _team.Clear();
        }
    }
}