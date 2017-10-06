using MochPlayGround.SearchCriteriaModelBinder_POC.model;
using System;

namespace MochPlayGround.SearchCriteriaModelBinder_POC.myclass
{
    public class OccupancyBinder : Binder
    {
        protected override void SetData(SearchCriteria searchCriteria, object value)
        {
            // TODO : special stuff regarding each provider
            searchCriteria.Occupancy = value;
        }
    }
}
