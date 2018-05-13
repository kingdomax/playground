using System;
using System.Collections.Generic;
using MochPlayGround.MasterOfPolymorphism.Heros;

namespace MochPlayGround.MasterOfPolymorphism.HeroContainer
{
    public class DamageHeroContainer : BaseHeroContainer
    {
        private static Dictionary<string, HeroAttribution> damageHeroSet = new Dictionary<string, HeroAttribution>()
        {
            { 
                "Victor", new HeroAttribution(3800, new Dictionary<string, int> {
                    { "skill1", 10 },
                    { "skill2", 20 },
                    { "skill3", 30 }
                })
            }
        };
        
        protected override void SetType(ref Hero hero) => hero.Type = HeroType.Damage;
        
        // it need tp do more stuff further regard mapping data
        // if not, it will be bad design
        protected override void CustomizeHero(ref Hero hero)
        {
            HeroAttribution attribution;
            damageHeroSet.TryGetValue(hero.Name, out attribution);
            
            hero.Hp = attribution.Hp;
            hero.Skill = attribution.Skill;
        }
    }
}