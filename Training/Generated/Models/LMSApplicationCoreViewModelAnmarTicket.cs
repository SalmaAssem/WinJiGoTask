// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace XWinji.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class LMSApplicationCoreViewModelAnmarTicket
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelAnmarTicket class.
        /// </summary>
        public LMSApplicationCoreViewModelAnmarTicket()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LMSApplicationCoreViewModelAnmarTicket class.
        /// </summary>
        public LMSApplicationCoreViewModelAnmarTicket(string ticketNumber = default(string), string ticketID = default(string), string state = default(string), string title = default(string), string body = default(string), string owner = default(string))
        {
            TicketNumber = ticketNumber;
            TicketID = ticketID;
            State = state;
            Title = title;
            Body = body;
            Owner = owner;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TicketNumber")]
        public string TicketNumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TicketID")]
        public string TicketID { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "State")]
        public string State { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Title")]
        public string Title { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Body")]
        public string Body { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Owner")]
        public string Owner { get; set; }

    }
}