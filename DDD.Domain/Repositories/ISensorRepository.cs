﻿using DDD.Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.Repositories
{
    public interface ISensorRepository
    {
        MeasureValue GetData();
    }
}
