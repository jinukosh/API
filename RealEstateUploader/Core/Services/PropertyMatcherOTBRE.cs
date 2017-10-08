using RealEstateUploader.Core.Entities;
using System;
using RealEstateUploader.Core.Services.Interfaces;

namespace RealEstateUploader.Core.Services
{
    public class PropertyMatcherOTBRE : IPropertyMatcher
    {
        public bool IsMatch(Property agencyProperty, Property databaseProperty)
        {
            if (String.Equals(agencyProperty.Address.CleanSpecialCharaters(), databaseProperty.Address.CleanWhiteSpace()))
                if (String.Equals(agencyProperty.Name.CleanSpecialCharaters(), databaseProperty.Name.CleanWhiteSpace()))
                    return true;
            return false;
        }
    }
}