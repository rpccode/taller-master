using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Common.Cache;
using Precentacion.FORM.Mantenimientos.Cliente;
using Precentacion;
using Precentacion.FORM.Mantenimientos.Alertas;

namespace Presentation
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            pantallaConf();
        }

        #region

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();


        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void botoncerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que quiere cerrar la Aplicaccion", "warnig", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnmax.Visible = false;
            btnrest.Visible = true;
        }

        private void btnrest_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnrest.Visible = false;
            btnmax.Visible = true;
        }

        private void btnmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
           

        }
        

        //forma incorrecta de abrir ormularios 
        private void abrirmihija(object formhija)
        {
            if(this.panelcontenedor.Controls.Count>0)
            {
                this.panelcontenedor.Controls.RemoveAt(0);
            }
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;

            this.panelcontenedor.Controls.Add(fh);
            this.panelcontenedor.Tag = fh;
            fh.Show();
        }

        //forma mejorada de abrir los formularios
        public void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelcontenedor.Controls.OfType<MiForm>().FirstOrDefault();//Busca en la colecion el formulario
                                                                                    //si el formulario/instancia no existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelcontenedor.Controls.Add(formulario);
                panelcontenedor.Tag = formulario;
                formulario.Show();
                formulario.StartPosition = FormStartPosition.CenterScreen;
                formulario.BringToFront();
            }
            //si el formulario/instancia existe
            else
            {
                formulario.BringToFront();
            }
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
           
            AbrirFormulario<productos>();
        }

        private void btninicio_Click(object sender, EventArgs e)
        {
            
            AbrirFormulario<Inicio>();
        }

        private void barratitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void LoadUserData()
        {
            lblName.Text = UserLoginCache.FirsName+", "+ UserLoginCache.LastName;
            lblPosition.Text = UserLoginCache.Position;
            lblEmail.Text = UserLoginCache.Email;
        }

        private void pantallaConf()
        {
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            btninicio_Click(null, e);
            LoadUserData();
            //permisos de usuarios
            if (UserLoginCache.Position == Cargos.Accounting)
            {
                btnclientes.Enabled = false;
                btnProducto.Enabled = false;
                btnventas.Enabled = false;



            }
            if (UserLoginCache.Position == Cargos.Receptionist)
            {
                btncompras.Enabled = false;
                btnEmpleados.Enabled = false;

            }
        }

        #endregion




        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea cerrar la secion", "warnig", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();

        }

        private void linkLabelMiPerfil_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            AbrirFormulario<FormUserPerfil>();
        }

        private void btnclientes_Click(object sender, EventArgs e)
        {
            
            AbrirFormulario<FormCliente>();
        }

        private void btnPagos_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormAlertas>();
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
