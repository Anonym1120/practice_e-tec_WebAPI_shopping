using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

using prjWebAPI.Models;

namespace prjWebAPI.Controllers
{
    public class ApiProductController : ApiController
    {
        dbmyDBEntities db = new dbmyDBEntities();
        
        // GET: api/ApiProduct
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/ApiProduct/5
        public tProduct Get(int id)
        {
            var product = db.tProduct
                .Where(m => m.fId == id)
                .FirstOrDefault();

            return product;
        }

        [HttpPost]
        public int Post(tProduct p) 
        {
            int n = 0;

            try
            {
                dbmyDBEntities db = new dbmyDBEntities();

                if (string.IsNullOrEmpty(p.fName)) 
                {
                    return n;
                }
                db.tProduct.Add(p);
                n = db.SaveChanges();
            }
            catch(Exception ex) 
            {
                n = 0;
            }

            return n; 
        }
        
        // PUT: api/ApiProduct/5
        public void Put(int id, [FromBody]string value)
        {

        }

        // DELETE: api/ApiProduct/5
        public void Delete(int id)
        {

        }
    }
}
