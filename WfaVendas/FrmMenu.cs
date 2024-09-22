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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void tmrHora_Tick(object sender, EventArgs e)
        {
            sslHora.Text = DateTime.Now.ToString("dd/MM/yyyy - HH:mm:ss");
        }

        private void cadastroDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(Form form in MdiChildren)
            {
                if (form is FrmCadCliente)
                {
                    form.Focus();
                    return;
                }

            }
            FrmCadCliente frmCadCliente = new FrmCadCliente();
            frmCadCliente.MdiParent = this;
            frmCadCliente.Show();
        }

        private void FrmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo sair?", "Atenção:", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void cadastroDeVendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in MdiChildren)
            {
                if (form is FrmVendas)
                {
                    form.Focus();
                    return;
                }

            }
            FrmVendas frmVendas = new FrmVendas();
            frmVendas.MdiParent = this;
            frmVendas.Show();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
