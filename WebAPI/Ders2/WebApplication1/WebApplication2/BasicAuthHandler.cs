using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Options;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text;
using System.Text.Encodings.Web;

namespace WebApplication2
{
    public class BasicAuthHandler : AuthenticationHandler<AuthenticationSchemeOptions>
    {
        public BasicAuthHandler(IOptionsMonitor<AuthenticationSchemeOptions> options, ILoggerFactory logger, UrlEncoder encoder, ISystemClock clock) : base(options, logger, encoder, clock)
        {
        }

        protected override async Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            var endpoint = Context.GetEndpoint();

            if (endpoint?.Metadata?.GetMetadata<IAllowAnonymous>() != null)
            {
                return AuthenticateResult.NoResult();
            }

            if (Request.Headers.ContainsKey("Authorization") == false)
            {
                return AuthenticateResult.Fail("İstek Header ında Authorization bilgileri bulunmuyor.");
            }

            var authHeader = AuthenticationHeaderValue.Parse(Request.Headers["Authorization"]);
            var loginBytes = Convert.FromBase64String(authHeader.Parameter);
            var loginInfo = Encoding.UTF8.GetString(loginBytes);    // username:password
            var credentials = loginInfo.Split(":", StringSplitOptions.TrimEntries);

            string username = credentials[0];
            string password = credentials[1];

            bool result = (username == "muratbaseren" && password == "123123") ? true : false;

            if (result)
            {
                List<Claim> claims = new List<Claim>
                {
                    new Claim(ClaimTypes.NameIdentifier, username),
                    new Claim("FullName", username),
                    new Claim(ClaimTypes.Role,"user")
                };

                var identity = new ClaimsIdentity(claims, Scheme.Name);
                var principal = new ClaimsPrincipal(identity);
                var ticket = new AuthenticationTicket(principal, Scheme.Name);

                return AuthenticateResult.Success(ticket);
            }
            else
            {
                return AuthenticateResult.Fail("Kullanıcı adı ya da şifre yanlış.");
            }
        }
    }
}
