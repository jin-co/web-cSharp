using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public string GetProducts() {
            return "list of products";
        }
        
        [HttpGet("{id}")]
        public string GetProduct(int id) {
            return "product";
        }

    }
}