using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;

namespace CalculatingWebApiAppveyor.Controllers
{
    public class DivisionController : ApiController
    {
        [HttpGet]
        [Route("")]
        public HttpResponseMessage Index()
        {
            var response = Request.CreateResponse(HttpStatusCode.OK);
            response.Content = new StringContent("Hello Maths!", Encoding.UTF8, "text/plain");
            return response;
        }

        [HttpGet]
        [Route("divisions/dividends/{dividend}/divisors/{divisor}/_result")]
        public IHttpActionResult Divide(int dividend, int divisor)
        {
            return Ok(dividend / divisor);
        }
    }
}
