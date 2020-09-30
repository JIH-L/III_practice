using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace prjAspNetMvc.Controllers
{
    public class SevenServicesController : ApiController
    {
        // GET: api/SevenServices
        public IEnumerable<tProduct> Get()
        {
            var products = from p in (new dbDemoEntities()).tProduct
                           select p;
            foreach(tProduct p in products)
            {
                p.fCost = 0;

                if (p.fQty > 200)
                    p.fQty = 200;
                p.fPrice += 7;
            }
            return products;
        }

        // GET: api/SevenServices/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/SevenServices
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/SevenServices/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/SevenServices/5
        public void Delete(int id)
        {
        }
    }
}
