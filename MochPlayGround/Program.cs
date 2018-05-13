using MochPlayGround.CostOfNew;
using MochPlayGround.MasterOfPolymorphism;
using MochPlayGround.MasterOfPolymorphism.Heros;
using MochPlayGround.SearchCriteriaModelBinder_POC;
using MochPlayGround.SearchCriteriaModelBinder_POC.model;

namespace MochPlayGround
{
    class Program
    {
        static void Main(string[] args)
        {
            // Run through sequence of interface without knowing anything
            new SearchCriteriaModelBinder().BindModel(new ControllerContext(), new ModelBindingContext());

            // Checking performance when you create new object
            new CostOfNewObject().Test();

            // Utilize interface and abstraction
            var myHero = new HeroFactory().Create("Victor", HeroType.Damage);
        }
    }
}
