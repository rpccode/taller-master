using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Precentacion.FORM.Mantenimientos.Articulo
{
    public partial class FormArticulo : FormBaseMantenimiento
    {
        public FormArticulo()
        {
            InitializeComponent();
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            /*string cmd = string.Format("exec clientesActualia '{0}','{1}','{2}','{3}','{4}'",
              txtcodigo.Text.Trim(), txtnombre.Text.Trim(), txtemail.Text.Trim(), txtdireccion.Text.Trim(),
              ckestado.Checked);*/
        }
    }
}
