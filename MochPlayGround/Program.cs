using MochPlayGround.CostOfNew;
using MochPlayGround.SearchCriteriaModelBinder_POC;
using MochPlayGround.SearchCriteriaModelBinder_POC.model;

namespace MochPlayGround
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sequence of inheritance
            new SearchCriteriaModelBinder().BindModel(new ControllerContext(), new ModelBindingContext());

            // Checking performance when you new objecty
            new CostOfNewObject().Test();
        }
    }
}
