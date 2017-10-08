using RealEstateUploader.Core.Services;
using RealEstateUploader.Core.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using RealEstateUploader.Core.Entities;
using RealEstateUploader.Core.Services.Enums;

namespace RealEstateUploader.Core.ViewModels
{
    public class PropertyViewModel
    {
        [Key]
        public int ID { get; set; }
        public string Address { get; set; }
        [Display(Name = "Agency Code")]
        public string AgencyCode { get; set; }
        public string Name { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        [Display(Name = "Duplicate Properity")]
        public bool IsDuplicate { get; set; }

        public List<PropertyViewModel> IsDuplicateProperity(IEnumerable<Property> agencyPropertiesFile, IEnumerable<Property> databaseProperties, IEnumerable<PropertyViewModel> propertyModelList, AgentCodeEnum propAgent)
        {
            IPropertyMatcher propertyMatcher;
            //This can be replaced with Factory Method
            switch (propAgent)
            {
                case  AgentCodeEnum.OTBRE:
                    propertyMatcher = new PropertyMatcherOTBRE();
                    break;
                case  AgentCodeEnum.CRE:
                    propertyMatcher = new PropertyMatcherCRE();
                    break;
                default:
                    propertyMatcher = new PropertyMatcherLRE();
                    break;
            }

            //This can be improved with LINQ
            foreach (var agencyProperty in agencyPropertiesFile)
            {
                foreach (var databaseProperty in databaseProperties)
                {
                    if (propertyMatcher.IsMatch(agencyProperty, databaseProperty))
                    {
                        propertyModelList
                            .FirstOrDefault(a => a.Name == agencyProperty.Name && a.Address == agencyProperty.Address)
                            .IsDuplicate = true;
                        break;
                    }

                }
            }

            return propertyModelList.ToList();
        }
    }


}