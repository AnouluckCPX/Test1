using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test1.Models;

namespace Test1.Controllers
{
    public class GenBarcodeController : Controller
    {
        // GET: GenBarcode
        [HttpGet]
        public ActionResult Index()
        {
            var db = new PharmacyEntities();
            var model = db.Products.Where(x => x.Barcode != null).ToList();
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(string barcode)
        {
            //using (MemoryStream memoryStream = new MemoryStream())
            //{
            //    using (Bitmap bitMap = new Bitmap(barcode.Length * 40, 80))
            //    {
            //        using (Graphics graphics = Graphics.FromImage(bitMap))
            //        {
            //            Font oFont = new Font("IDAutomationHC39M", 16);
            //            PointF point = new PointF(2f, 2f);
            //            SolidBrush whiteBrush = new SolidBrush(Color.White);
            //            graphics.FillRectangle(whiteBrush, 0, 0, bitMap.Width, bitMap.Height);
            //            SolidBrush blackBrush = new SolidBrush(Color.DarkBlue);
            //            graphics.DrawString("*" + barcode + "*", oFont, blackBrush, point);
            //        }

            //        bitMap.Save(memoryStream, ImageFormat.Jpeg);

            //        ViewBag.BarcodeImage = "data:image/png;base64," + Convert.ToBase64String(memoryStream.ToArray());
            //    }
            //}

            ViewBag.Barcode = barcode;

            var db = new PharmacyEntities();
            var model = db.Products.Where(x => x.Barcode != null).ToList();
            return View(model);
        }
    }
}