using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.ProductLayer
{
    public class ProductCamFeatures : BaseModel
    {
        [DisplayName("Primay Camera")]
        public int primaryCam { get; set; }
        [DisplayName("Secondary Camera")]
        public int secondaryCam { get; set; }
    }
}
