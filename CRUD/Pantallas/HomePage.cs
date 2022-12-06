using CRUD.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        public void mostrar_usuarios()
        {
            
        }

        private void btnShowUsuario_Click(object sender, EventArgs e)
        {
           
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {



        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            UsuarioForm frm = new UsuarioForm();
            
            frm.Show();
            this.Hide();
        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {
            LogInForm frm = new LogInForm();    

            frm.Show();
            this.Hide();
        }

        private void dgvProyectos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2ImageButton4_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            AgregarProyecto frm = new AgregarProyecto();
            frm.Show();
            this.Hide();
        }
    }
}
