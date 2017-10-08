using RealEstateUploader.Core.Services;
using RealEstateUploader.Core.Services.Enums;
using RealEstateUploader.Core.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace RealEstateUploader.Controllers
{
    public class UploadController : Controller
    {
        PropertiesService _queryService;

        public UploadController(PropertiesService qServ)
        {
            _queryService = qServ;
        }

        [HttpGet]
        public ActionResult UploadFile()
        {
            var databaseProperties = _queryService.All(AgentCodeEnum.CRE);
            return View();
        }

    }
}