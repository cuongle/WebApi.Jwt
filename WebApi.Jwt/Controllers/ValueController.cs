using System.Web.Http;
using WebApi.Jwt.Filters;

namespace WebApi.Jwt.Controllers
{
    public class ValueController : ApiController
    {
        [JwtAuthentication]
        public string Get()
        {
            return "value";
        }
    }
}
