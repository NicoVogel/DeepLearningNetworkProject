

using DLNP.Data.MNIST;
using DLNP.Entities.Factory;
using DLNP.Entities.Interfaces.Data;
using DLNP.Entities.Models;
using System.Collections.Generic;

namespace DLNP.Factory
{
    public static class DataLayerFactory
    {
        /// <summary>
        /// get a instance of all IFileReader
        /// </summary>
        /// <returns></returns>
        public static IList<IFileReader> GetAllFileReader()
        {
            var list = BasicFactory.CreateList<IFileReader>();
            list.Add(new MnistFileReader());
            return list;
        }
    }
}
