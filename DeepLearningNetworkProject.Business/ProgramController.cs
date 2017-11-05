
using System;
using System.Collections.Generic;
using DLNP.Entities.Interfaces.Business;
using DLNP.Entities.Interfaces.Data;

namespace DLNP.Business
{
    public class ProgramController : IProgramController
    {
        public IList<INetworkInputData> Data
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IList<string> GetExtensions()
        {
            throw new NotImplementedException();
        }

        public void LoadFile(string imagePath, string labelPath)
        {
            throw new NotImplementedException();
        }

        public void LoadNetwork(string networkPath)
        {
            throw new NotImplementedException();
        }

        public void SaveNetwork(string networkPath)
        {
            throw new NotImplementedException();
        }

        public void StartTraining()
        {
            throw new NotImplementedException();
        }

        public void StopTraining()
        {
            throw new NotImplementedException();
        }
    }
}
