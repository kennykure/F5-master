using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VIPSandPool.Data.Models;
using VIPSandPool.Data.Services;

namespace VIPSandPool.Web.Api
{
    public class VirtualServersController : ApiController
    {
        private readonly IVirtualServerData db;

        public VirtualServersController(IVirtualServerData db)
        {
            this.db = db;
        }
        public IEnumerable<VirtualServer> Get()
        {
            var model = db.GetAll();
            return model;
        }
    }
}
