using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.Helpers
{
    public static class Extentions
    {
        public static float ToSingle(this double value)
        {
            return Convert.ToSingle(value);
        }

        public static DateTime ToDate(this string value)
        {
            return Convert.ToDateTime(value);
        }
    }
}
