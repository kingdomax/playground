using System.Collections.Generic;

namespace MochPlayGround.MasterOfPolymorphism.Heros
{
    public struct HeroAttribution
    {
        public HeroAttribution(int hp, IDictionary<string, int> skillSet)
        {
            Hp = hp;
            Skill = skillSet;
        }

        public int Hp { get; set; }
        public IDictionary<string, int> Skill { get; set; }
    }
}
