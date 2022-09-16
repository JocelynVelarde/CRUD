﻿using System;
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
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

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
                mostrar_usuarios();
            }
        }

        public void mostrar_usuarios()
        {
            dgvUsuario.DataSource = null;
            dgvUsuario.DataSource = UsuarioLogico.Instancia.Listar();
        }
    }
}
