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
        public IEnumerable<FamilyVM> Get()
        {
            using (var model = new Models.CheckInAppEntities())
            {
                var list = new List<FamilyVM>();
                var name=Request.GetQueryNameValuePairs().Where(x=>x.Key=="name").First().Value;
                if(string.IsNullOrEmpty(name))
                {
                    return new List<FamilyVM>();
                }
                IQueryable<Family> query;
                int result = 0;
                if (int.TryParse(name, out result))
                {
                    query = model.Families.Include("Children").Where(x => x.Number== result);
                }
                else
                {
                    query = model.Families.Include("Children").Where(x => x.LastName.StartsWith(name));
                }
                foreach (var item in query)
                {
                    var vm = new FamilyVM();
                    vm.Id = item.ID;
                    vm.Name = item.Name;
                    vm.Number = item.Number;
                    list.Add(vm);
                    foreach(var child in item.Children )
                    {
                        var childVm = new ChildVM();
                        childVm.Id = child.ID;
                        childVm.Name = child.Name;
                        childVm.Grade = child.Grade;
                        childVm.Age = child.Age;
                        childVm.DOB = child.DOB;
                        vm.Children.Add(childVm);

                         
                    }
                      
 
                }
                return list;
            }
             
        }

        // GET api/<controller>/5
        public Family Get(int id)
        {
             
            var fam = new Family() { LastName = "Freemans" };
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