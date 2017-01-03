using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CourtRegisters
{
    public static class Extentions
    {
        public static int ToInt(this string sVal)
        {
            int nVal;
            if (int.TryParse(sVal, out nVal))
            {
                return nVal;
            }
            else return 0;
        }
    }
}
