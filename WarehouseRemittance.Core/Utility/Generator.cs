using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseRemittance.Core.Utility
{
    public class Generator
    {
        public static int RandomNumber(int min = 1, int max = 9999)
        {
            Random r = new Random();
            int rnd = r.Next(min, max);
            return rnd;
        }
    }
}
