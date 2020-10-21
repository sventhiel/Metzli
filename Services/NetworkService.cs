using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;

namespace Metztli.Services
{
    public class NetworkService
    {
        public List<NetworkInterface> GetNetworkInterfaces(bool withPhysicalAddressOnly = true)
        {
            if (withPhysicalAddressOnly)
                return NetworkInterface.GetAllNetworkInterfaces().Where(i => i.GetPhysicalAddress() != null).ToList();

            return NetworkInterface.GetAllNetworkInterfaces().ToList();
        }

        public bool SetPhysicalAddress(string name, string physicalAddress)
        {
            var inter = NetworkInterface.GetAllNetworkInterfaces().Where(i => i.Name == name).First();

            inter.
        }
    }
}
