using DomainLayer;
using DomainLayer.ProductLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public interface IProductCatalog
    {
        void AddBrand(ProductBrand product);
        List<string> productBrands();
    }
}
