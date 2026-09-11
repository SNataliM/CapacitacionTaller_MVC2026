using System;
using Capa_Controlador_MVC1;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_MVC1
{
    public partial class FrmPrincipal : Form
    {
        string nombreTabla = "tbl_roles";
        Controlador controlador = new Controlador();
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        public void actualizarDgv()
        {
           DataTable dtVista = controlador.llenarDgv(nombreTabla);
            dgvConsultaTabla.DataSource = dtVista;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            actualizarDgv();
        }
    }
}
