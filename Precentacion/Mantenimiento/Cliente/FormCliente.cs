using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Precentacion.FORM.FormBase;
using Domain;
using Common.Cache;
using Domain.Modelos;

namespace Precentacion.FORM.Mantenimientos.Cliente
{
    public partial class FormCliente : Form
    {
        // cslCliente Clie = new cslCliente();
        //public DataSet ds = new DataSet();
        public ClienteModel clienteModel = new ClienteModel();
        public ClienteCache ClienteCache = new ClienteCache();
        public FormRegCliente obj = new FormRegCliente();
        private bool Editar = false;




        public FormCliente()
        {
            InitializeComponent();
              dataGridView1.AutoGenerateColumns = false;
            clienteModel.CargarCliente();

        }

        private void gunaElipsePanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaElipsePanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormCliente_Load(object sender, EventArgs e)
        {
            CargarClientes();
            
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            if (obj.ShowDialog() == DialogResult.OK)
            {

            }
            obj.Dispose();

        }
        private void CargarClientes()
        {
           var list = ClienteCache.GetListaCliente();
            dataGridView1.DataSource = list;
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            
                
               
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    Editar = true;
                    int pos = dataGridView1.CurrentCell.RowIndex;
                int id=Convert.ToInt32(dataGridView1.Rows[pos].Cells[0].Value);
                var obj1 = new FormRegCliente(id);
                        obj1.ShowDialog();
                }
                else
                    MessageBox.Show("seleccione una fila por favor");
            
        }
    }
}
