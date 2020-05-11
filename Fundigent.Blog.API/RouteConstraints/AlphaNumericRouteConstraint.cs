using System;
using System.Globalization;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace Fundigent.Blog.API.RouteConstraints
{
    public class AlphaNumericRouteConstraint : IRouteConstraint
    {
        private readonly TimeSpan RegexMatchTimeout = TimeSpan.FromSeconds(10);
        private Regex regex;

        public AlphaNumericRouteConstraint()
        {
            regex = new Regex(@"^[a-zA-Z0-9]*$", RegexOptions.CultureInvariant | RegexOptions.IgnoreCase, RegexMatchTimeout);
        }

        public bool Match(HttpContext httpContext, IRouter route, string routeKey, RouteValueDictionary values, RouteDirection routeDirection)
        {
            if (httpContext == null)
                throw new ArgumentNullException(nameof(httpContext));

            if (route == null)
                throw new ArgumentNullException(nameof(route));

            if (routeKey == null)
                throw new ArgumentNullException(nameof(routeKey));

            if (values == null)
                throw new ArgumentNullException(nameof(values));

            if (values.TryGetValue(routeKey, out object routeValue))
            {
                var parameterValueString = Convert.ToString(routeValue, CultureInfo.InvariantCulture);

                if (parameterValueString == null)
                    return false;

                return regex.IsMatch(parameterValueString);
            }

            return false;
        }
    }
}
