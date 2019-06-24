using SportsStore.Domain.Abstract;
using SportsStore.Domain.Concrete;
using SportsStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SportsStore.WebUI.Controllers
{
    public class ApiProductController : ApiController
    {
        private IProductRepository repo;

        public ApiProductController(IProductRepository repository)
        {
            this.repo = repository;
        }

        public IHttpActionResult GetAllProducts()
        {
            return Ok(this.repo.Products.ToArray());
        }
    }
}
