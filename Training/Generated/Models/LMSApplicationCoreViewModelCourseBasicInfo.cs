// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace XWinji.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class LMSApplicationCoreViewModelCourseBasicInfo
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelCourseBasicInfo class.
        /// </summary>
        public LMSApplicationCoreViewModelCourseBasicInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelCourseBasicInfo class.
        /// </summary>
        public LMSApplicationCoreViewModelCourseBasicInfo(int? courseId = default(int?), string courseName = default(string), string subject = default(string), IList<LMSDomainCoreModelsGrade> grades = default(IList<LMSDomainCoreModelsGrade>), double? rate = default(double?), double? numberOfRaters = default(double?), string instructorName = default(string), int? instructorId = default(int?), string courseImageUrl = default(string), LMSDomainCoreModelsGrade minGrade = default(LMSDomainCoreModelsGrade), LMSDomainCoreModelsGrade maxGrade = default(LMSDomainCoreModelsGrade), bool? isMember = default(bool?), string organizationName = default(string), string videoUrl = default(string), bool? isArchived = default(bool?))
        {
            CourseId = courseId;
            CourseName = courseName;
            Subject = subject;
            Grades = grades;
            Rate = rate;
            NumberOfRaters = numberOfRaters;
            InstructorName = instructorName;
            InstructorId = instructorId;
            CourseImageUrl = courseImageUrl;
            MinGrade = minGrade;
            MaxGrade = maxGrade;
            IsMember = isMember;
            OrganizationName = organizationName;
            VideoUrl = videoUrl;
            IsArchived = isArchived;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CourseId")]
        public int? CourseId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CourseName")]
        public string CourseName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Subject")]
        public string Subject { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Grades")]
        public IList<LMSDomainCoreModelsGrade> Grades { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Rate")]
        public double? Rate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "NumberOfRaters")]
        public double? NumberOfRaters { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "InstructorName")]
        public string InstructorName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "InstructorId")]
        public int? InstructorId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CourseImageUrl")]
        public string CourseImageUrl { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "MinGrade")]
        public LMSDomainCoreModelsGrade MinGrade { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "MaxGrade")]
        public LMSDomainCoreModelsGrade MaxGrade { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsMember")]
        public bool? IsMember { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "OrganizationName")]
        public string OrganizationName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "VideoUrl")]
        public string VideoUrl { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsArchived")]
        public bool? IsArchived { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Grades != null)
            {
                foreach (var element in Grades)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (MinGrade != null)
            {
                MinGrade.Validate();
            }
            if (MaxGrade != null)
            {
                MaxGrade.Validate();
            }
        }
    }
}
