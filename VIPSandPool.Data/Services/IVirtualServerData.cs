using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VIPSandPool.Data.Models;

namespace VIPSandPool.Data.Services
{
    public interface IVirtualServerData
    {
        IEnumerable<VirtualServer> GetAll();
        VirtualServer Get(int id);
        void Add(VirtualServer virtualserver);
        void Update(VirtualServer virtualServer);
        void Delete(int id);
    }
}
