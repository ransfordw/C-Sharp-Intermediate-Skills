using System.Collections.Generic;

namespace _39_Interfaces_Exercise
{
    public interface IWorkflowObject
    {
        void AddToQueue(IActivity activity);
        IEnumerable<IActivity> GetWorkFlow();
    }
}
