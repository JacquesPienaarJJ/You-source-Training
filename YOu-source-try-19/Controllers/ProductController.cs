using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YOu_source_try_19.DataGateway;
using YOu_source_try_19.Models;

namespace YOu_source_try_19.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly Product _product;

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            ProductDataGateway pdg = new ProductDataGateway();
            return pdg.GetProducts();
        }
    }
}
