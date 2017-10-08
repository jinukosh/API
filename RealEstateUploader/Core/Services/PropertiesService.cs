using RealEstateUploader.Core.Entities;
using RealEstateUploader.Core.Services.Enums;
using RealEstateUploader.Core.Services.Interfaces;
using RealEstateUploader.Persistence.Queries;
using System.Collections.Generic;
using System.Linq;

namespace RealEstateUploader.Core.Services
{
    public class PropertiesService : IPropertiesService
    {
        private readonly GetAllPropertiesQuery _query;

        public PropertiesService(GetAllPropertiesQuery query)
        {
            _query = query;
        }

        /// <summary>
        /// Lists all Properties that exist in db
        /// </summary>
        public IEnumerable<Property> All(AgentCodeEnum agentCode)
        {
            return _query.Execute()
                         .Where(q => q.AgencyCode == agentCode.ToString())
                         .ToList();
        }
    }
}