using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_patterns
{
    public enum ProductCategorys 
    {
        Food,
        Appliances
    }
    public class Product
    {
        public string ProdName { get; set; }
        public int ProdPrice { get; set; }
        public string ProdImage { get; set; }
        public ProductCategorys ProductCategorys { get; set; }
    }
}
