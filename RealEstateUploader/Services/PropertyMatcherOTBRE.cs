using RealEstateUploader.Core.Entities;
using System;
using RealEstateUploader.Core.Services.Interfaces;

namespace RealEstateUploader.Core.Services
{
    public class PropertyMatcherOTBRE : IPropertyMatcher
    {
        public bool IsMatch(Property agencyProperty, Property databaseProperty)
        {
            throw new NotImplementedException();
        }
    }
}