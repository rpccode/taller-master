using Common.Cache;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesss.Entidades
{
   public class ClienteData:ConnectionSQL
    {

        public void CargarClientes()
        {
            using(var connesxion = GetConnection())
            {
                connesxion.Open();
                using(var comman = new SqlCommand())
                {
                    try {
                        comman.Connection = connesxion;
                        comman.CommandText = "exec sp_Mostrar_Cliente";
                        comman.CommandType = System.Data.CommandType.Text;
                        SqlDataReader reader = comman.ExecuteReader();
                        if (reader.HasRows)
                        {
                            ClienteCache cliente = new ClienteCache();
                            List<ClienteCache> listaCliente = new List<ClienteCache>();
                            while (reader.Read())
                            {
                                
                                cliente.id_Cliente = reader.GetInt32(0);
                                cliente.Nombre = reader.GetString(1);
                                cliente.Apellido = reader.GetString(2);
                                cliente.Email = reader.GetString(3);
                                cliente.NumDocumento = reader.GetString(4);
                                cliente.idtipoDoc = reader.GetInt32(5);
                                cliente.tipoDocumento = reader.GetString(6);
                                cliente.telefono = reader.GetString(7);
                                cliente.idDirecccion = reader.GetInt32(8);
                                cliente.direccion = reader.GetString(9);
                                cliente.ciudad = reader.GetString(10);
                                cliente.provincia = reader.GetString(11);
                                cliente.idEstado = reader.GetInt32(12);
                                cliente.estado = reader.GetString(13);
                               
                                listaCliente.Add(cliente);
                                cliente.SetListaCliente(listaCliente);
                            }
                            
                        }
                    }catch(Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show("Error"+ ex);
                    }
                    
                }
            }
        }


    }
}
