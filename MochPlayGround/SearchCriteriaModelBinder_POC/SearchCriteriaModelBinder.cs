using MochPlayGround.SearchCriteriaModelBinder_POC.model;
using MochPlayGround.SearchCriteriaModelBinder_POC.myclass;

namespace MochPlayGround.SearchCriteriaModelBinder_POC
{
    public class SearchCriteriaModelBinder
    {
        private readonly IContainerBinder _containerBinder;

        public SearchCriteriaModelBinder()
        {
            _containerBinder = new ContainerBinder();
        }

        public object BindModel(ControllerContext context, ModelBindingContext bindingContext)
        {
            var searchCriteria = new SearchCriteria();

            foreach(var binder in _containerBinder.GetBinderList())
            {
                binder.BindModel(searchCriteria, context, bindingContext);
            }

            return searchCriteria;
        }
    }
}
