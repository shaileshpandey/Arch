using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntegratedEmailService.Entity
{
    /// <summary>
    /// 
    /// </summary>
    public class ServiceFault
    {
        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        /// <value>
        /// The message.
        /// </value>
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets the name of the field.
        /// </summary>
        /// <value>
        /// The name of the field.
        /// </value>
        public string FieldName { get; set; }
    }
}
