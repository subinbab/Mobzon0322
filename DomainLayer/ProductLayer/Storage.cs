using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.ProductLayer
{
    public class Storage
    {
        [Key]
        public int id { get; set; }
        public int storage { get; set; }
    }
}
