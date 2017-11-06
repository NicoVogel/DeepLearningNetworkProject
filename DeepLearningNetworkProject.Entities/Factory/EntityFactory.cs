using DLNP.Entities.Interfaces.Data;
using DLNP.Entities.Interfaces.Factories;
using DLNP.Entities.Models;
using System.Collections.Generic;
using DLNP.Entities.Interfaces.Business.Models;
using System;

namespace DLNP.Entities.Factory
{
    public class EntityFactory : IEntityFactory
    {

        #region Constructor



        /// <summary>
        /// default constructor
        /// </summary>
        public EntityFactory()
        {

        }


        #endregion


        /// <summary>
        /// create a new <see cref="List{T}"/> object
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public IList<T> CreateList<T>()
        {
            return new List<T>();
        }

        /// <summary>
        /// create a new <see cref="NetworkInputData"/> object
        /// </summary>
        /// <returns></returns>
        public INetworkInputData CreateNetworkInputData()
        {
            return new NetworkInputData();
        }

        
        public INetwork CreateEmptyNetwork()
        {
            return null;
        }

    }
}
