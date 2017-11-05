

namespace DLNP.Entities.Interfaces
{
    public interface IConnection
    {

        INode FromNode { get; set; }

        INode ToNode { get; set; }

        double Weight { get; set; }

    }
}
