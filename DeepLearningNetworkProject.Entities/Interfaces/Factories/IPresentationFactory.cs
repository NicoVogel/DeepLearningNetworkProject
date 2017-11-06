
using DLNP.Entities.Interfaces.Business;

namespace DLNP.Entities.Interfaces.Factories
{
    public interface IPresentationFactory
    {

        /// <summary>
        /// create a new <see cref="IProgramController"/> object
        /// </summary>
        /// <returns></returns>
        IProgramController CreateProgramController();

    }
}
