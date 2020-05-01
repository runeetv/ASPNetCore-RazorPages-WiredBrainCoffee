using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WiredBrainCoffee
{
    public class PromoConstraint : IRouteConstraint
    {
        string secretToken = "MySecretToken";
        public bool Match(HttpContext httpContext, IRouter route, string routeKey, RouteValueDictionary values, RouteDirection routeDirection)
        {
            string userPassedToken = values["token"].ToString();

            return ( (string.Compare(userPassedToken, secretToken, true) == 0 )?  true :  false);
            
        }
    }
}
