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
        public tProduct Get(int id) //fId 查詢
        {
            var product = db.tProduct
                .Where(m => m.fId == id)
                .FirstOrDefault();

            return product;
        }

        [HttpPost]
        public int Post(tProduct p) //新增
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
        public int Put(tProduct p) //fId 修改
        {
            int n = 0;
            try
            {
                var product = db.tProduct
                .Where(m => m.fId == p.fId)
                .FirstOrDefault();

                product.fPId = p.fPId;
                product.fName = p.fName;
                product.fPrice = p.fPrice;

                n = db.SaveChanges();
            }
            catch 
            {
                n = 0;
            }

            return n;
        }

        // DELETE: api/ApiProduct/5
        public int Delete(int id) // fId 刪除
        {
            int n = 0;

            try
            {
                var product = db.tProduct
                    .Where(m => m.fId == id)
                    .FirstOrDefault();

                db.tProduct.Remove(product);
                n = db.SaveChanges();
            }
            catch 
            {
                n = 0;
            }

            return n;
        }
    }
}
