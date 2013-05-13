using System;
using System.Collections.Generic;
using IntegratedEmailService.Entity;
using IntegratedEmailService.GService;
using IntegratedEmailService.HService;
using IntegratedEmailService.YService;


namespace IntegratedEmailService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class IntegratedEmail : IIntegratedEmail
    {
        /// <summary>
        /// Gets the emails.
        /// </summary>
        /// <param name="provider">The provider.</param>
        /// <param name="userId">The user id.</param>
        /// <param name="pwd">The PWD.</param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public List<Email> GetEmails(EmailProviderType provider, string userId, string pwd)
        {
            List<Email> emails = new List<Email>();
            if (provider == EmailProviderType.Gmail || provider == EmailProviderType.All)
            {
                using (var client = ProviderFactory.Get(provider))
                {
                    emails.AddRange(((GmailClient)client).GetEmails(userId, pwd));
                };
            }
            if (provider == EmailProviderType.Hotmail || provider == EmailProviderType.All)
            {
                using (var client = ProviderFactory.Get(provider))
                {
                    emails.AddRange(((HotmailClient)client).GetEmails(userId, pwd));
                };
            }
            if (provider == EmailProviderType.Yahoo || provider == EmailProviderType.All)
            {
                using (var client = ProviderFactory.Get(provider))
                {
                    emails.AddRange(((YahooClient)client).GetEmails(userId, pwd));
                };
            }

            return emails;
        }

        /// <summary>
        /// Gets the contacts.
        /// </summary>
        /// <param name="provider">The provider.</param>
        /// <param name="userId">The user id.</param>
        /// <param name="pwd">The PWD.</param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public List<Contact> GetContacts(EmailProviderType provider, string userId, string pwd)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sends the email.
        /// </summary>
        /// <param name="provider">The provider.</param>
        /// <param name="email">The email.</param>
        /// <param name="userId">The user id.</param>
        /// <param name="pwd">The PWD.</param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public List<Contact> SendEmail(EmailProviderType provider, Email email, string userId, string pwd)
        {
            throw new NotImplementedException();
        }
    }
}
