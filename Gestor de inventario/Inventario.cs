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
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
        }

        private void inventarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.inventarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sistema_ComprasDataSet);

        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistema_ComprasDataSet.Inventario' Puede moverla o quitarla según sea necesario.
            this.inventarioTableAdapter.Fill(this.sistema_ComprasDataSet.Inventario);

        }

        private void btgenerar_Click(object sender, EventArgs e)
        {
            Double precio, porcentaje, ganancia, venta;
            precio = Double.Parse(precio_del_ProductoTextBox.Text);
            porcentaje = Double.Parse(porcentaje_a_ganarTextBox.Text);
            ganancia = precio * porcentaje;
            venta = precio + ganancia;
            precio_TotalTextBox.Text = venta.ToString();
        }
    }
}
