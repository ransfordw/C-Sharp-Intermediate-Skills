using _39_Interfaces_Exercise.Activities;
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
            workflow.Add(new Upload());
            workflow.Add(new ThirdPartyEncoderRequest());
            workflow.Add(new MediaOwnerUpdate());
            workflow.Add(new MediaStatusUpdate());

            var workflowEngine = new WorkflowEngine();
            workflowEngine.Run(workflow);

            Console.ReadKey();

        }
    }
}
