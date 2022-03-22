using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.ProductLayer
{
    public class ProductSimType : BaseModel
    {
        [DisplayName("Sim Type")]
        public string name { get; set; }
    }
}
