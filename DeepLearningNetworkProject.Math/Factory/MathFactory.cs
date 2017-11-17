using DLNP.Entities.Interfaces.Business.Models;
using DLNP.Entities.Interfaces.Factories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DLNP.Math.Factory
{
    public class MathFactory : IMathFactory
    {
        #region Constructor

        public MathFactory()
        {

        }

        #endregion

        public IVector CreateVector(int size)
        {
            return new DLNPVector(size);
        }

        public IVector CreateVector(params double[] args)
        {
            return new DLNPVector(args);
        }

        public IMatrix CreateMatrix(int rows, int columns)
        {
            return new DLNPMatrix(rows, columns);
        }

    }
}
