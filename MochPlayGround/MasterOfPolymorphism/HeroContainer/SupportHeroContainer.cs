using System;
using MochPlayGround.MasterOfPolymorphism.Heros;

namespace MochPlayGround.MasterOfPolymorphism.HeroContainer
{
    public class SupportHeroContainer : BaseHeroContainer
    {
        protected override void SetType(ref Hero hero) => hero.Type = HeroType.Support;
        protected override void CustomizeHero(ref Hero hero)
        {
            throw new NotImplementedException();
        }
    }
}