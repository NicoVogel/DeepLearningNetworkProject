

using DLNP.Entities.Interfaces.Business;

namespace DLNP.Entities.Interfaces.Factories
{
    public interface IPresentationFactory
    {

        IProgramController CreateProgramController();
    }
}
