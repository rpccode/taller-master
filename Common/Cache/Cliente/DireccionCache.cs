using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Cache.Cliente
{
    class DireccionCache
    {
        public int idDirecccion { get; set; }
        public string direccion { get; set; }
        public string ciudad { get; set; }
        public string provincia { get; set; }

        public List<DireccionCache> ListaDireccion { get; set; }
    }
}
