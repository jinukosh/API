using RealEstateUploader.Core.Entities;
using RealEstateUploader.Core.Services.Interfaces;
using RealEstateUploader.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web.Mvc;
using System.Xml.Linq;

namespace RealEstateUploader.Controllers
{
    public class UploadController : BaseController
    {
        public UploadController(IPropertiesService service) : base(service) { }

        [HttpGet]
        public ActionResult UploadFile()
        {
            var propModel = new FileUploadViewModel();
            return View(propModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult UploadFile(FileUploadViewModel uploadModel)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            try
            {
                if (uploadModel.File.ContentLength > 0)
                {
                    var agencyPropertiesFile = new List<Property>();
                    using (var xmlReader = new StreamReader(uploadModel.File.InputStream))
                    {
                        var doc = XDocument.Load(xmlReader);
                        agencyPropertiesFile = doc.Descendants("Property")
                                            .Select(p => TheModelFactory.CreateProperty(p))
                                            .ToList();
                    }

                    var databaseProperties = TheQueryService.All(uploadModel.PropertyType);

                    var propertyModelList = agencyPropertiesFile
                                                    .Select(p => TheModelFactory.CreatePropertyModel(p))
                                                    .ToList();

                    var properityViewModel = new PropertyViewModel();
                    propertyModelList = properityViewModel.IsDuplicateProperity(agencyPropertiesFile, databaseProperties, propertyModelList, uploadModel.PropertyType);
                    TempData["propModel"] = propertyModelList;
                    return RedirectToAction("Display");
                }
                return View();
            }
            catch(Exception ex)
            {
                ViewBag.Message = "File Upload failed!!!!!" + ex.ToString();
                return View();
            }

        }

        public ActionResult Display()
        {
            var propModel = TempData["propModel"] as List<PropertyViewModel>;
            return View(propModel);
        }
    }
}