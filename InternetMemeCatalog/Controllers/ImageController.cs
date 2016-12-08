using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InternetMemeCatalog.Models;

namespace InternetMemeCatalog.Controllers
{
    public class ImageController : Controller
    {
        //
        // GET: /Image/

        public ActionResult Index()
        {          

            HallmarkEntities1 hallmarkEntities = new HallmarkEntities1();
            List<Image> images = hallmarkEntities.Images.ToList();
            return View(images);
        }

        public ActionResult Genre()
        {
            HallmarkEntities1 hallmarkEntities = new HallmarkEntities1();
            var ImagesGrouped = from b in hallmarkEntities.Images
                                group b by b.Genre into g
                                select new Genre { Images = g, GenreName = g.Key };
            return View(ImagesGrouped.ToList());
        }


        public ActionResult Delete(int Id, string ControllerName)
        {
                HallmarkEntities1 hallmarkEntities = new HallmarkEntities1();
                Image img = hallmarkEntities.Images.Find(Id);
                hallmarkEntities.Images.Remove(img);
                hallmarkEntities.SaveChanges();           
            return RedirectToAction(ControllerName);
        }
    }
}
