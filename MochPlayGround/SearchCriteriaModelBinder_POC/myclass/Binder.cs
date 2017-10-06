using MochPlayGround.SearchCriteriaModelBinder_POC.model;

namespace MochPlayGround.SearchCriteriaModelBinder_POC.myclass
{
    public abstract class Binder : IBinder
    {

        public void BindModel(SearchCriteria searchCriteria, ControllerContext context, ModelBindingContext bindingContext)
        {
            var value = ExtractData(context.PrimarySource, bindingContext.FallBack);
            SetData(searchCriteria, value);
        }

        private object ExtractData(object primarySource, object fallbacks)
        {
            // todo-moch : comnplete magics stuff here
            return null;
        }

        protected abstract void SetData(SearchCriteria searchCriteria, object value);
    }
}
