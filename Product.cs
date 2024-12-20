using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace store.Models
{
    public class Product
    {
        public int ID { get; set; }
    public string NAME { get; set; }
    public int STOCK { get; set; }
    public int PRICE { get; set; }
    public string DESCRIPTION { get; set; }
    public string CATEGORY { get; set; }
    public string BRAND { get; set; }
    }
}