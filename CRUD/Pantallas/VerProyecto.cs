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
    public partial class VerProyecto : Form
    {
        public VerProyecto()
        {
            InitializeComponent();
        }

        public void mostrar_proyectos()
        {
            
        }



        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            HomePage frm = new HomePage();
            frm.Show();
            this.Hide();


        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            UsuarioForm frm = new UsuarioForm();
            frm.Show();
            this.Hide();
        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {
            LogInForm frm = new LogInForm();
            frm.Show();
            this.Hide();
        }
    }
}
