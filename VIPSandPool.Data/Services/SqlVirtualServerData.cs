using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VIPSandPool.Data.Models;

namespace VIPSandPool.Data.Services
{
    public class SqlVirtualServerData : IVirtualServerData
    {
        private readonly VIPSandPoolDbContext db;

        public SqlVirtualServerData(VIPSandPoolDbContext db)
        {
            this.db = db;
        }
        public void Add(VirtualServer virtualserver)
        {
            db.VirtualServers.Add(virtualserver);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var virtualserver = db.VirtualServers.Find(id);
            db.VirtualServers.Remove(virtualserver);
            db.SaveChanges();
        }

        public VirtualServer Get(int id)
        {
            return db.VirtualServers.FirstOrDefault(r => r.Id == id);
        }

        public IEnumerable<VirtualServer> GetAll()
        {
            return from r in db.VirtualServers
                   orderby r.Name
                   select r;
        }

        public void Update(VirtualServer virtualserver)
        {
            var entry = db.Entry(virtualserver);
            entry.State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
