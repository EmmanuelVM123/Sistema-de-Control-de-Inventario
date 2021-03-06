using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class InventarioSGR : Form
    {
        public InventarioSGR()
        {
            InitializeComponent();
        }

        private void InventarioSGR_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sICITSAVDataSet.vInventario' Puede moverla o quitarla según sea necesario.
            this.vInventarioTableAdapter.Fill(this.sICITSAVDataSet.vInventario);

        }


        private void btnCerrarSGR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sGRToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.vInventarioTableAdapter.SGR(this.sICITSAVDataSet.vInventario);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
