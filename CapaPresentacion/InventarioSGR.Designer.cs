
namespace CapaPresentacion
{
    partial class InventarioSGR
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
            System.Windows.Forms.Label nombreArticuloLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventarioSGR));
            this.btnCerrarSGR = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.vInventarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sICITSAVDataSet = new CapaPresentacion.SICITSAVDataSet();
            this.nombreArticuloTextBox = new System.Windows.Forms.TextBox();
            this.btnCancelarCIS = new System.Windows.Forms.Button();
            this.btnGuardarCis = new System.Windows.Forms.Button();
            this.btnModificarCIS = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.vInventarioDataGridView = new System.Windows.Forms.DataGridView();
            this.vInventarioTableAdapter = new CapaPresentacion.SICITSAVDataSetTableAdapters.vInventarioTableAdapter();
            this.tableAdapterManager = new CapaPresentacion.SICITSAVDataSetTableAdapters.TableAdapterManager();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sGRToolStrip = new System.Windows.Forms.ToolStrip();
            this.sGRToolStripButton = new System.Windows.Forms.ToolStripButton();
            nombreArticuloLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarSGR)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vInventarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sICITSAVDataSet)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vInventarioDataGridView)).BeginInit();
            this.sGRToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // nombreArticuloLabel
            // 
            nombreArticuloLabel.AutoSize = true;
            nombreArticuloLabel.Location = new System.Drawing.Point(44, 24);
            nombreArticuloLabel.Name = "nombreArticuloLabel";
            nombreArticuloLabel.Size = new System.Drawing.Size(85, 13);
            nombreArticuloLabel.TabIndex = 6;
            nombreArticuloLabel.Text = "Nombre Articulo:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(44, 62);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(66, 13);
            descripcionLabel.TabIndex = 7;
            descripcionLabel.Text = "Descripcion:";
            // 
            // btnCerrarSGR
            // 
            this.btnCerrarSGR.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarSGR.Image")));
            this.btnCerrarSGR.Location = new System.Drawing.Point(3, 2);
            this.btnCerrarSGR.Name = "btnCerrarSGR";
            this.btnCerrarSGR.Size = new System.Drawing.Size(16, 20);
            this.btnCerrarSGR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrarSGR.TabIndex = 1;
            this.btnCerrarSGR.TabStop = false;
            this.btnCerrarSGR.Click += new System.EventHandler(this.btnCerrarSGR_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(35, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Servicios generales";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.btnCerrarSGR);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 25);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.sGRToolStrip);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(950, 100);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(descripcionLabel);
            this.panel3.Controls.Add(this.descripcionTextBox);
            this.panel3.Controls.Add(nombreArticuloLabel);
            this.panel3.Controls.Add(this.nombreArticuloTextBox);
            this.panel3.Controls.Add(this.btnCancelarCIS);
            this.panel3.Controls.Add(this.btnGuardarCis);
            this.panel3.Controls.Add(this.btnModificarCIS);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 649);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(950, 100);
            this.panel3.TabIndex = 3;
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vInventarioBindingSource, "Descripcion", true));
            this.descripcionTextBox.Location = new System.Drawing.Point(135, 59);
            this.descripcionTextBox.Multiline = true;
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(408, 20);
            this.descripcionTextBox.TabIndex = 8;
            // 
            // vInventarioBindingSource
            // 
            this.vInventarioBindingSource.DataMember = "vInventario";
            this.vInventarioBindingSource.DataSource = this.sICITSAVDataSet;
            // 
            // sICITSAVDataSet
            // 
            this.sICITSAVDataSet.DataSetName = "SICITSAVDataSet";
            this.sICITSAVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nombreArticuloTextBox
            // 
            this.nombreArticuloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vInventarioBindingSource, "NombreArticulo", true));
            this.nombreArticuloTextBox.Location = new System.Drawing.Point(135, 21);
            this.nombreArticuloTextBox.Name = "nombreArticuloTextBox";
            this.nombreArticuloTextBox.Size = new System.Drawing.Size(218, 20);
            this.nombreArticuloTextBox.TabIndex = 7;
            // 
            // btnCancelarCIS
            // 
            this.btnCancelarCIS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarCIS.Location = new System.Drawing.Point(863, 15);
            this.btnCancelarCIS.Name = "btnCancelarCIS";
            this.btnCancelarCIS.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarCIS.TabIndex = 6;
            this.btnCancelarCIS.Text = "Cancelar";
            this.btnCancelarCIS.UseVisualStyleBackColor = true;
            // 
            // btnGuardarCis
            // 
            this.btnGuardarCis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardarCis.Location = new System.Drawing.Point(782, 15);
            this.btnGuardarCis.Name = "btnGuardarCis";
            this.btnGuardarCis.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarCis.TabIndex = 5;
            this.btnGuardarCis.Text = "Modificar";
            this.btnGuardarCis.UseVisualStyleBackColor = true;
            // 
            // btnModificarCIS
            // 
            this.btnModificarCIS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificarCIS.Location = new System.Drawing.Point(701, 15);
            this.btnModificarCIS.Name = "btnModificarCIS";
            this.btnModificarCIS.Size = new System.Drawing.Size(75, 23);
            this.btnModificarCIS.TabIndex = 4;
            this.btnModificarCIS.Text = "Modificar";
            this.btnModificarCIS.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.vInventarioDataGridView);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 125);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(950, 524);
            this.panel4.TabIndex = 4;
            // 
            // vInventarioDataGridView
            // 
            this.vInventarioDataGridView.AllowUserToAddRows = false;
            this.vInventarioDataGridView.AllowUserToDeleteRows = false;
            this.vInventarioDataGridView.AllowUserToOrderColumns = true;
            this.vInventarioDataGridView.AutoGenerateColumns = false;
            this.vInventarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vInventarioDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5});
            this.vInventarioDataGridView.DataSource = this.vInventarioBindingSource;
            this.vInventarioDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vInventarioDataGridView.Location = new System.Drawing.Point(0, 0);
            this.vInventarioDataGridView.Name = "vInventarioDataGridView";
            this.vInventarioDataGridView.ReadOnly = true;
            this.vInventarioDataGridView.Size = new System.Drawing.Size(950, 524);
            this.vInventarioDataGridView.TabIndex = 0;
            // 
            // vInventarioTableAdapter
            // 
            this.vInventarioTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AreasTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.InventarioTableAdapter = null;
            this.tableAdapterManager.StockTableAdapter = null;
            this.tableAdapterManager.UnidadMedidaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CapaPresentacion.SICITSAVDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Clave";
            this.dataGridViewTextBoxColumn4.HeaderText = "Clave";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "NombreArticulo";
            this.dataGridViewTextBoxColumn1.HeaderText = "Artículo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Descripcion";
            this.dataGridViewTextBoxColumn2.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Cantidad";
            this.dataGridViewTextBoxColumn3.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Medida";
            this.dataGridViewTextBoxColumn5.HeaderText = "Medida";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // sGRToolStrip
            // 
            this.sGRToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.sGRToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.sGRToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sGRToolStripButton});
            this.sGRToolStrip.Location = new System.Drawing.Point(3, 72);
            this.sGRToolStrip.Name = "sGRToolStrip";
            this.sGRToolStrip.Size = new System.Drawing.Size(66, 25);
            this.sGRToolStrip.Stretch = true;
            this.sGRToolStrip.TabIndex = 0;
            this.sGRToolStrip.TabStop = true;
            this.sGRToolStrip.Text = "sGRToolStrip";
            // 
            // sGRToolStripButton
            // 
            this.sGRToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.sGRToolStripButton.Name = "sGRToolStripButton";
            this.sGRToolStripButton.Size = new System.Drawing.Size(32, 22);
            this.sGRToolStripButton.Text = "SGR";
            this.sGRToolStripButton.Click += new System.EventHandler(this.sGRToolStripButton_Click);
            // 
            // InventarioSGR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 749);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InventarioSGR";
            this.Text = "InventarioSGR";
            this.Load += new System.EventHandler(this.InventarioSGR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarSGR)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vInventarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sICITSAVDataSet)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vInventarioDataGridView)).EndInit();
            this.sGRToolStrip.ResumeLayout(false);
            this.sGRToolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btnCerrarSGR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCancelarCIS;
        private System.Windows.Forms.Button btnGuardarCis;
        private System.Windows.Forms.Button btnModificarCIS;
        private System.Windows.Forms.Panel panel4;
        private SICITSAVDataSet sICITSAVDataSet;
        private System.Windows.Forms.BindingSource vInventarioBindingSource;
        private SICITSAVDataSetTableAdapters.vInventarioTableAdapter vInventarioTableAdapter;
        private SICITSAVDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.TextBox nombreArticuloTextBox;
        private System.Windows.Forms.DataGridView vInventarioDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.ToolStrip sGRToolStrip;
        private System.Windows.Forms.ToolStripButton sGRToolStripButton;
    }
}