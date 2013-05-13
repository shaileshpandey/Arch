using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using IntegratedEmailService.Entity;

namespace hotmailService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Hotmail : IHotmail
    {

        /// <summary>
        /// Gets the contacts.
        /// </summary>
        /// <param name="userId">The user id.</param>
        /// <param name="pwd">The PWD.</param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public List<Contact> GetContacts(string userId, string pwd)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the emails.
        /// </summary>
        /// <param name="userId">The user id.</param>
        /// <param name="pwd">The PWD.</param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public List<IntegratedEmailService.Entity.Email> GetEmails(string userId, string pwd)
        {
            List<Email> emails = new List<Email>();
            emails.Add(new Email
            {
                Content = "First Hotmail email",
                From = new Contact { EmailAddress = "1@hhh.com" }
            });

            return emails;
        }

        /// <summary>
        /// Sends the email.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <param name="userId">The user id.</param>
        /// <param name="pwd">The PWD.</param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public List<IntegratedEmailService.Entity.Contact> SendEmail(IntegratedEmailService.Entity.Email email, string userId, string pwd)
        {
            throw new NotImplementedException();
        }
    }
}
