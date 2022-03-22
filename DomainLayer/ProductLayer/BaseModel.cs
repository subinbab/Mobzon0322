using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.ProductLayer
{
    public abstract class BaseModel
    {
        [Key]
        public int id { get; set; }
    }
}
