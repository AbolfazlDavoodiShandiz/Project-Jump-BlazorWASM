using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace PMS.BlazorWASMClient.Utility.Extensions
{
    public static class IdentityExtention
    {
        public static int GetUserId(this IIdentity identity)
        {
            int id = 0;
            var claimIdentity = identity as ClaimsIdentity;

            if (claimIdentity is not null)
            {
                var claim = claimIdentity.FindFirst(ClaimTypes.NameIdentifier);

                if (claim is not null)
                {
                    id = int.Parse(claim.Value);
                }
            }

            return id;
        }

        public static string GetUserEmail(this IIdentity identity)
        {
            string email = string.Empty;
            var claimIdentity = identity as ClaimsIdentity;

            if (claimIdentity is not null)
            {
                var claim = claimIdentity.FindFirst(ClaimTypes.Email);

                if (claim is not null)
                {
                    email = claim.Value;
                }
            }

            return email;
        }

        public static string GetUsername(this IIdentity identity)
        {
            string username = string.Empty;
            var claimIdentity = identity as ClaimsIdentity;

            if (claimIdentity is not null)
            {
                var claim = claimIdentity.FindFirst(ClaimTypes.Name);

                if (claim is not null)
                {
                    username = claim.Value;
                }
            }

            return username;
        }
    }
}
