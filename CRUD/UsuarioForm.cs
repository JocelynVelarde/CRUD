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
    public partial class UsuarioForm : Form
    {
        public UsuarioForm()
        {
            InitializeComponent();
            mostrar_usuarios();
            Usuario2.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Usuario objeto = new Usuario()
            {
                Id = int.Parse(Usuario2.Text),
               
                Nombre = Usuario2.Text,
                Contraseña = Contraseña2.Text,
                Cargo = Cargo1.Text

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
                Nombre = Usuario2.Text,
                Contraseña = Contraseña2.Text,
                Cargo = Cargo1.Text

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
            Id1.Text = "";
            Usuario2.Text = "";
            Contraseña2.Text = "";
            Cargo1.Text = "";
            Usuario2.Focus();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Usuario objeto = new Usuario()
            {
                Id = int.Parse(Usuario2.Text),

            };

            bool respuesta = UsuarioLogico.Instancia.Eliminar(objeto);
            if (respuesta)
            {
                limpiar();
                mostrar_usuarios();
            }
        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {
            LogInForm logInForm = new LogInForm();
            logInForm.Show();
            this.Hide();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Hide();
        }

        private void txtIdUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void Id1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Usuario objeto = new Usuario()
            {
                Id = int.Parse(Usuario2.Text),

                Nombre = Usuario2.Text,
                Contraseña = Contraseña2.Text,
                Cargo = Cargo1.Text

            };

            bool respuesta = UsuarioLogico.Instancia.Editar(objeto);
            if (respuesta)
            {
                limpiar();
                mostrar_usuarios();
            }
        }

        private void btnGuardar1_Click(object sender, EventArgs e)
        {
            Usuario objeto = new Usuario()
            {
                Nombre = Usuario2.Text,
                Contraseña = Contraseña2.Text,
                Cargo = Cargo1.Text

            };

            bool respuesta = UsuarioLogico.Instancia.Guardar(objeto);
            if (respuesta)
            {
                limpiar();
                mostrar_usuarios();
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            Usuario objeto = new Usuario()
            {
                Id = int.Parse(Id1.Text),

            };

            bool respuesta = UsuarioLogico.Instancia.Eliminar(objeto);
            if (respuesta)
            {
                limpiar();
                mostrar_usuarios();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }
    

