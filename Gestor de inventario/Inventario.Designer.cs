
namespace Gestor_de_inventario
{
    partial class Inventario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idProductoLabel;
            System.Windows.Forms.Label detalleLabel;
            System.Windows.Forms.Label marcaLabel;
            System.Windows.Forms.Label modeloLabel;
            System.Windows.Forms.Label colorLabel;
            System.Windows.Forms.Label proveedorLabel;
            System.Windows.Forms.Label precio_del_ProductoLabel;
            System.Windows.Forms.Label porcentaje_a_ganarLabel;
            System.Windows.Forms.Label precio_TotalLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventario));
            this.label1 = new System.Windows.Forms.Label();
            this.sistema_ComprasDataSet = new Gestor_de_inventario.Sistema_ComprasDataSet();
            this.inventarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventarioTableAdapter = new Gestor_de_inventario.Sistema_ComprasDataSetTableAdapters.InventarioTableAdapter();
            this.tableAdapterManager = new Gestor_de_inventario.Sistema_ComprasDataSetTableAdapters.TableAdapterManager();
            this.inventarioBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.inventarioBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.inventarioDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProductoTextBox = new System.Windows.Forms.TextBox();
            this.detalleTextBox = new System.Windows.Forms.TextBox();
            this.marcaTextBox = new System.Windows.Forms.TextBox();
            this.modeloTextBox = new System.Windows.Forms.TextBox();
            this.colorTextBox = new System.Windows.Forms.TextBox();
            this.proveedorTextBox = new System.Windows.Forms.TextBox();
            this.precio_del_ProductoTextBox = new System.Windows.Forms.TextBox();
            this.porcentaje_a_ganarTextBox = new System.Windows.Forms.TextBox();
            this.precio_TotalTextBox = new System.Windows.Forms.TextBox();
            this.btgenerar = new System.Windows.Forms.Button();
            idProductoLabel = new System.Windows.Forms.Label();
            detalleLabel = new System.Windows.Forms.Label();
            marcaLabel = new System.Windows.Forms.Label();
            modeloLabel = new System.Windows.Forms.Label();
            colorLabel = new System.Windows.Forms.Label();
            proveedorLabel = new System.Windows.Forms.Label();
            precio_del_ProductoLabel = new System.Windows.Forms.Label();
            porcentaje_a_ganarLabel = new System.Windows.Forms.Label();
            precio_TotalLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sistema_ComprasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioBindingNavigator)).BeginInit();
            this.inventarioBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idProductoLabel
            // 
            idProductoLabel.AutoSize = true;
            idProductoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idProductoLabel.Location = new System.Drawing.Point(11, 104);
            idProductoLabel.Name = "idProductoLabel";
            idProductoLabel.Size = new System.Drawing.Size(107, 20);
            idProductoLabel.TabIndex = 3;
            idProductoLabel.Text = "Id Producto:";
            // 
            // detalleLabel
            // 
            detalleLabel.AutoSize = true;
            detalleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            detalleLabel.Location = new System.Drawing.Point(12, 144);
            detalleLabel.Name = "detalleLabel";
            detalleLabel.Size = new System.Drawing.Size(71, 20);
            detalleLabel.TabIndex = 5;
            detalleLabel.Text = "Detalle:";
            // 
            // marcaLabel
            // 
            marcaLabel.AutoSize = true;
            marcaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            marcaLabel.Location = new System.Drawing.Point(12, 176);
            marcaLabel.Name = "marcaLabel";
            marcaLabel.Size = new System.Drawing.Size(63, 20);
            marcaLabel.TabIndex = 7;
            marcaLabel.Text = "Marca:";
            // 
            // modeloLabel
            // 
            modeloLabel.AutoSize = true;
            modeloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            modeloLabel.Location = new System.Drawing.Point(11, 208);
            modeloLabel.Name = "modeloLabel";
            modeloLabel.Size = new System.Drawing.Size(72, 20);
            modeloLabel.TabIndex = 9;
            modeloLabel.Text = "Modelo:";
            // 
            // colorLabel
            // 
            colorLabel.AutoSize = true;
            colorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            colorLabel.Location = new System.Drawing.Point(12, 245);
            colorLabel.Name = "colorLabel";
            colorLabel.Size = new System.Drawing.Size(56, 20);
            colorLabel.TabIndex = 11;
            colorLabel.Text = "Color:";
            // 
            // proveedorLabel
            // 
            proveedorLabel.AutoSize = true;
            proveedorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            proveedorLabel.Location = new System.Drawing.Point(12, 277);
            proveedorLabel.Name = "proveedorLabel";
            proveedorLabel.Size = new System.Drawing.Size(95, 20);
            proveedorLabel.TabIndex = 13;
            proveedorLabel.Text = "Proveedor:";
            // 
            // precio_del_ProductoLabel
            // 
            precio_del_ProductoLabel.AutoSize = true;
            precio_del_ProductoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            precio_del_ProductoLabel.Location = new System.Drawing.Point(12, 309);
            precio_del_ProductoLabel.Name = "precio_del_ProductoLabel";
            precio_del_ProductoLabel.Size = new System.Drawing.Size(170, 20);
            precio_del_ProductoLabel.TabIndex = 15;
            precio_del_ProductoLabel.Text = "Precio del Producto:";
            // 
            // porcentaje_a_ganarLabel
            // 
            porcentaje_a_ganarLabel.AutoSize = true;
            porcentaje_a_ganarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            porcentaje_a_ganarLabel.Location = new System.Drawing.Point(12, 342);
            porcentaje_a_ganarLabel.Name = "porcentaje_a_ganarLabel";
            porcentaje_a_ganarLabel.Size = new System.Drawing.Size(166, 20);
            porcentaje_a_ganarLabel.TabIndex = 17;
            porcentaje_a_ganarLabel.Text = "Porcentaje a ganar:";
            // 
            // precio_TotalLabel
            // 
            precio_TotalLabel.AutoSize = true;
            precio_TotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            precio_TotalLabel.Location = new System.Drawing.Point(12, 374);
            precio_TotalLabel.Name = "precio_TotalLabel";
            precio_TotalLabel.Size = new System.Drawing.Size(109, 20);
            precio_TotalLabel.TabIndex = 19;
            precio_TotalLabel.Text = "Precio Total:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(575, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inventario";
            // 
            // sistema_ComprasDataSet
            // 
            this.sistema_ComprasDataSet.DataSetName = "Sistema_ComprasDataSet";
            this.sistema_ComprasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventarioBindingSource
            // 
            this.inventarioBindingSource.DataMember = "Inventario";
            this.inventarioBindingSource.DataSource = this.sistema_ComprasDataSet;
            // 
            // inventarioTableAdapter
            // 
            this.inventarioTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.InventarioTableAdapter = this.inventarioTableAdapter;
            this.tableAdapterManager.UpdateOrder = Gestor_de_inventario.Sistema_ComprasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            // 
            // inventarioBindingNavigator
            // 
            this.inventarioBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.inventarioBindingNavigator.BindingSource = this.inventarioBindingSource;
            this.inventarioBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.inventarioBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.inventarioBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.inventarioBindingNavigatorSaveItem});
            this.inventarioBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.inventarioBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.inventarioBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.inventarioBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.inventarioBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.inventarioBindingNavigator.Name = "inventarioBindingNavigator";
            this.inventarioBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.inventarioBindingNavigator.Size = new System.Drawing.Size(1343, 25);
            this.inventarioBindingNavigator.TabIndex = 1;
            this.inventarioBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // inventarioBindingNavigatorSaveItem
            // 
            this.inventarioBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.inventarioBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("inventarioBindingNavigatorSaveItem.Image")));
            this.inventarioBindingNavigatorSaveItem.Name = "inventarioBindingNavigatorSaveItem";
            this.inventarioBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.inventarioBindingNavigatorSaveItem.Text = "Guardar datos";
            this.inventarioBindingNavigatorSaveItem.Click += new System.EventHandler(this.inventarioBindingNavigatorSaveItem_Click);
            // 
            // inventarioDataGridView
            // 
            this.inventarioDataGridView.AutoGenerateColumns = false;
            this.inventarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventarioDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.inventarioDataGridView.DataSource = this.inventarioBindingSource;
            this.inventarioDataGridView.Location = new System.Drawing.Point(396, 104);
            this.inventarioDataGridView.Name = "inventarioDataGridView";
            this.inventarioDataGridView.Size = new System.Drawing.Size(934, 373);
            this.inventarioDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdProducto";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdProducto";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Detalle";
            this.dataGridViewTextBoxColumn2.HeaderText = "Detalle";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Marca";
            this.dataGridViewTextBoxColumn3.HeaderText = "Marca";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Modelo";
            this.dataGridViewTextBoxColumn4.HeaderText = "Modelo";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Color";
            this.dataGridViewTextBoxColumn5.HeaderText = "Color";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Proveedor";
            this.dataGridViewTextBoxColumn6.HeaderText = "Proveedor";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Precio_del_Producto";
            this.dataGridViewTextBoxColumn7.HeaderText = "Precio_del_Producto";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Porcentaje_a_ganar";
            this.dataGridViewTextBoxColumn8.HeaderText = "Porcentaje_a_ganar";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Precio_Total";
            this.dataGridViewTextBoxColumn9.HeaderText = "Precio_Total";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // idProductoTextBox
            // 
            this.idProductoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventarioBindingSource, "IdProducto", true));
            this.idProductoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idProductoTextBox.Location = new System.Drawing.Point(201, 104);
            this.idProductoTextBox.Name = "idProductoTextBox";
            this.idProductoTextBox.Size = new System.Drawing.Size(179, 26);
            this.idProductoTextBox.TabIndex = 4;
            // 
            // detalleTextBox
            // 
            this.detalleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventarioBindingSource, "Detalle", true));
            this.detalleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detalleTextBox.Location = new System.Drawing.Point(201, 141);
            this.detalleTextBox.Name = "detalleTextBox";
            this.detalleTextBox.Size = new System.Drawing.Size(179, 26);
            this.detalleTextBox.TabIndex = 6;
            // 
            // marcaTextBox
            // 
            this.marcaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventarioBindingSource, "Marca", true));
            this.marcaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marcaTextBox.Location = new System.Drawing.Point(201, 173);
            this.marcaTextBox.Name = "marcaTextBox";
            this.marcaTextBox.Size = new System.Drawing.Size(179, 26);
            this.marcaTextBox.TabIndex = 8;
            // 
            // modeloTextBox
            // 
            this.modeloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventarioBindingSource, "Modelo", true));
            this.modeloTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modeloTextBox.Location = new System.Drawing.Point(201, 205);
            this.modeloTextBox.Name = "modeloTextBox";
            this.modeloTextBox.Size = new System.Drawing.Size(179, 26);
            this.modeloTextBox.TabIndex = 10;
            // 
            // colorTextBox
            // 
            this.colorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventarioBindingSource, "Color", true));
            this.colorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorTextBox.Location = new System.Drawing.Point(201, 242);
            this.colorTextBox.Name = "colorTextBox";
            this.colorTextBox.Size = new System.Drawing.Size(179, 26);
            this.colorTextBox.TabIndex = 12;
            // 
            // proveedorTextBox
            // 
            this.proveedorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventarioBindingSource, "Proveedor", true));
            this.proveedorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proveedorTextBox.Location = new System.Drawing.Point(201, 274);
            this.proveedorTextBox.Name = "proveedorTextBox";
            this.proveedorTextBox.Size = new System.Drawing.Size(179, 26);
            this.proveedorTextBox.TabIndex = 14;
            // 
            // precio_del_ProductoTextBox
            // 
            this.precio_del_ProductoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventarioBindingSource, "Precio_del_Producto", true));
            this.precio_del_ProductoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precio_del_ProductoTextBox.Location = new System.Drawing.Point(201, 306);
            this.precio_del_ProductoTextBox.Name = "precio_del_ProductoTextBox";
            this.precio_del_ProductoTextBox.Size = new System.Drawing.Size(179, 26);
            this.precio_del_ProductoTextBox.TabIndex = 16;
            // 
            // porcentaje_a_ganarTextBox
            // 
            this.porcentaje_a_ganarTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventarioBindingSource, "Porcentaje_a_ganar", true));
            this.porcentaje_a_ganarTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.porcentaje_a_ganarTextBox.Location = new System.Drawing.Point(201, 339);
            this.porcentaje_a_ganarTextBox.Name = "porcentaje_a_ganarTextBox";
            this.porcentaje_a_ganarTextBox.Size = new System.Drawing.Size(179, 26);
            this.porcentaje_a_ganarTextBox.TabIndex = 18;
            // 
            // precio_TotalTextBox
            // 
            this.precio_TotalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventarioBindingSource, "Precio_Total", true));
            this.precio_TotalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precio_TotalTextBox.Location = new System.Drawing.Point(201, 371);
            this.precio_TotalTextBox.Name = "precio_TotalTextBox";
            this.precio_TotalTextBox.Size = new System.Drawing.Size(179, 26);
            this.precio_TotalTextBox.TabIndex = 20;
            // 
            // btgenerar
            // 
            this.btgenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btgenerar.Location = new System.Drawing.Point(201, 420);
            this.btgenerar.Name = "btgenerar";
            this.btgenerar.Size = new System.Drawing.Size(179, 45);
            this.btgenerar.TabIndex = 21;
            this.btgenerar.Text = "GENERAR PT";
            this.btgenerar.UseVisualStyleBackColor = true;
            this.btgenerar.Click += new System.EventHandler(this.btgenerar_Click);
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(1343, 520);
            this.Controls.Add(this.btgenerar);
            this.Controls.Add(idProductoLabel);
            this.Controls.Add(this.idProductoTextBox);
            this.Controls.Add(detalleLabel);
            this.Controls.Add(this.detalleTextBox);
            this.Controls.Add(marcaLabel);
            this.Controls.Add(this.marcaTextBox);
            this.Controls.Add(modeloLabel);
            this.Controls.Add(this.modeloTextBox);
            this.Controls.Add(colorLabel);
            this.Controls.Add(this.colorTextBox);
            this.Controls.Add(proveedorLabel);
            this.Controls.Add(this.proveedorTextBox);
            this.Controls.Add(precio_del_ProductoLabel);
            this.Controls.Add(this.precio_del_ProductoTextBox);
            this.Controls.Add(porcentaje_a_ganarLabel);
            this.Controls.Add(this.porcentaje_a_ganarTextBox);
            this.Controls.Add(precio_TotalLabel);
            this.Controls.Add(this.precio_TotalTextBox);
            this.Controls.Add(this.inventarioDataGridView);
            this.Controls.Add(this.inventarioBindingNavigator);
            this.Controls.Add(this.label1);
            this.Name = "Inventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.Inventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sistema_ComprasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioBindingNavigator)).EndInit();
            this.inventarioBindingNavigator.ResumeLayout(false);
            this.inventarioBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Sistema_ComprasDataSet sistema_ComprasDataSet;
        private System.Windows.Forms.BindingSource inventarioBindingSource;
        private Sistema_ComprasDataSetTableAdapters.InventarioTableAdapter inventarioTableAdapter;
        private Sistema_ComprasDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator inventarioBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton inventarioBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView inventarioDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.TextBox idProductoTextBox;
        private System.Windows.Forms.TextBox detalleTextBox;
        private System.Windows.Forms.TextBox marcaTextBox;
        private System.Windows.Forms.TextBox modeloTextBox;
        private System.Windows.Forms.TextBox colorTextBox;
        private System.Windows.Forms.TextBox proveedorTextBox;
        private System.Windows.Forms.TextBox precio_del_ProductoTextBox;
        private System.Windows.Forms.TextBox porcentaje_a_ganarTextBox;
        private System.Windows.Forms.TextBox precio_TotalTextBox;
        private System.Windows.Forms.Button btgenerar;
    }
}