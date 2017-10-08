using RealEstateUploader.Core.Entities;
using RealEstateUploader.Core.Services.Enums;
using System.Collections.Generic;

namespace RealEstateUploader.Core.Services.Interfaces
{
    public interface IPropertiesService
    {
        IEnumerable<Property> All(AgentCodeEnum agentCode);
    }
}