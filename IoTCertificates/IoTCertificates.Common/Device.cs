using System;
using System.Collections.Generic;
using System.Text;

namespace IoTCertificates.Common
{
    public class Device
    {
        public string DeviceId { get; set; }

        /// <summary>
        /// The IoT Hub to which this device refer to (just persist as JSON FORMAT)
        /// </summary>
        public IoTHub IoTHub { get; set; }

        /// <summary>
        /// IF ANY, the related Device Provisioning Service used for this device (just persist as JSON FORMAT)
        /// </summary>
        public DPSEnrollmentInfo DPSInfo { get; set; }

        public bool IsIoTEdge { get; set; }

        public Certificate DeviceCertificate { get; set; }
    }
}
