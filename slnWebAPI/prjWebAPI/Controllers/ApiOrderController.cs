using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using prjWebAPI.Models;

namespace prjWebAPI.Controllers
{
    public class ApiOrderController : ApiController
    {
        dbmyDBEntities db = new dbmyDBEntities();

        // GET: api/ApiOrder
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/ApiOrder/5
        public IEnumerable<COrderDetail> Get(string fOrderId)
        {
            var orderDetail = from o in db.tOrderDetail
                        select o;

            if (!string.IsNullOrEmpty(fOrderId)) 
            {
                orderDetail = orderDetail
                    .Where(o => o.fOrderId.Contains(fOrderId));
            }

            List<COrderDetail> orderDetailList = new List<COrderDetail>();
            foreach (tOrderDetail o in orderDetail) 
            {
                orderDetailList.Add(new COrderDetail(o));
            }

            return orderDetailList;
        }

        // POST: api/ApiOrder
        public int Post(tOrder o)
        {
            int n = 0;

            try
            {
                dbmyDBEntities db = new dbmyDBEntities();

                if (string.IsNullOrEmpty(o.fAddress)) 
                {
                    return n;
                }
                db.tOrder.Add(o);
                n = db.SaveChanges();
            }
            catch (Exception ex)
            {
                n = 0;
            }

            return n;
        }

        // PUT: api/ApiOrder/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ApiOrder/5
        public void Delete(int id)
        {
        }
    }
}
