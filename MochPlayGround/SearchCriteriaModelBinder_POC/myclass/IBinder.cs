using MochPlayGround.SearchCriteriaModelBinder_POC.model;

namespace MochPlayGround.SearchCriteriaModelBinder_POC.myclass
{
    public interface IBinder
    {
        void BindModel(SearchCriteria searchCriteria, ControllerContext context, ModelBindingContext bindingContext);
    }
}
