using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace IntegratedEmailService.Entity
{
    [DataContract]
    public class Contact
    {
        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>
        /// The first name.
        /// </value>
        [DataMember]
        [Required]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>
        /// The last name.
        /// </value>
        [DataMember]
        [Required]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the email address.
        /// </summary>
        /// <value>
        /// The email address.
        /// </value>
        [DataMember]
        [Required]
        public string EmailAddress { get; set; }
    }
}
