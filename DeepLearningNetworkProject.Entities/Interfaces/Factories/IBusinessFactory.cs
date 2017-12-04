

using DLNP.Entities.Interfaces.Business;


namespace DLNP.Entities.Interfaces.Factories
{
    public interface IBusinessFactory
    {

        /// <summary>
        /// create a new <see cref="IProgramController"/> object
        /// </summary>
        /// <returns></returns>
        IProgramController CreateProgramController();
    }
}
