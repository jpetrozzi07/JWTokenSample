using System.Web.Http;

namespace JWTokenSample.Controllers
{
    /// <summary>
    /// customer controller class for testing security token
    /// </summary>
    [Authorize]
    [RoutePrefix("api/customers")]
    public class CustomersController : ApiController
    {
        [HttpGet]
        public IHttpActionResult GetId(int id)
        {
            var customerFake = "customer-fake";
            return Ok(customerFake);
        }

        [HttpGet]
        [Authorize(Roles = "Administrator")]
        public IHttpActionResult GetAll()
        {
            var customersFake = new string[] { "customer-1", "customer-2", "customer-3" };
            return Ok(customersFake);
        }

        [HttpGet]
        [Authorize(Roles = "Customer")]
        public IHttpActionResult GetById(int customer)
        {
            var customerFake = "customer-1";
            return Ok(customerFake);
        }
    }
}