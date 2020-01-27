
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace Ia.Futebol.GE.Presentation.API.Controllers
{
    [Route("/")]
    [ApiController]
    public class HealthCheckController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);

            return Ok(string.Format("Mapper Example API v.{0}", fvi.FileVersion));
        }
    }
}