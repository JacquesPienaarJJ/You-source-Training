using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YOu_source_try_19.Models;

namespace YOu_source_try_19.DataGateway
{
    interface IProductDataGateway
    {
        public List<Product> GetProducts();
    }
}
