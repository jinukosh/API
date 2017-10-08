using RealEstateUploader.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RealEstateUploader.Persistence.Queries
{
    public class GetAllPropertiesQuery
    {
        private readonly DomainRSDbContext _db;

        public GetAllPropertiesQuery(DomainRSDbContext db)
        {
            _db = db;
        }

        public IQueryable<Property> Execute()
        {
            return _db.Properties.AsQueryable();
        }
    }
}