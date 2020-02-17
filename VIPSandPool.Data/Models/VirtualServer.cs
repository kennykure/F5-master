using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VIPSandPool.Data.Models
{
    public class VirtualServer
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        [Display(Name="F5 Pool")]
        public PoolType Pool { get; set; }
    }
}
