using MochPlayGround.MasterOfPolymorphism.Heros;

namespace MochPlayGround.MasterOfPolymorphism.HeroContainer
{
    interface IHeroContainer
    {
        Hero Get(string name);
    }
    
    public abstract class BaseHeroContainer : IHeroContainer
    {
        protected abstract void SetType(ref Hero hero);
        protected abstract void CustomizeHero(ref Hero hero);

        public Hero Get(string name)
        {
            var aHero = new Hero() { Name = name };
            
            SetType(ref aHero);
            CustomizeHero(ref aHero);

            return aHero;
        }
    }
}
