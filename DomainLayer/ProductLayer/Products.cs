using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.ProductLayer
{
     public class Products
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string model { get; set; }
        public int price { get; set; }
        public int quantity { get; set; }
        public int typeId { get; set; }
        public ProductType type { get; set; }
        public int simTypeId { get; set; }
        public ProductSimType simType { get; set; }
        public int brandId { get; set; }
        public ProductBrand brand { get; set; }
        public int osProcessorId { get; set; }
        public ProductOsFeatures osFeatures { get; set; }
        public int camFeaturesId { get; set; }
        public ProductCamFeatures camFeatures { get; set; }
    }
}
