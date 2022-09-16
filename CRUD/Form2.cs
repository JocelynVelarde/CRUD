using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace CRUD
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (usuario.Text.Trim() == "" && contraseña.Text.Trim() == "")
            {
                MessageBox.Show("Campos Vacios", "Error");
            }
            else
            {
                string query = "SELECT * FROM usuario WHERE Nombre= @nombre AND Contraseña = @contraseña";
                SQLiteConnection conn = new SQLiteConnection("Data Source=PruebaDB.db;Version=3;");  
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@nombre", usuario.Text);
                cmd.Parameters.AddWithValue("@contraseña", contraseña.Text);
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if(dt.Rows.Count > 0)
                {
                    MessageBox.Show("Login Existoso");
                    Form3 form3 = new Form3();
                    form3.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Error intenta de nuevo");
                }
            }
        }
    }
}
