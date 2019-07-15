using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39_Interfaces_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var workflow = new Workflow();
            workflow.AddToQueue(new Upload());
            workflow.AddToQueue(new ThirdPartyEncoderRequest());
            workflow.AddToQueue(new MediaOwnerUpdate());
            workflow.AddToQueue(new MediaStatusUpdate());

            var workflowEngine = new WorkflowEngine();
            workflowEngine.Run(workflow);

            Console.ReadKey();

        }
    }
}
