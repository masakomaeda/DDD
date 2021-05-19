using DDD.Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.Entities
{
    public class MeasureEntity
    {
        public MeasureEntity(string measureId, MeasureDate measureDate, MeasureValue measureValue)
        {
            MeasureId = measureId;
            MeasureDate = measureDate;
            MeasureValue = measureValue;

        }

        public string MeasureId { get; }
        public MeasureDate MeasureDate { get; }
        public MeasureValue MeasureValue { get; }

    }
}
