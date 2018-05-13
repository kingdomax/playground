using System;
using MochPlayGround.MasterOfPolymorphism.Heros;

namespace MochPlayGround.MasterOfPolymorphism.HeroContainer
{
    public class FlankHeroContainer : BaseHeroContainer
    {
        protected override void SetType(ref Hero hero) => hero.Type = HeroType.Flank;
        protected override void CustomizeHero(ref Hero hero)
        {
            throw new NotImplementedException();
        }
    }
}