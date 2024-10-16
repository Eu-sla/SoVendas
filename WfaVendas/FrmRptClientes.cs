using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WfaVendas
{
    public partial class FrmRptClientes : Form
    {
        public FrmRptClientes()
        {
            InitializeComponent();
        }

        private void FrmRptClientes_Load(object sender, EventArgs e)
        {
             this.pc_clientesTableAdapter1.Fill(this.lP2DataSet.pc_clientes);
            this.reportViewer1.RefreshReport();
             
        }
    }
}
