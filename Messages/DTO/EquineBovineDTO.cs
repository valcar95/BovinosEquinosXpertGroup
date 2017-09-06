using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messages.DTO
{
    public class EquineBovineDTO
    {
        public IEnumerable<string> equine { get; set; }
        public IEnumerable<string> bovine { get; set; }
    }
}
