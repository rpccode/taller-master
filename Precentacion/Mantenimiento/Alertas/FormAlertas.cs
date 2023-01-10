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
    public partial class FormAlertas : Form
    {
        FormMensageAlertaDeVisita obj = new FormMensageAlertaDeVisita();
        public FormAlertas()
        {
            InitializeComponent();
        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void gunaImageButton2_Click(object sender, EventArgs e)
        {
            if (obj.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
