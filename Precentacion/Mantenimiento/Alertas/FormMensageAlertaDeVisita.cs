using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Precentacion.FORM.Mantenimientos.Alertas
{
    public partial class FormMensageAlertaDeVisita : FormBaseMantenimiento
    {
        DateTime fech = new DateTime();


        public FormMensageAlertaDeVisita()
        {
           
            InitializeComponent();
            inicializar("dsfsdf324","ramon martinez","rm@gmail.com");
        }


        private void inicializar(string matricula,string cliente,string email)
        {
            string fech = DateTime.Now.ToString("dddd MMMM yyyy");
            txtAsunto.Text = "Recomendación de Visita";
            txtMensaje.Text = "Estimado Cliente: " +"\n"+ "Este E-Mail automático es para informarle / recomendarle sobre una nueva visita a nuestro taller de su Vehículo:" + matricula + "\n" + "Fecha estiupulada de alerta:" + fech + "\n\n" +"Muchas Gracias";
            txtDestinatario.Text = cliente;
            txtEmail.Text = email;
        }
        

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
