using System.ComponentModel.DataAnnotations;

namespace RealEstateUploader.Core.Entities
{
    public class Property
    {
        [Key]
        public int ID { get; set; }
        [StringLength(250)]
        public string Address { get; set; }
        [StringLength(50)]
        public string AgencyCode { get; set; }
        [Required]
        [StringLength(150)]
        public string Name { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }

    }

}