using DDD.Domain.Entities;
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
    internal sealed class MeasureFake : IMeasureRepository
    {

        private static List<MeasureEntity> _entities;
        static MeasureFake()
        {
            _entities = new List<MeasureEntity>
            {
                new MeasureEntity("guidA", new MeasureDate("2017/01/01 14:00:00".ToDate()), new MeasureValue(2.23456f)),
                new MeasureEntity("guidA", new MeasureDate("2017/01/01 13:00:00".ToDate()), new MeasureValue(1.23456f)),
            };
        }
        public MeasureEntity GetLatest()
        {
           return new  MeasureEntity("guidA", new MeasureDate("2017/01/01 13:00:00".ToDate()), new MeasureValue(1.23456f));
        }

        public IReadOnlyList<MeasureEntity> GetData()
        {
            return _entities;
        }
    }
}
