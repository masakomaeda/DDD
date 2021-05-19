using DDD.Domain.Helpers;
using DDD.Domain.Repositories;
using DDD.Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Infrastructure.Fake
{
    internal sealed class SensorFake : ISensorRepository
    {
        private Random _random = new Random();
        public MeasureValue GetData()
        {
            return new MeasureValue(_random.Next(0, 3) + _random.NextDouble().ToSingle());
        }
    }
}
