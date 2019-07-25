using System;
using System.Collections.Generic;
using System.Text;

namespace IoTCertificates.Common
{
    public  class DPSEnrollmentInfo
    {
        /// <summary>
        /// the resource id
        /// </summary>
        public Guid DPSId { get; set; }

        public AzureSubscription Subscription { get; set; }

        /// <summary>
        /// JSON serialization of the enrollment info
        /// </summary>
        public string EnrollmentInfo { get; set; }
    }
}
