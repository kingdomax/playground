using System.Collections.Generic;

namespace MochPlayGround.MasterOfPolymorphism.Heros
{
    public enum HeroType
    {
        FrontLine,
        Damage,
        Flank,
        Support
    }

    public class Hero
    {
        public string Name { get; set; }
        public int Hp { get; set; }
        public HeroType Type { get; set; }
        public IDictionary<string, int> Skill { get; set; }
    }
}
