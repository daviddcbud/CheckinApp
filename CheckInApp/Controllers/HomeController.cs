using CheckInApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CheckInApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Print(int id)
        {
            var vm = new PrintVM();
            vm.Name = "Lanie Freeman";
            vm.Number = "55-1";
            vm.Message = "";
            vm.DateTime = DateTime.Now;
            var list = new List<PrintVM>();
            list.Add(vm);

            vm = new PrintVM();
            vm.Name = "Leah Freeman";
            vm.Number = "55-2";
            vm.Message = "Allergies: Peanuts";
            vm.DateTime = DateTime.Now;
             
            list.Add(vm);
            return View(list);
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}