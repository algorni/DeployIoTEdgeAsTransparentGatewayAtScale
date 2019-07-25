using System;
using System.Collections.Generic;
using System.Text;

namespace IoTCertificates.Common
{
    public class IoTHub
    {
        /// <summary>
        /// the resource id
        /// </summary>
        public Guid IoTHubId { get; set; }

        public AzureSubscription Subscription { get; set; }

        public string IoTHubName {get;set;}
    }
}
