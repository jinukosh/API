using RealEstateUploader.Core.Entities;

namespace RealEstateUploader.Core.Services.Interfaces
{
    public interface IPropertyMatcher
    {
        bool IsMatch(Property agencyProperty, Property databaseProperty);
    }
}