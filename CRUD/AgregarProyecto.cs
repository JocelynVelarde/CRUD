using CRUD.Logica;
using CRUD.Modelo;
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

                Concepto = ConceptoBx.Text,
                Cantidad = CantidadBx.Text,
                Proyecto = ProyectoBx.Text

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
                Id = int.Parse(IdProyecto.Text),

                Concepto = ConceptoBx.Text,
                Cantidad = CantidadBx.Text,
                Proyecto = ProyectoBx.Text

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
            ConceptoBx.Text = "";
            CantidadBx.Text = "";
            ProyectoBx.Text = "";
            ProyectoBx.Focus();

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
    }
}

