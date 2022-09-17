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
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();

        }
        private void btnLogIn_Click(object sender, EventArgs e)
        {
           
        }

        private void usuario_TextChanged(object sender, EventArgs e)
        {

        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (usuario1.Text.Trim() == "" && contraseña1.Text.Trim() == "")
            {
                MessageBox.Show("Campos Vacios", "Error");
            }
            else
            {
                string query = "SELECT * FROM usuario WHERE Nombre= @nombre AND Contraseña = @contraseña";
                SQLiteConnection conn = new SQLiteConnection("Data Source=PruebaDB.db;Version=3;");
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@nombre", usuario1.Text);
                cmd.Parameters.AddWithValue("@contraseña", contraseña1.Text);
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    HomePage form3 = new HomePage();
                    
                    form3.Show();
                    this.Hide();
                    
                   
                }
                else
                {
                    MessageBox.Show("Error intenta de nuevo");
                }
            }
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
