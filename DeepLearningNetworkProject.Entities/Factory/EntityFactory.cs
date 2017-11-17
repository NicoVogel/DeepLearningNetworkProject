﻿using DLNP.Entities.Interfaces.Data;
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

        /// <summary>
        /// create a new <see cref="Network"/> object
        /// </summary>
        /// <returns></returns>
        public INetwork CreateEmptyNetwork()
        {
            return new Network(this);
        }

        /// <summary>
        /// create a new <see cref="Node"/> object
        /// </summary>
        /// <returns></returns>
        public INode CreateNode()
        {
            return new Node(this);
        }

        /// <summary>
        /// create a new <see cref="Connection"/> object
        /// </summary>
        /// <returns></returns>
        public IConnection CreateConnection()
        {
            return new Connection();
        }

    }
}
