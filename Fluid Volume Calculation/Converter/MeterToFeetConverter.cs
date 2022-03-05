using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fluid_Volume_Calculation.Converter
{
    public class MeterToFeetConverter
    {
        public static decimal MetreToFeet(decimal metre)
        {
            return metre * 3.2808m;
        }
    }
}
