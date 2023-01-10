using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Cache
{
   public  class avisosCache
    {
        public int id_Mensaje { get; set; }
        public string Asunto { get; set; }
        public string mensaje { get; set; }
        public string fecha { get; set; }
        public int cliente { get; set; }
        public int stado { get; set; }

        public List<avisosCache> ListaMensajes { get; set; }
    }
}
