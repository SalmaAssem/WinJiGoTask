// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace XWinji
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Models;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;

    public partial class LMSWebCore : ServiceClient<LMSWebCore>, ILMSWebCore
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        public System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        public JsonSerializerSettings SerializationSettings { get; private set; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        public JsonSerializerSettings DeserializationSettings { get; private set; }

        /// <summary>
        /// Gets the IAlbumApi.
        /// </summary>
        public virtual IAlbumApi AlbumApi { get; private set; }

        /// <summary>
        /// Gets the IAnmmarApi.
        /// </summary>
        public virtual IAnmmarApi AnmmarApi { get; private set; }

        /// <summary>
        /// Gets the IAnnouncementApi.
        /// </summary>
        public virtual IAnnouncementApi AnnouncementApi { get; private set; }

        /// <summary>
        /// Gets the IAssessmentsMessages.
        /// </summary>
        public virtual IAssessmentsMessages AssessmentsMessages { get; private set; }

        /// <summary>
        /// Gets the IAttendanceApi.
        /// </summary>
        public virtual IAttendanceApi AttendanceApi { get; private set; }

        /// <summary>
        /// Gets the IAuthorizationApi.
        /// </summary>
        public virtual IAuthorizationApi AuthorizationApi { get; private set; }

        /// <summary>
        /// Gets the IBadgeApi.
        /// </summary>
        public virtual IBadgeApi BadgeApi { get; private set; }

        /// <summary>
        /// Gets the IBehaviourApi.
        /// </summary>
        public virtual IBehaviourApi BehaviourApi { get; private set; }

        /// <summary>
        /// Gets the ICalendarApi.
        /// </summary>
        public virtual ICalendarApi CalendarApi { get; private set; }

        /// <summary>
        /// Gets the ICertificateApi.
        /// </summary>
        public virtual ICertificateApi CertificateApi { get; private set; }

        /// <summary>
        /// Gets the IClassApi.
        /// </summary>
        public virtual IClassApi ClassApi { get; private set; }

        /// <summary>
        /// Gets the IConfigurationMangerApi.
        /// </summary>
        public virtual IConfigurationMangerApi ConfigurationMangerApi { get; private set; }

        /// <summary>
        /// Gets the ICopyApi.
        /// </summary>
        public virtual ICopyApi CopyApi { get; private set; }

        /// <summary>
        /// Gets the ICourseApi.
        /// </summary>
        public virtual ICourseApi CourseApi { get; private set; }

        /// <summary>
        /// Gets the ICourseCatalogueApi.
        /// </summary>
        public virtual ICourseCatalogueApi CourseCatalogueApi { get; private set; }

        /// <summary>
        /// Gets the ICourseGroupAuthors.
        /// </summary>
        public virtual ICourseGroupAuthors CourseGroupAuthors { get; private set; }

        /// <summary>
        /// Gets the ICourseImageApi.
        /// </summary>
        public virtual ICourseImageApi CourseImageApi { get; private set; }

        /// <summary>
        /// Gets the ICourseRequestsApi.
        /// </summary>
        public virtual ICourseRequestsApi CourseRequestsApi { get; private set; }

        /// <summary>
        /// Gets the ICoursesProgress.
        /// </summary>
        public virtual ICoursesProgress CoursesProgress { get; private set; }

        /// <summary>
        /// Gets the IDiscussionApi.
        /// </summary>
        public virtual IDiscussionApi DiscussionApi { get; private set; }

        /// <summary>
        /// Gets the IEduShareApi.
        /// </summary>
        public virtual IEduShareApi EduShareApi { get; private set; }

        /// <summary>
        /// Gets the IEvaluationApi.
        /// </summary>
        public virtual IEvaluationApi EvaluationApi { get; private set; }

        /// <summary>
        /// Gets the IEventApi.
        /// </summary>
        public virtual IEventApi EventApi { get; private set; }

        /// <summary>
        /// Gets the IFileApi.
        /// </summary>
        public virtual IFileApi FileApi { get; private set; }

        /// <summary>
        /// Gets the IFormsTemplatesApi.
        /// </summary>
        public virtual IFormsTemplatesApi FormsTemplatesApi { get; private set; }

        /// <summary>
        /// Gets the IGradeApi.
        /// </summary>
        public virtual IGradeApi GradeApi { get; private set; }

        /// <summary>
        /// Gets the IGradeBookApi.
        /// </summary>
        public virtual IGradeBookApi GradeBookApi { get; private set; }

        /// <summary>
        /// Gets the IHelpApi.
        /// </summary>
        public virtual IHelpApi HelpApi { get; private set; }

        /// <summary>
        /// Gets the IIenApi.
        /// </summary>
        public virtual IIenApi IenApi { get; private set; }

        /// <summary>
        /// Gets the IInvitationApi.
        /// </summary>
        public virtual IInvitationApi InvitationApi { get; private set; }

        /// <summary>
        /// Gets the IInviteApi.
        /// </summary>
        public virtual IInviteApi InviteApi { get; private set; }

        /// <summary>
        /// Gets the ILanguageApi.
        /// </summary>
        public virtual ILanguageApi LanguageApi { get; private set; }

        /// <summary>
        /// Gets the ILearningObjectivesApi.
        /// </summary>
        public virtual ILearningObjectivesApi LearningObjectivesApi { get; private set; }

        /// <summary>
        /// Gets the ILearningPathApi.
        /// </summary>
        public virtual ILearningPathApi LearningPathApi { get; private set; }

        /// <summary>
        /// Gets the ILTILMSConsumerApi.
        /// </summary>
        public virtual ILTILMSConsumerApi LTILMSConsumerApi { get; private set; }

        /// <summary>
        /// Gets the IMaterialApi.
        /// </summary>
        public virtual IMaterialApi MaterialApi { get; private set; }

        /// <summary>
        /// Gets the IMaterialSeenByUser.
        /// </summary>
        public virtual IMaterialSeenByUser MaterialSeenByUser { get; private set; }

        /// <summary>
        /// Gets the IMembersApi.
        /// </summary>
        public virtual IMembersApi MembersApi { get; private set; }

        /// <summary>
        /// Gets the IMentorApi.
        /// </summary>
        public virtual IMentorApi MentorApi { get; private set; }

        /// <summary>
        /// Gets the INotificationsApi.
        /// </summary>
        public virtual INotificationsApi NotificationsApi { get; private set; }

        /// <summary>
        /// Gets the IOfferApi.
        /// </summary>
        public virtual IOfferApi OfferApi { get; private set; }

        /// <summary>
        /// Gets the IOffice365.
        /// </summary>
        public virtual IOffice365 Office365 { get; private set; }

        /// <summary>
        /// Gets the IOfficeAddInApi.
        /// </summary>
        public virtual IOfficeAddInApi OfficeAddInApi { get; private set; }

        /// <summary>
        /// Gets the IOnenote.
        /// </summary>
        public virtual IOnenote Onenote { get; private set; }

        /// <summary>
        /// Gets the IOrganizationUserAPI.
        /// </summary>
        public virtual IOrganizationUserAPI OrganizationUserAPI { get; private set; }

        /// <summary>
        /// Gets the IOutcomesApi.
        /// </summary>
        public virtual IOutcomesApi OutcomesApi { get; private set; }

        /// <summary>
        /// Gets the IPointsApi.
        /// </summary>
        public virtual IPointsApi PointsApi { get; private set; }

        /// <summary>
        /// Gets the IPollApi.
        /// </summary>
        public virtual IPollApi PollApi { get; private set; }

        /// <summary>
        /// Gets the IPrerequisitesApi.
        /// </summary>
        public virtual IPrerequisitesApi PrerequisitesApi { get; private set; }

        /// <summary>
        /// Gets the IQtiInteroperability.
        /// </summary>
        public virtual IQtiInteroperability QtiInteroperability { get; private set; }

        /// <summary>
        /// Gets the IQuestionBankApi.
        /// </summary>
        public virtual IQuestionBankApi QuestionBankApi { get; private set; }

        /// <summary>
        /// Gets the IReflectionApi.
        /// </summary>
        public virtual IReflectionApi ReflectionApi { get; private set; }

        /// <summary>
        /// Gets the IRelatedCoursesApi.
        /// </summary>
        public virtual IRelatedCoursesApi RelatedCoursesApi { get; private set; }

        /// <summary>
        /// Gets the IReportApi.
        /// </summary>
        public virtual IReportApi ReportApi { get; private set; }

        /// <summary>
        /// Gets the IRoleManagementApi.
        /// </summary>
        public virtual IRoleManagementApi RoleManagementApi { get; private set; }

        /// <summary>
        /// Gets the IScheduleVisitApi.
        /// </summary>
        public virtual IScheduleVisitApi ScheduleVisitApi { get; private set; }

        /// <summary>
        /// Gets the ISchoolTypeApi.
        /// </summary>
        public virtual ISchoolTypeApi SchoolTypeApi { get; private set; }

        /// <summary>
        /// Gets the ISessionApi.
        /// </summary>
        public virtual ISessionApi SessionApi { get; private set; }

        /// <summary>
        /// Gets the ISpaceApi.
        /// </summary>
        public virtual ISpaceApi SpaceApi { get; private set; }

        /// <summary>
        /// Gets the IStudentApi.
        /// </summary>
        public virtual IStudentApi StudentApi { get; private set; }

        /// <summary>
        /// Gets the ISubjectApi.
        /// </summary>
        public virtual ISubjectApi SubjectApi { get; private set; }

        /// <summary>
        /// Gets the ISystemAdministrationApi.
        /// </summary>
        public virtual ISystemAdministrationApi SystemAdministrationApi { get; private set; }

        /// <summary>
        /// Gets the ISystemReportsApi.
        /// </summary>
        public virtual ISystemReportsApi SystemReportsApi { get; private set; }

        /// <summary>
        /// Gets the ITagsApi.
        /// </summary>
        public virtual ITagsApi TagsApi { get; private set; }

        /// <summary>
        /// Gets the IThemes.
        /// </summary>
        public virtual IThemes Themes { get; private set; }

        /// <summary>
        /// Gets the ITimeTableApi.
        /// </summary>
        public virtual ITimeTableApi TimeTableApi { get; private set; }

        /// <summary>
        /// Gets the IToolConsumerProfileApi.
        /// </summary>
        public virtual IToolConsumerProfileApi ToolConsumerProfileApi { get; private set; }

        /// <summary>
        /// Gets the ITourApi.
        /// </summary>
        public virtual ITourApi TourApi { get; private set; }

        /// <summary>
        /// Gets the ITrackApi.
        /// </summary>
        public virtual ITrackApi TrackApi { get; private set; }

        /// <summary>
        /// Gets the ITrainingPlanApi.
        /// </summary>
        public virtual ITrainingPlanApi TrainingPlanApi { get; private set; }

        /// <summary>
        /// Gets the IUserApi.
        /// </summary>
        public virtual IUserApi UserApi { get; private set; }

        /// <summary>
        /// Gets the IUserProfileApi.
        /// </summary>
        public virtual IUserProfileApi UserProfileApi { get; private set; }

        /// <summary>
        /// Gets the IUserProgressApi.
        /// </summary>
        public virtual IUserProgressApi UserProgressApi { get; private set; }

        /// <summary>
        /// Gets the IUserSettingsApi.
        /// </summary>
        public virtual IUserSettingsApi UserSettingsApi { get; private set; }

        /// <summary>
        /// Gets the IWallApi.
        /// </summary>
        public virtual IWallApi WallApi { get; private set; }

        /// <summary>
        /// Initializes a new instance of the LMSWebCore class.
        /// </summary>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        public LMSWebCore(params DelegatingHandler[] handlers) : base(handlers)
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the LMSWebCore class.
        /// </summary>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        public LMSWebCore(HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : base(rootHandler, handlers)
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the LMSWebCore class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public LMSWebCore(System.Uri baseUri, params DelegatingHandler[] handlers) : this(handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            BaseUri = baseUri;
        }

        /// <summary>
        /// Initializes a new instance of the LMSWebCore class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public LMSWebCore(System.Uri baseUri, HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : this(rootHandler, handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            BaseUri = baseUri;
        }

        /// <summary>
        /// An optional partial-method to perform custom initialization.
        ///</summary>
        partial void CustomInitialize();
        /// <summary>
        /// Initializes client properties.
        /// </summary>
        private void Initialize()
        {
            AlbumApi = new AlbumApi(this);
            AnmmarApi = new AnmmarApi(this);
            AnnouncementApi = new AnnouncementApi(this);
            AssessmentsMessages = new AssessmentsMessages(this);
            AttendanceApi = new AttendanceApi(this);
            AuthorizationApi = new AuthorizationApi(this);
            BadgeApi = new BadgeApi(this);
            BehaviourApi = new BehaviourApi(this);
            CalendarApi = new CalendarApi(this);
            CertificateApi = new CertificateApi(this);
            ClassApi = new ClassApi(this);
            ConfigurationMangerApi = new ConfigurationMangerApi(this);
            CopyApi = new CopyApi(this);
            CourseApi = new CourseApi(this);
            CourseCatalogueApi = new CourseCatalogueApi(this);
            CourseGroupAuthors = new CourseGroupAuthors(this);
            CourseImageApi = new CourseImageApi(this);
            CourseRequestsApi = new CourseRequestsApi(this);
            CoursesProgress = new CoursesProgress(this);
            DiscussionApi = new DiscussionApi(this);
            EduShareApi = new EduShareApi(this);
            EvaluationApi = new EvaluationApi(this);
            EventApi = new EventApi(this);
            FileApi = new FileApi(this);
            FormsTemplatesApi = new FormsTemplatesApi(this);
            GradeApi = new GradeApi(this);
            GradeBookApi = new GradeBookApi(this);
            HelpApi = new HelpApi(this);
            IenApi = new IenApi(this);
            InvitationApi = new InvitationApi(this);
            InviteApi = new InviteApi(this);
            LanguageApi = new LanguageApi(this);
            LearningObjectivesApi = new LearningObjectivesApi(this);
            LearningPathApi = new LearningPathApi(this);
            LTILMSConsumerApi = new LTILMSConsumerApi(this);
            MaterialApi = new MaterialApi(this);
            MaterialSeenByUser = new MaterialSeenByUser(this);
            MembersApi = new MembersApi(this);
            MentorApi = new MentorApi(this);
            NotificationsApi = new NotificationsApi(this);
            OfferApi = new OfferApi(this);
            Office365 = new Office365(this);
            OfficeAddInApi = new OfficeAddInApi(this);
            Onenote = new Onenote(this);
            OrganizationUserAPI = new OrganizationUserAPI(this);
            OutcomesApi = new OutcomesApi(this);
            PointsApi = new PointsApi(this);
            PollApi = new PollApi(this);
            PrerequisitesApi = new PrerequisitesApi(this);
            QtiInteroperability = new QtiInteroperability(this);
            QuestionBankApi = new QuestionBankApi(this);
            ReflectionApi = new ReflectionApi(this);
            RelatedCoursesApi = new RelatedCoursesApi(this);
            ReportApi = new ReportApi(this);
            RoleManagementApi = new RoleManagementApi(this);
            ScheduleVisitApi = new ScheduleVisitApi(this);
            SchoolTypeApi = new SchoolTypeApi(this);
            SessionApi = new SessionApi(this);
            SpaceApi = new SpaceApi(this);
            StudentApi = new StudentApi(this);
            SubjectApi = new SubjectApi(this);
            SystemAdministrationApi = new SystemAdministrationApi(this);
            SystemReportsApi = new SystemReportsApi(this);
            TagsApi = new TagsApi(this);
            Themes = new Themes(this);
            TimeTableApi = new TimeTableApi(this);
            ToolConsumerProfileApi = new ToolConsumerProfileApi(this);
            TourApi = new TourApi(this);
            TrackApi = new TrackApi(this);
            TrainingPlanApi = new TrainingPlanApi(this);
            UserApi = new UserApi(this);
            UserProfileApi = new UserProfileApi(this);
            UserProgressApi = new UserProgressApi(this);
            UserSettingsApi = new UserSettingsApi(this);
            WallApi = new WallApi(this);
            BaseUri = new System.Uri("https://xwinji.azurewebsites.net");
            SerializationSettings = new JsonSerializerSettings
            {
                Formatting = Newtonsoft.Json.Formatting.Indented,
                DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc,
                NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Serialize,
                ContractResolver = new ReadOnlyJsonContractResolver(),
                Converters = new  List<JsonConverter>
                    {
                        new Iso8601TimeSpanConverter()
                    }
            };
            DeserializationSettings = new JsonSerializerSettings
            {
                DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc,
                NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Serialize,
                ContractResolver = new ReadOnlyJsonContractResolver(),
                Converters = new List<JsonConverter>
                    {
                        new Iso8601TimeSpanConverter()
                    }
            };
            CustomInitialize();
        }
    }
}