using System.Web.Http;
using SOA;
using SOAV;
namespace SampleWebApiController
{
    public class SampleController : ApiController
    {
        //[HttpGet]
        //[HttpPut]
        //[HttpPost]
        //[HttpDelete]
        //[HttpHead]
        //[HttpOptions]
        //[HttpPatch]
        [HttpGet]
        [Route("Sample/Hello")]
        public Response MakeGet()
        {
            //https://localhost:44352/Sample/Hello
            return new SOA.RequestCartesian().SayHello();
        }
        [HttpPost]
        [Route("Sample/Singleton")]
        public Response MakePost([FromBody] string msg)
        {
            //"Single Param Supported"
            //"msg":"Success"
            //"Success"
            //https://localhost:44352/Sample/Singleton
            return new SOA.RequestCartesian().SayHello(new Request { Status = 0, Message = (string.IsNullOrEmpty(msg) ? "" : msg) });
        }
        [HttpPost]
        [Route("Sample/Multiplicity")]
        public Response MakePost([FromBody] Request req)
        {
            // Multiple params Supported
            //{"message":"Multiplicity","status":"0"}
            //https://localhost:44352/Sample/Multiplicity
            return new SOA.RequestCartesian().SayHello(req);
        }
    }
}