using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VIPSandPool.Data.Models;

namespace VIPSandPool.Web.Models
{
    public class GreetingViewModel
    {
        public IEnumerable<VirtualServer> VirtualServers { get; set; }
        public string Message { get; set; }
        public string Name { get; set; }
    }
}