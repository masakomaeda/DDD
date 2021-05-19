using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.ValueObject
{
    //public sealed class MeasureValue
    //{
    //    public MeasureValue(float value)
    //    {
    //        Value = value;
    //    }
    //    public float Value { get; }
    //}



    public record MeasureValue(float value)
    {
        public string DisplayValue => Math.Round(value, 2) + "m/s";
    }


    public record MeasureDate(DateTime value)
    {
        public string DisplayValue => value.ToString("yyyy/MM/dd HH:mm:ss");
    }
}
