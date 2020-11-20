using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Subsystem_Employed.mysql;
using Subsystem_Employed.Mysql;


namespace Subsystem_Employed
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlCommand codigo = new MySqlCommand();
            codigo.Connection = conexion.com();
            codigo.CommandText=("select * from empleado where nombre_usuario ='"+txtusu.Text+"'and psw='"+txtpsw.Text+"'");
            MySqlDataReader leer = codigo.ExecuteReader();
            if (leer.Read())
            {
                MessageBox.Show("bienvenido"+txtusu.Text);
                inicio x = new inicio();
                x.Visible = true;
                Visible = false;
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña incorrectos");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Registro r = new Registro();
            r.Visible = true;
            Visible = false;         
        }
    }
}
