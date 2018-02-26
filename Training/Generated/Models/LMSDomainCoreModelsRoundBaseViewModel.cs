// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace XWinji.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class LMSDomainCoreModelsRoundBaseViewModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSDomainCoreModelsRoundBaseViewModel class.
        /// </summary>
        public LMSDomainCoreModelsRoundBaseViewModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSDomainCoreModelsRoundBaseViewModel class.
        /// </summary>
        public LMSDomainCoreModelsRoundBaseViewModel(int? id = default(int?), string name = default(string), int? status = default(int?), System.DateTime? date = default(System.DateTime?), double? rate = default(double?), int? maxCapacity = default(int?), string location = default(string), int? numberOfRaters = default(int?), int? numberOfMembers = default(int?), bool? isOriginal = default(bool?), bool? isEnableAttendance = default(bool?), bool? isEnableTakeAttendance = default(bool?), bool? isArchived = default(bool?))
        {
            Id = id;
            Name = name;
            Status = status;
            Date = date;
            Rate = rate;
            MaxCapacity = maxCapacity;
            Location = location;
            NumberOfRaters = numberOfRaters;
            NumberOfMembers = numberOfMembers;
            IsOriginal = isOriginal;
            IsEnableAttendance = isEnableAttendance;
            IsEnableTakeAttendance = isEnableTakeAttendance;
            IsArchived = isArchived;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public int? Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Status")]
        public int? Status { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Date")]
        public System.DateTime? Date { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Rate")]
        public double? Rate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "MaxCapacity")]
        public int? MaxCapacity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Location")]
        public string Location { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "NumberOfRaters")]
        public int? NumberOfRaters { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "NumberOfMembers")]
        public int? NumberOfMembers { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsOriginal")]
        public bool? IsOriginal { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsEnableAttendance")]
        public bool? IsEnableAttendance { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsEnableTakeAttendance")]
        public bool? IsEnableTakeAttendance { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsArchived")]
        public bool? IsArchived { get; set; }

    }
}