using RealEstateUploader.Core.Models.Services.Factory;
using RealEstateUploader.Core.Services.Interfaces;
using System.Web.Mvc;

namespace RealEstateUploader.Controllers
{
    public abstract class BaseController : Controller
    {
        IPropertiesService _queryService;
        ModelFactory _modelFactory;

        public BaseController(IPropertiesService qServ)
        {
            _queryService = qServ;
        }

        protected IPropertiesService TheQueryService
        {
            get
            {
                return _queryService;
            }
        }

        protected ModelFactory TheModelFactory
        {
            get
            {
                if (_modelFactory == null)
                {
                    _modelFactory = new ModelFactory(TheQueryService);
                }
                return _modelFactory;
            }
        }
    }
}
