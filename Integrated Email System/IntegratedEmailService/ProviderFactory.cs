using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;
using IntegratedEmailService.Entity;
using IntegratedEmailService.GService;
using IntegratedEmailService.HService;
using IntegratedEmailService.YService;

namespace IntegratedEmailService
{

    public static class ProviderFactory
    {
        public static IDisposable Get(EmailProviderType typeofProvider)
        {
            if (typeofProvider == EmailProviderType.Gmail)
            {
                return new GmailClient();                
            }

            if (typeofProvider == EmailProviderType.Yahoo)
            {
                return new YahooClient();
            }

            if (typeofProvider == EmailProviderType.Hotmail)
            {
                return new HotmailClient();
            }

            return null;
        }
    }
}