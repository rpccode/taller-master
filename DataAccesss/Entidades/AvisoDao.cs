using Common.Cache;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesss.Entidades
{
    public class AvisoDao:ConnectionSQL
    {
        public string Enviar(string Subject, string Body, string Email)
        {
            var mailService = new MailService.SystemSupportMail();
            mailService.sendMail(
                subject: Subject,
                body: Body,
                recipientMail: new List<string> { Email });

            return "Mensaje enviado exitosamente.";
        }
        public void guardarMensaje(string asunto,string mensaje,int idcliente)
        {
            using (var connexion = GetConnection())
            {
                connexion.Open();
                using(var comman = new SqlCommand())
                {
                    comman.Connection = connexion;
                    comman.CommandText = "exec sp_salve_Mesaje";
                    comman.Parameters.AddWithValue("@Asunto",asunto);
                    comman.Parameters.AddWithValue("@mensaje",mensaje);
                    comman.Parameters.AddWithValue("@id_cliente",idcliente);
                    comman.CommandType = System.Data.CommandType.StoredProcedure;
                    comman.ExecuteNonQuery();
                  
                }
            }
        }
        public void CargarMensajes()
        {
            using (var connexion = GetConnection())
            {
                connexion.Open();
                using(var comman = new SqlCommand())
                {
                    comman.Connection = connexion;
                    comman.CommandText = "select * from mensaje";
                    comman.CommandType = System.Data.CommandType.Text;
                    SqlDataReader reader = comman.ExecuteReader();

                    if (reader.HasRows)
                    {
                        avisosCache avisosCache = new avisosCache();
                       
                        while (reader.Read())
                        {

                            avisosCache.id_Mensaje = reader.GetInt32(0);
                            avisosCache.Asunto = reader.GetString(1);
                            avisosCache.mensaje = reader.GetString(2);
                            avisosCache.fecha = reader.GetString(3);
                            avisosCache.cliente = reader.GetInt32(4);
                            avisosCache.stado = reader.GetInt32(5);

                            avisosCache.ListaMensajes.Add(avisosCache);


                        }
                    }
                }
            }
        }
      

    }
}
