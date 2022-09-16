using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CRUD.Logica;
using CRUD.Modelo;

namespace CRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            mostrar_usuarios();
            txtNombreUsuario.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Usuario objeto = new Usuario()
            {
                Id = int.Parse(txtIdUsuario.Text),
               
                Nombre = txtNombreUsuario.Text,
                Contraseña = txtContraseñaUsuario.Text,
                Cargo = txtCargoUsuario.Text

            };

            bool respuesta = UsuarioLogico.Instancia.Editar(objeto);
            if (respuesta)
            {
                limpiar();
                mostrar_usuarios();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Usuario objeto = new Usuario()
            {
                Nombre = txtNombreUsuario.Text,
                Contraseña = txtContraseñaUsuario.Text,
                Cargo = txtCargoUsuario.Text

            };

            bool respuesta = UsuarioLogico.Instancia.Guardar(objeto);
            if (respuesta)
            {
                limpiar();
                mostrar_usuarios();
            }
        }

        public void mostrar_usuarios()
        {
            dgvUsuario.DataSource = null;
            dgvUsuario.DataSource = UsuarioLogico.Instancia.Listar();
        }

        public void limpiar()
        {
            txtIdUsuario.Text = "";
            txtNombreUsuario.Text = "";
            txtContraseñaUsuario.Text = "";
            txtCargoUsuario.Text = "";
            txtNombreUsuario.Focus();

        }
    }
}
