using DataAccesss.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Modelos
{
   public class ClienteModel
    {
        ClienteData obj = new ClienteData();

        public void CargarCliente()
        {
            obj.CargarClientes();
        }
    }
}
