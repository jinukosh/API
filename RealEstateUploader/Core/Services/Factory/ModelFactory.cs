using RealEstateUploader.Core.Entities;
using RealEstateUploader.Core.Services.Interfaces;
using RealEstateUploader.Core.ViewModels;
using System.Xml.Linq;

namespace RealEstateUploader.Core.Models.Services.Factory
{
    public class ModelFactory
    {
        private IPropertiesService _queryService;
        public ModelFactory(IPropertiesService qService)
        {
            _queryService = qService; 
        }

        public Property CreateProperty(XElement property)
        {
            return new Property() 
            {
                Address = property.Element("Address").Value,
                AgencyCode = property.Element("AgencyCode").Value,
                Name = property.Element("Name").Value,
                Latitude = decimal.Parse(property.Element("Latitude").Value),
                Longitude = decimal.Parse(property.Element("Longitude").Value),
            };
        }

        public PropertyViewModel CreatePropertyModel(Property property)
        {
            return new PropertyViewModel()
            { 
                ID = property.ID,
                Address = property.Address,
                AgencyCode = property.AgencyCode,
                Name = property.Name,
                Latitude = property.Latitude,
                Longitude = property.Longitude,
                IsDuplicate = false
            };
        }
    }
}