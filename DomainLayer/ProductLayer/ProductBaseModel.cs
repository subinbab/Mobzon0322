using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.ProductLayer
{
    public abstract class ProductBaseModel
    {
        [Key]
        public int id { get; set; }
        public int productId { get; set; }
        public Products product { get; set; }

    }
}
