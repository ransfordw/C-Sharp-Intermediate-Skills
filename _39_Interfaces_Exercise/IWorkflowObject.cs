using System.Collections.Generic;

namespace _39_Interfaces_Exercise
{
    public interface IWorkflowObject
    {
        void Add(IActivity activity);
        IEnumerable<IActivity> GetWorkFlow();
    }
}
