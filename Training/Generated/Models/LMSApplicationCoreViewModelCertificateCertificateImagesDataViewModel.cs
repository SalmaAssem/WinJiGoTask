// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace XWinji.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class LMSApplicationCoreViewModelCertificateCertificateImagesDataViewModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelCertificateCertificateImagesDataViewModel
        /// class.
        /// </summary>
        public LMSApplicationCoreViewModelCertificateCertificateImagesDataViewModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelCertificateCertificateImagesDataViewModel
        /// class.
        /// </summary>
        public LMSApplicationCoreViewModelCertificateCertificateImagesDataViewModel(string imageUrl = default(string), string imageData = default(string))
        {
            ImageUrl = imageUrl;
            ImageData = imageData;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ImageUrl")]
        public string ImageUrl { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ImageData")]
        public string ImageData { get; set; }

    }
}