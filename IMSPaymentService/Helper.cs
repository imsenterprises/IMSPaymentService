using IMSPaymentService.PaymentAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace IMSPaymentService
{
    public class Helper
    {
        public static PaymentServicePortTypeClient GetClient(string url, string username, string password)
        {
            var binding = new BasicHttpBinding(BasicHttpSecurityMode.Transport);
            binding.Security.Transport.ClientCredentialType = HttpClientCredentialType.Basic;
            var address = new EndpointAddress(url);
            var client = new PaymentServicePortTypeClient(binding, address);
            client.ClientCredentials.UserName.UserName = username;
            client.ClientCredentials.UserName.Password = password;
            return client;
        }
    }
}
