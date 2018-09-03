using MochPlayGround.CostOfNew;
using MochPlayGround.DownloadManagers;
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

            // Measure download time of single JS file (5mb)
            new DownloadManager().DownloadFile("https://cdn6.agoda.net/js/mvc/assets/enty.webpack-6792ae6944.js", @"C:/test/entry4.js");
        }
    }
}
