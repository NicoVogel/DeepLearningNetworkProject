using DLNP.Entities.Interfaces.Business;
using DLNP.Entities.Interfaces.Factories;
using DLNP.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepLearningNetworkProject.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            PresentationFactory pf = new PresentationFactory();
            IProgramController pc = pf.CreateProgramController();
            IEntityFactory ef = pf.EntityFactory;

            IList<int> layers = ef.CreateList<int>();
            layers.Add(2);
            layers.Add(3);
            layers.Add(2);

            pc.InizialiseNetwork(layers);
        }
    }
}
