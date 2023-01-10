using Common.Cache;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Precentacion.FORM.Mantenimientos.Cliente
{
    public partial class FormRegCliente : FormBase
    {
        ClienteCache Cliente = new ClienteCache();
        public FormRegCliente()
        {
            InitializeComponent();
        }
        public FormRegCliente(int pos)
        {
            InitializeComponent();
            buscar(pos);
        }

        private void buscar(int pos)
        {
            
            var list = Cliente.GetListaCliente();


            var clientRes = from s in list
                            where s.id_Cliente == pos
                            select s;
            foreach (var cliente in clientRes) {

               
                txtid.Text = cliente.id_Cliente.ToString();
                txtNombre.Text = cliente.Nombre;
                txtApellido.Text = cliente.Apellido;
                ComboBox1.SelectedItem = cliente.idtipoDoc;
                txtNumDoc.Text = cliente.NumDocumento;
                txtidDireccion.Text = cliente.direccion;
                txtciudad.Text = cliente.ciudad;
                txtProvincia.Text = cliente.provincia;
                txttelefono.Text = cliente.telefono;
                txtEmail.Text = cliente.Email;

            }
               
        
        
    }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void FormRegCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'taller_autoDataSet.tipo' Puede moverla o quitarla según sea necesario.
            this.tipoTableAdapter.Fill(this.taller_autoDataSet.tipo);

        }
    }
}
