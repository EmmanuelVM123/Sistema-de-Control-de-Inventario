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
    public partial class PanelSubMaestro : Form
    {
        public PanelSubMaestro()
        {
            InitializeComponent();
        }

        private void PanelSubMaestro_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sICITSAVDataSet.vITN' Puede moverla o quitarla según sea necesario.
            this.vITNTableAdapter.vITN_Fill(this.sICITSAVDataSet.vITN);
            // TODO: esta línea de código carga datos en la tabla 'sICITSAVDataSet.vMNT' Puede moverla o quitarla según sea necesario.
            this.vMNTTableAdapter.vMNT_FILL(this.sICITSAVDataSet.vMNT);
            // TODO: esta línea de código carga datos en la tabla 'sICITSAVDataSet.vCIS' Puede moverla o quitarla según sea necesario.
            this.vCISTableAdapter.vCIS_FILL(this.sICITSAVDataSet.vCIS);
            // TODO: esta línea de código carga datos en la tabla 'sICITSAVDataSet.vInventarioSGR' Puede moverla o quitarla según sea necesario.
            this.vInventarioSGRTableAdapter.SGR(this.sICITSAVDataSet.vInventarioSGR);
            // TODO: esta línea de código carga datos en la tabla 'sICITSAVDataSet.Areas' Puede moverla o quitarla según sea necesario.
            this.areasTableAdapter.Fill(this.sICITSAVDataSet.Areas);
            // TODO: esta línea de código carga datos en la tabla 'sICITSAVDataSet.vInventario' Puede moverla o quitarla según sea necesario.
            this.vInventarioTableAdapter.Fill(this.sICITSAVDataSet.vInventario);

        }

        private void btnCerrarCIS_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
