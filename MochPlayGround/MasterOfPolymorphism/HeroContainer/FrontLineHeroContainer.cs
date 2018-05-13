using System;
using MochPlayGround.MasterOfPolymorphism.Heros;

namespace MochPlayGround.MasterOfPolymorphism.HeroContainer
{
    public class FrontLineHeroContainer : BaseHeroContainer
    {
        protected override void SetType(ref Hero hero) => hero.Type = HeroType.FrontLine;
        protected override void CustomizeHero(ref Hero hero)
        {
            throw new NotImplementedException();
        }
    }
}
