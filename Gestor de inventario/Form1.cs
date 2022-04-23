using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestor_de_inventario
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void ACCEDER_Click(object sender, EventArgs e)
        {
            String user, pass;
            user = txtusuario.Text;
            pass = txtcontraseña.Text;
            if (user == "ADMIN" && pass == "1234")
            {
                Menu opcion1 = new Menu();
                opcion1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("ERROR, datos no validos");
                txtusuario.Text = "";
                txtcontraseña.Text = "";
            }

        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
