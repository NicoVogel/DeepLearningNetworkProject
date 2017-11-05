
using DLNP.Entities.Interfaces.Data;

namespace DLNP.Entities.Models
{
    public class NetworkInputData : INetworkInputData
    {



        public int ExpectedResult { get; set; }

        public double[][] ImageNumbers { get; set; }




        public NetworkInputData()
        {

        }


    }
}
