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
    public partial class panelPrincipal : Form
    {
        public panelPrincipal()
        {
            InitializeComponent();
        }

        private void panelPrincipal_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sICITSAVDataSet.vInventario' Puede moverla o quitarla según sea necesario.
            

        }

        private void OcultarSubMenus()
        {
            if (subMenu.Visible == false)
                subMenu.Visible = false;
            if (panel1.Visible == false)
                panel1.Visible = false;
            if (panel2.Visible == false)
                panel2.Visible = false;
        }

        private void MostrarSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                OcultarSubMenus();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;

        }
        private void AbrirFormulario<MiFormulario>() where MiFormulario : Form, new()
        {
            Form formulario;
            formulario = panelFormularios.Controls.OfType<MiFormulario>().FirstOrDefault(); //Busca en la coleción el formulario
            //Si el formulario/instancia no exite
            if (formulario == null)
            {
                formulario = new MiFormulario();
                formulario.TopLevel = false;
                formulario.Dock = DockStyle.Fill;
                panelFormularios.Controls.Add(formulario);
                panelFormularios.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            //Si el formulario/instancia existe
            else
            {
                formulario.BringToFront();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormulario<InventarioCIS>();
        }

        private void btnInventarioAreas_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(subMenu);
        }

        private void btnSGR_Click(object sender, EventArgs e)
        {
            AbrirFormulario<InventarioSGR>();
        }
    }
}
