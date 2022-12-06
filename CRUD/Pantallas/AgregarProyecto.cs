using CRUD.Logica;
using CRUD.Modelo;
using Guna.UI2.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CRUD
{
    public partial class AgregarProyecto : Form
    {
        public AgregarProyecto()
        {
            InitializeComponent();
            mostrar_proyectos();
        }

        private void IdProyecto_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEditarP_Click(object sender, EventArgs e)
        {
            Proyectos objeto = new Proyectos()
            {
                Id = int.Parse(IdProyecto.Text),

                Concepto = Conceptobx.Text,
                FechaPago = FechaPagobx.Text,
                Nombre = Nombrebx.Text,
                Fraccionamiento = Fraccionamientobx.Text, 
                Direccion = Direccionbx.Text,
                PrecioVenta = PrecioVentabx.Text,
                Ingresos = Ingresosbx.Text,
                Saldo = Saldobx.Text,
                Importe = Importebx.Text,
                Remision = Remisionbx.Text,
                Factura = Facturabx.Text,
                MetodoPago = MetodoPagobx.Text, 
                Descripcion = Descripcionbx.Text,
                Status = Statusbx.Text,







            };

            bool respuesta = ProyectosLogicos.Instancia.Editar(objeto);
            if (respuesta)
            {
                limpiar();
                mostrar_proyectos();
            }
        }

        private void btnGuardarP_Click(object sender, EventArgs e)
        {
            Proyectos objeto = new Proyectos()
            {
                

                Concepto = Conceptobx.Text,
                FechaPago = FechaPagobx.Text,
                Importe = Importebx.Text,
                Remision = Remisionbx.Text,
                Factura = Facturabx.Text,
                MetodoPago = MetodoPagobx.Text,
                Descripcion = Descripcionbx.Text,
                Status = Statusbx.Text,
                Nombre = Nombrebx.Text,
                Fraccionamiento = Fraccionamientobx.Text,
                Direccion = Direccionbx.Text,
                PrecioVenta = PrecioVentabx.Text,
                Ingresos = Ingresosbx.Text,
                Saldo = Saldobx.Text,


            };

            bool respuesta = ProyectosLogicos.Instancia.Guardar(objeto);
            if (respuesta)
            {
                limpiar();
                mostrar_proyectos();
            }

           
        }

        public void mostrar_proyectos()
        {
            dgvProyecto.DataSource = null;
            dgvProyecto.DataSource = ProyectosLogicos.Instancia.Listar();
        }

        public void limpiar()
        {
            IdProyecto.Text = "";
            Conceptobx.Text = "";
            FechaPagobx.Text = "";
            Importebx.Text = "";
            Remisionbx.Text = "";
            Facturabx.Text = "";
            MetodoPagobx.Text = "";
            Descripcionbx.Text = "";
            Statusbx.Text = "";
            Nombrebx.Text = "";
            Fraccionamientobx.Text = "";
            Direccionbx.Text = "";
            PrecioVentabx.Text = "";
            Ingresosbx.Text = "";
            Saldobx.Text = "";
            

        }
        private void btnBorrarP_Click(object sender, EventArgs e)
        {
            Proyectos objeto = new Proyectos()
            {
                Id = int.Parse(IdProyecto.Text),

            };

            bool respuesta = ProyectosLogicos.Instancia.Eliminar(objeto);
            if (respuesta)
            {
                limpiar();
                mostrar_proyectos();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            VerProyecto frm = new VerProyecto();
            frm.Show();
            this.Hide();
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

        private void dgvProyecto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {
            LogInForm frm = new LogInForm();
            frm.Show();
            this.Hide();
        }
    }
}

