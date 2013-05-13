using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace IntegratedEmailService.Entity
{
    [DataContract]
    public enum EmailProviderType
    {
        [EnumMember]
        All = 0,

        [EnumMember]
        Gmail = 1,

        [EnumMember]
        Yahoo = 2,

        [EnumMember]
        Hotmail = 4
    }
}
