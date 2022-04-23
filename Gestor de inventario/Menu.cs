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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void controlDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Control_de_usuarios opcion2 = new Control_de_usuarios();
            opcion2.Show();
        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inventario opcion3 = new Inventario();
            opcion3.Show();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login opcion5 = new Login();
            opcion5.Show();
            this.Hide();
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult Salir = MessageBox.Show("Estas seguro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Salir == DialogResult.No)
            {
                return;
            }
            Application.Exit();
        }

        private void ayudaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Ayuda opcion4 = new Ayuda();
            opcion4.Show();
        }
    }
}
