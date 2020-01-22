using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Web;
using ProjectDemo.Model;

namespace ProjectDemo.Properties.Controllers
{
    public class selCon : Controller
    {
        //Iseller Is = new sellerbo();
        private readonly Iseller sellerbo;
        public selCon(Iseller sellerb)
        {
            sellerbo = sellerb;
        }
        //public string Search()
        //{
        //    seller s = Is.GetSeller("007");
        //    return s.Name1 + "\n" + s.Id1 + "\n" + s.Address1 + "\n" + s.Moblie1 + "\n" + s.Company1;
        //}
        public IActionResult Search(int? id)
        {
            int Id = (int)((id == null) ? 1 : id);

            seller se = sellerbo.GetSeller(Id);
            //if(se!=null)
            //{
            //    return Content(se.Name1+"\n"+se.Id1+"\n"+se.Address1+"\n"+se.Moblie1+"\n"+se.Company1);

            //}
            return View(se);
        }
        public IActionResult Index()
        {
            List<seller> se = sellerbo.Display();
            return View(se);
        }
        //public IActionResult GetAllSeller()
        //{
        //    List<seller> se=(sellerbo.Display().Where(e=>e.post))
        //}


    }
}
