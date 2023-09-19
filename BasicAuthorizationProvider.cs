using Microsoft.Extensions.Configuration;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using SmartService.Core.Utility;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Qwips.Core.MultiCase
{
    public class BasicAuthorizationProvider : IAuthenticationProvider
    {
        private MultiCaseConfiguration _options;

        public BasicAuthorizationProvider(IConfiguration settings)
        {
            var section = settings.GetSection("AppSettings").GetSection("MultiCase");
            var options = section.Get<MultiCaseConfiguration>();
            this._options = options;
        }

        public Task AuthenticateRequestAsync(RequestInformation request, Dictionary<string, object> additionalAuthenticationContext = null, CancellationToken cancellationToken = default)
        {

            if (!_options.AzureAd)
            {
                var encUserNameAndPassword = Convert.ToBase64String(Encoding.UTF8.GetBytes(_options.UserName + ":" + _options.Password));
                request.Headers.Add("Authorization", "Basic " + encUserNameAndPassword);
            }
            return Task.CompletedTask;
        }
    }
}
