using CheckInApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CheckInApp.Controllers
{
     
    public class FamilyController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<Family> Get()
        {
            using (var model = new Models.CheckInAppEntities())
            {
                var list = new List<Family>();
                var name=Request.GetQueryNameValuePairs().Where(x=>x.Key=="name").First().Value;
                var query = model.Families.Where(x => x.Name.StartsWith(name));
                foreach (var item in query)
                {
                    var fam = new Family() { Name = item.Name,ID=item.ID  };
                    list.Add(fam);
                }
                return list;
            }
             
        }

        // GET api/<controller>/5
        public Family Get(int id)
        {
             
            var fam = new Family() { Name = "Freemans" };
            return fam;
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}