
using DLNP.Entities.Interfaces.Business.Models;

namespace DLNP.Entities.Interfaces.Factories
{
    public interface IMathFactory
    {

        IVector CreateVector(int size);

        IVector CreateVector(params double[] args);

        IMatrix CreateMatrix(int rows, int columns);
    }
}
