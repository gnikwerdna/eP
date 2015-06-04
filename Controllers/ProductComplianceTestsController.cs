using eP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eP.Controllers
{
    public class ProductComplianceTestsController : Controller
    {

        private ProductDBContext db = new ProductDBContext();
        // GET: ProductComplianceTests
        public ActionResult Index()
        {
            
             var querydata = from p in db.Products
                             join cf in db.ProductComplianceforms
                             select p;
            
            return View();
        }


        
}
        public ActionResult Create()
        {
            return View();
        }

        // POST: Categories/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "answer")] ComplianceTest compliancetest)
        {
           

            return View();
        }
    }
}