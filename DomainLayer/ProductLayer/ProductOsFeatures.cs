using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.ProductLayer
{
    public class ProductOsFeatures : BaseModel
    {
        [DisplayName("Operating System")]
        public string operatingSystem { get; set; }
        [DisplayName("Processor")]
        public string processor { get; set; }
        [DisplayName("Processor Core")]
        public string processorCore { get; set; }

    }
}
