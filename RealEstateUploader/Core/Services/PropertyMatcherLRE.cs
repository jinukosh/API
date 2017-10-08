using RealEstateUploader.Core.Entities;
using RealEstateUploader.Core.Services.Interfaces;
using System;

namespace RealEstateUploader.Core.Services
{
    public class PropertyMatcherLRE : IPropertyMatcher
    {
        public bool IsMatch(Property agencyProperty, Property databaseProperty)
        {
            if (String.Equals(agencyProperty.AgencyCode, databaseProperty.AgencyCode))
                if (agencyProperty.LatitudeLongitudeCompare(databaseProperty.Latitude, databaseProperty.Longitude))
                return true;
            return false;
        }
    }
}
             