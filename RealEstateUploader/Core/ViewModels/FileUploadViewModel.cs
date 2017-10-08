using RealEstateUploader.Core.Services.Enums;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace RealEstateUploader.Core.ViewModels
{
    public class FileUploadViewModel
    {
        [Required(ErrorMessage = "Select a file")]
        public HttpPostedFileBase File { get; set; }

        [Required(ErrorMessage = "Select a property type")]
        [Range(0, 2, ErrorMessage = "Select a valid property type")]
        public AgentCodeEnum PropertyType { get; set; }


    }
}