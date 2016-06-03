using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniRitter.UniRitter2015.Models
{
    public enum HealthStatus
    {
        green,
        yellow,
        red
    }
      
    public class HealthCheck
    {
        public HealthStatus status { get; set; }
    }
}
