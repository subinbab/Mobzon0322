using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.ProductLayer
{
    public class ProductRams : ProductBaseModel
    { 
        public int ramId { get; set; }
        public Rams rams { get; set; }
    }
}
