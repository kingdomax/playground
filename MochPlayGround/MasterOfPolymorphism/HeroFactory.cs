using System;
using System.Collections.Generic;
using MochPlayGround.MasterOfPolymorphism.Heros;
using MochPlayGround.MasterOfPolymorphism.HeroContainer;

namespace MochPlayGround.MasterOfPolymorphism
{
    public class HeroFactory
    {
        private readonly IDictionary<HeroType, IHeroContainer> _heroContainers;

        public HeroFactory()
        {
            _heroContainers = new Dictionary<HeroType, IHeroContainer>()
            {
                { HeroType.FrontLine, new FrontLineHeroContainer() },
                { HeroType.Damage, new DamageHeroContainer() },
                { HeroType.Flank, new FlankHeroContainer() },
                { HeroType.Support, new SupportHeroContainer() }
            };
        }

        public Hero Create(string name, HeroType type)
        {
            IHeroContainer heroContainer;
            _heroContainers.TryGetValue(type, out heroContainer);

            return heroContainer?.Get(name);
        }
    }
}
