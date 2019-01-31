using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // Here we instantiate a new instance of the Text class, which inherits from PresentationObject
            var text = new Text();

            // Here we set the FontName property which is a property of Text
            text.FontName = "Helvetica";

            // Here we set the Width property and call the Copy() method, both of which do not exist on the Text class object but are inherited from PresentationObject
            text.Width = 100;
            text.Copy();
        }
    }
}
