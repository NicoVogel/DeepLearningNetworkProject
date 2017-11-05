
using System;
using System.Collections.Generic;

namespace DLNP.Entities.Interfaces.Data
{
    public interface IFileReader
    {

        IList<INetworkInputData> ReadFile(String imagesPath, String lablesPath);

    }
}
