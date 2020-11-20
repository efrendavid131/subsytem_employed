using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Subsystem_Employed.mysql;

namespace Subsystem_Employed
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            pictureBox3.Visible =true;
            Minimizar.Visible = false;
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            Minimizar.Visible = true;
            pictureBox3.Visible = false;
        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            constructor_registro agregar = new constructor_registro();
            agregar.nombre = txtnom.Text;
            agregar.ap_paterno = txtapepa.Text;
            agregar.ap_materno = txtapema.Text;
            agregar.correo = txtcor.Text;
            agregar.num_cel = txtnum_cel.Text;
            agregar.num_cuenta = txtnumcuen.Text;
            agregar.nombre_usuario = txtusu.Text;
            agregar.psw = txtpsw.Text;
            agregar.ocu = txtocu.Text;
            agregar.edad = Convert.ToInt32(txtedad.Text);
            int datos = funciones.agregar(agregar);
            if (datos > 0)
            {
                MessageBox.Show("Registro de empleado exitoso");
            }
            else if(datos<=0)
            {
                MessageBox.Show("Registro no exitoso");
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 re = new Form1();
            re.Visible = true;
            Visible = false;
        }
    }
}
