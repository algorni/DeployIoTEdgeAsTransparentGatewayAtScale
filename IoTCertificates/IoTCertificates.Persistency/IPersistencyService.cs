using IoTCertificates.Common;
using System;
using System.Collections.Generic;

namespace IoTCertificate.Persistency
{
    public interface IPersistencyService
    {
        /// <summary>
        /// Get Keys
        /// </summary>
        /// <returns></returns>
        IEnumerable<Key> GetKeys();

        IEnumerable<Certificate> GetCertificates();

        IEnumerable<Device> GetDevices();


        ///TODO create also the CreateKey (just persist the Key provided...   not actually the CREATION of the key itself..)
        ///AddCertificate
        ///AddDevice
        ///and their delete methods.. .(with the minimum of validation...   cannote delete a certificate used by a device... or key used by a certificate)

    }
}
