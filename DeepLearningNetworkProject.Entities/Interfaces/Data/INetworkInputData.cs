﻿using System.Collections.Generic;

namespace DLNP.Entities.Interfaces.Data
{
    public interface INetworkInputData
    {

        int ExpectedResult { get; set; }

        double[][] ImageNumbers { get; set; }

    }
}