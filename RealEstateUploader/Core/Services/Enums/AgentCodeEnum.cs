using System.ComponentModel.DataAnnotations;

namespace RealEstateUploader.Core.Services.Enums
{
    public enum AgentCodeEnum
    { 
        [Display(Name = "Only The Best Real Estate")]
        OTBRE,
        [Display(Name = "Location Real Estate")]
        LRE,
        [Display(Name = "Contrary Real Estate")]
        CRE
    }
}