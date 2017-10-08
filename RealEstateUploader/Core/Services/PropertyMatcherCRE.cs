using RealEstateUploader.Core.Entities;
using RealEstateUploader.Core.Services.Interfaces;
using System;

namespace RealEstateUploader.Core.Services
{
    public class PropertyMatcherCRE : IPropertyMatcher
    {
        public bool IsMatch(Property agencyProperty, Property databaseProperty)
        {            
            if (String.Equals(agencyProperty.Name.StringReverse(), databaseProperty.Name))
                return true;
            return false;
        }
    }
}
