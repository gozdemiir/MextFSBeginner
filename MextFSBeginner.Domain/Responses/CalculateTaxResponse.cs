using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MextFSBeginner.Domain.Responses
{
    public class CalculateTaxResponse
    {
        public decimal KdvliFiyat { get; set; }
        public decimal KdvMiktari { get; set; }
        public decimal KdvOrani { get; set; }
    }
}
