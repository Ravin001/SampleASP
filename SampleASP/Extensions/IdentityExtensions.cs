using System.Security.Claims;
using System.Security.Principal;
namespace SampleASP.Extensions
{
    public static class IdentityExtensions
    {
        public static string GetFirstName(this IIdentity identity)
        {
            var claim = ((ClaimsIdentity)identity).FindFirst("FirstName");
            // Test for null to avoid issues during local testing
            return (claim != null) ? claim.Value : string.Empty;
        }

        public static string GetLastName(this IIdentity identity)
        {
            var claim = ((ClaimsIdentity)identity).FindFirst("LastName");
            // Test for null to avoid issues during local testing
            return (claim != null) ? claim.Value : string.Empty;
        }

        public static string GetCompanyName(this IIdentity identity)
        {
            var claim = ((ClaimsIdentity)identity).FindFirst("CompanyName");
            // Test for null to avoid issues during local testing
            return (claim != null) ? claim.Value : string.Empty;
        }

        public static string GetAccountType(this IIdentity identity)
        {
            var claim = ((ClaimsIdentity)identity).FindFirst("AccountType");
            // Test for null to avoid issues during local testing
            return (claim != null) ? claim.Value : string.Empty;
        }

        public static string GetDateOfBirth(this IIdentity identity)
        {
            var claim = ((ClaimsIdentity)identity).FindFirst("DateOfBirth");
            // Test for null to avoid issues during local testing
            return (claim != null) ? claim.Value : string.Empty;
        }
    }
}