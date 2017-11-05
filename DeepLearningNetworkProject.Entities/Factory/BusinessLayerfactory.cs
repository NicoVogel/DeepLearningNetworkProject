using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLNP.Entities.Factory
{
    public static class BusinessLayerFactory
    {

        /// <summary>
        /// create a new <see cref="List{T}"/> object
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static IList<T> CreateList<T>()
        {
            return new List<T>();
        }
    }
}
