using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkFlow
{

    class Program
    {
        static void Main(string[] args)
        {
            WorkFlowEngine engine = new WorkFlowEngine();
            WorkFlow workflow = new WorkFlow();
            workflow.Add(new VideoDecoder());
            workflow.Add(new WebServiceCall());
            workflow.Add(new StreamRecord());
            workflow.Add(new ScreenShoot());
            engine.Run(workflow);
        }
    }
}
