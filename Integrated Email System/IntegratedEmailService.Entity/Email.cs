using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Runtime.Serialization;
using System.Text;

namespace IntegratedEmailService.Entity
{
    /// <summary>
    /// Email data container
    /// </summary>
    [DataContract]
    public class Email
    {
        /// <summary>
        /// Gets or sets the content.
        /// </summary>
        /// <value>
        /// The content.
        /// </value>
        [DataMember]
        public string Content { get; set; }

        /// <summary>
        /// Gets or sets from.
        /// </summary>
        /// <value>
        /// From.
        /// </value>
        [DataMember]
        public Contact From { get; set; }

        /// <summary>
        /// Gets or sets the CC.
        /// </summary>
        /// <value>
        /// The CC.
        /// </value>
        [DataMember]
        public List<Contact> CC { get; set; }

        /// <summary>
        /// Gets or sets the BCC.
        /// </summary>
        /// <value>
        /// The BCC.
        /// </value>
        [DataMember]
        public List<Contact> BCC { get; set; }

        /// <summary>
        /// Gets or sets the attachments.
        /// </summary>
        /// <value>
        /// The attachments.
        /// </value>
        [DataMember]
        public List<Attachment> Attachments { get; set; }
    }
}
