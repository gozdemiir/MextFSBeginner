using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MextFSBeginner.Entities.Helpers
{
    public static class TaxCalculator
    {
        public static double CalculateTax(double amount)
        {
            return amount * 0.20;
        }
    }
}