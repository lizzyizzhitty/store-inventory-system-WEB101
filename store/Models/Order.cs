using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace store.Models
{
    public class Order
    {
        public int ORDERID { get; set; }
    public int CUSTOMERID { get; set; }
    public string CUSTOMERNAME { get; set; }
    public int TOTAL { get; set; }
    }
}