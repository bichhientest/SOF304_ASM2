using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOF304_ASM2
{
    public class ElectricityBill
    {
        public double CalculateCost(int quantity,int pricePerUnit)
        {
            return quantity * pricePerUnit;
        }
    }
}
