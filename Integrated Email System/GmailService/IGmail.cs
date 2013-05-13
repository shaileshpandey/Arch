using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using IntegratedEmailService.Entity;

namespace GmailService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IGmail
    {
        /// <summary>
        /// Gets the contacts.
        /// </summary>
        /// <param name="userId">The user id.</param>
        /// <param name="pwd">The PWD.</param>
        /// <returns></returns>
        [OperationContract]
        List<Contact> GetContacts(string userId, string pwd);

        /// <summary>
        /// Gets the emails.
        /// </summary>
        /// <param name="userId">The user id.</param>
        /// <param name="pwd">The PWD.</param>
        /// <returns></returns>
        [OperationContract]
        List<Email> GetEmails(string userId, string pwd);

        /// <summary>
        /// Sends the email.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <param name="userId">The user id.</param>
        /// <param name="pwd">The PWD.</param>
        /// <returns></returns>
        [OperationContract]
        List<Contact> SendEmail(Email email, string userId, string pwd);
    }
}