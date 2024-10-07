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
    public partial class FrmRptVendas : Form
    {
        public FrmRptVendas()
        {
            InitializeComponent();
        }

        private void FrmRptVendas_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void FrmRptVendas_Load_1(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'lP2DataSet1.RptVendas'. Você pode movê-la ou removê-la conforme necessário.
            this.rptVendasTableAdapter1.Fill(this.lP2DataSet1.RptVendas);

            this.reportViewer2.RefreshReport();
        }
    }
}
