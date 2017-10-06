using MochPlayGround.SearchCriteriaModelBinder_POC.model;

namespace MochPlayGround.SearchCriteriaModelBinder_POC.myclass
{
    public class SelectedPropertyBinder : Binder
    {
        // TODO : special stuff regarding each provider
        protected override void SetData(SearchCriteria searchCriteria, object value)
        {
            searchCriteria.Occupancy = value;
        }
    }
}
