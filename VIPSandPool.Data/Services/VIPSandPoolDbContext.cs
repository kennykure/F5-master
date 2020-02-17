using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VIPSandPool.Data.Models;

namespace VIPSandPool.Data.Services
{
    public class VIPSandPoolDbContext : DbContext
    {
        public DbSet<VirtualServer> VirtualServers { get; set; }
    }
}
