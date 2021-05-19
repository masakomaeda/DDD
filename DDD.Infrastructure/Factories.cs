using DDD.Domain.Repositories;
using DDD.Infrastructure.Fake;
using System;

namespace DDD.Infrastructure
{
    public static class Factories
    {
        public static ISensorRepository CreateSensorRepository()
        {
            return new SensorFake();
        }

        public static IMeasureRepository CreateMeasureRepository()
        {
            return new MeasureFake();
        }
    }
}
