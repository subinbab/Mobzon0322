using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DomainLayer.ProductLayer;

namespace DomainLayer.ProductLayer
{
    public class ProductColor : ProductBaseModel
    {
        public int colorsId { get; set; }
        public Colors colors { get; set; }

    }
}
