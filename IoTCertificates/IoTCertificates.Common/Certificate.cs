using System;

namespace IoTCertificates.Common
{
    public class Certificate
    {
        /// <summary>
        /// Certificate unique id
        /// </summary>
        public Guid CertificateId { get; set; }

        public Guid ParentCertificateId { get; set; }

        /// <summary>
        /// A Certificate Description
        /// </summary>
        public string CertificateDescription { get; set; }

        /// <summary>
        /// The Certificate Common Name
        /// </summary>
        public string CertificateCN { get; set; }

        /// <summary>
        /// Key Id to which this certificate refer to
        /// </summary>
        public Guid KeyId{ get; set; }     
    }
}
