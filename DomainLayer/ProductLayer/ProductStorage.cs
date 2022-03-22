using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.ProductLayer
{
    public class ProductStorage : ProductBaseModel
    {
        public int storageId { get; set; }
        public Storage storage { get; set; }
    }
}
