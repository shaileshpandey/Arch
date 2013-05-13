using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using IntegratedEmailService.Entity;

namespace IntegratedEmailService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IIntegratedEmail
    {
        /// <summary>
        /// Gets the contacts.
        /// </summary>
        /// <param name="provider">The provider.</param>
        /// <param name="userId">The user id.</param>
        /// <param name="pwd">The PWD.</param>
        /// <returns></returns>
        [OperationContract]
        [FaultContract(typeof(List<ServiceFault>))]
        List<Contact> GetContacts(EmailProviderType provider, string userId, string pwd);

        /// <summary>
        /// Gets the emails.
        /// </summary>
        /// <param name="provider">The provider.</param>
        /// <param name="userId">The user id.</param>
        /// <param name="pwd">The PWD.</param>
        /// <returns></returns>
        [OperationContract]
        [FaultContract(typeof(List<ServiceFault>))]
        List<Email> GetEmails(EmailProviderType provider, string userId, string pwd);

        /// <summary>
        /// Sends the email.
        /// </summary>
        /// <param name="provider">The provider.</param>
        /// <param name="email">The email.</param>
        /// <param name="userId">The user id.</param>
        /// <param name="pwd">The PWD.</param>
        /// <returns></returns>
        [OperationContract]
        [FaultContract(typeof(List<ServiceFault>))]
        List<Contact> SendEmail(EmailProviderType provider, Email email, string userId, string pwd);
    }
}
