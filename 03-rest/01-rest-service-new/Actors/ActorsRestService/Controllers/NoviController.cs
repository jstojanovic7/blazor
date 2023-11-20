using Microsoft.AspNetCore.Mvc;

namespace ActorsRestService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NoviController : ControllerBase
    {
    
        public NoviController()
        {
           
        }

        [HttpGet(Name = "GetNovi")]
        public IEnumerable<Int32> Get()
        {
            return Enumerable.Range(1, 5).ToArray();         
        }
    }    

}