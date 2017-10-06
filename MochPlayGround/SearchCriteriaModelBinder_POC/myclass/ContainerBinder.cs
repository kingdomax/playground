using System.Collections.Generic;

namespace MochPlayGround.SearchCriteriaModelBinder_POC.myclass
{
    public interface IContainerBinder
    {
        IEnumerable<IBinder> GetBinderList();
    }

    public class ContainerBinder : IContainerBinder
    {
        private readonly List<IBinder> _binderList;

        public ContainerBinder()
        {
            _binderList = new List<IBinder>()
            {
                new OccupancyBinder(),
                new SelectedPropertyBinder()
            };
        }

        public IEnumerable<IBinder> GetBinderList()
        {
            return _binderList;
        }
    }
}
