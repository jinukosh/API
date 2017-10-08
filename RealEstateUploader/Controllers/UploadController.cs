using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace RealEstateUploader.Controllers
{
    public class UploadController : Controller
    {       
        [HttpGet]
        public ActionResult UploadFile()
        {
            return View();
        }

    }
}