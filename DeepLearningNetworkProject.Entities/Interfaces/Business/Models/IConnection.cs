

namespace DLNP.Entities.Interfaces.Business.Models
{
    public interface IConnection
    {
        /// <summary>
        /// The node from which the <see cref="IConnection"/> starts
        /// </summary>
        INode FromNode { get; set; }
        /// <summary>
        /// The node to which the <see cref="IConnection"/> connects
        /// </summary>
        INode ToNode { get; set; }
        /// <summary>
        /// The weight of the connection
        /// </summary>
        double Weight { get; set; }

    }
}
