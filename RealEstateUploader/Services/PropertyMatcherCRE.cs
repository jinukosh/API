using RealEstateUploader.Core.Entities;
using RealEstateUploader.Core.Services.Interfaces;
using System;

namespace RealEstateUploader.Services
{
    public class PropertyMatcherCRE : IPropertyMatcher
    {
        public bool IsMatch(Property agencyProperty, Property databaseProperty)
        {
            throw new NotImplementedException();
        }
    }
}