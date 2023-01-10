using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Cache
{
   public  class ClienteCache
    {
        public static List<ClienteCache> listaCliente;

        public int id_Cliente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string NumDocumento { get; set; }
        public int idtipoDoc { get; set; }
        public string tipoDocumento { get; set; }
        public int idDirecccion { get; set; }
        public string direccion { get; set; }
        public string ciudad { get; set; }
        public string provincia { get; set; } 
        public string telefono { get; set; }
        public int idEstado { get; set; }
        public string estado { get; set; }

        public ClienteCache() { 
        }

        public  List<ClienteCache> GetListaCliente()
        {
            return listaCliente;
        }

        public  void SetListaCliente(List<ClienteCache> value)
        {
            listaCliente = value;

        }

       // public static List<ClienteCache> ListaCliente1 { get => listaCliente; set => listaCliente = value; }
       
       
    }
}
