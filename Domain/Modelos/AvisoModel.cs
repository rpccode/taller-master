using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccesss;
using Common.Cache;
using DataAccesss.Entidades;
using System.Windows.Forms;

namespace Domain
{
     class AvisoModel
    {

        AvisoDao aviso = new AvisoDao();

        private  int id_Mensaje { get; set; }
        private  string Asunto { get; set; }
        private  string mensaje { get; set; }
        private  string fecha { get; set; }
        private  int cliente { get; set; }
        private  int stado { get; set; }

        public AvisoModel(int id,string asunto, string mensaje, string fech,int idcliente,int stado)
        {
            this.id_Mensaje = id;
            this.Asunto = asunto;
            this.mensaje = mensaje;
            this.fecha = fech;
            this.cliente = idcliente;
            this.stado = stado;

        }

        public AvisoModel()
        {

        }

        public string EnviarMail(string subject, string body, string email)
        {
            try
            {
               return aviso.Enviar(subject, body, email);

            }
            catch(Exception EX)
            {
                return "Error, el Mensaje no pudo enviarse correctamente." + EX;
            }
           
        }
        public void MostrarMensaje()
        {
            try
            {
                aviso.CargarMensajes();

            }catch(Exception ex)
            {
               
               MessageBox.Show("Error,Los mensajes no pudieron cargarse correctamente." + ex);
            }
        }
    }
}
