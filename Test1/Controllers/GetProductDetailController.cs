using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test1.Models;

namespace Test1.Controllers
{
    public class GetProductDetailController : Controller
    {
        // GET: GetProductDetail
        [HttpGet]
        public ActionResult Index(int id)
        {
            var db = new PharmacyEntities();
            var model = db.Products.Find(id);
            var detail = new ProductDetailModel()
            {
                id = model.ID,
                ProductName = model.ProductName,
                Unit= model.Unit,
                Price = model.Buy,
                Category = model.Category.CateName,
                Barcode = model.Barcode,
                uuid = System.Guid.NewGuid().ToString()
            };
            return Json(detail, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult Barcode(string Barcode)
        {
            var db = new PharmacyEntities();
            var model = db.Products.Where(x => x.Barcode == Barcode).FirstOrDefault();
            try
            {
                var detail = new ProductDetailModel()
                {
                    id = model.ID,
                    ProductName = model.ProductName,
                    Unit = model.Unit,
                    Price = model.Buy,
                    Barcode = model.Barcode,
                    uuid = System.Guid.NewGuid().ToString()
                };
                return Json(detail, JsonRequestBehavior.AllowGet);
            }
            catch (Exception)
            {
                var detail = new ProductDetailModel();
                return Json(detail, JsonRequestBehavior.AllowGet);
            }
            
        }


    }

    public class ProductDetailModel{
        public int id { get; set; }
        public string ProductName { get; set; }
        public string  Unit { get; set; }
        public int? Price { get; set; }
        public int Discount { get; set; }
        public string Category { get; set; }

        public string Barcode { get; set; }

        public string uuid { get; set; }
    }
}