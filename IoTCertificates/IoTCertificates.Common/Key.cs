using System;
using System.Collections.Generic;
using System.Text;

namespace IoTCertificates.Common
{
    public class Key
    {
        /// <summary>
        /// Key unique id
        /// </summary>
        public Guid KeyId { get; set; }

        /// <summary>
        /// Key Name (e.g. root CA private keys)
        /// </summary>
        public string KeyName { get; set; }

        /// <summary>
        /// RSA / ECDsa
        /// </summary>
        public string KeyFormat { get; set; }
        
        public bool IncludePrivate { get; set; }

        /// <summary>
        /// Key Content
        /// </summary>
        public byte[] KeyContent { get; set; }
    }
}
