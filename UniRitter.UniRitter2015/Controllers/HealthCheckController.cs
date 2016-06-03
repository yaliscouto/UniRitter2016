using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using UniRitter.UniRitter2015.Models;

namespace UniRitter.UniRitter2015.Controllers
{
    public class HealthCheckController : ApiController
    {
        public IHttpActionResult Get()
        {
            return Json<HealthCheck>(new HealthCheck { status = HealthStatus.green });
        }
    }
}
