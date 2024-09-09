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
    public partial class FrmVendas : Form
    {
        bool incluir = false;
        bool exibir = false;
        bool incluirItem = false;
        bool exibirItem = false;
        double precotemp;
        public FrmVendas()
        {
            InitializeComponent();
        }

        private void pc_clientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pc_clientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lP2DataSet);

        }

        private void pc_vendaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pc_vendaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lP2DataSet);

        }

        private void FrmVendas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'lP2DataSet1.pc_produto'. Você pode movê-la ou removê-la conforme necessário.
            this.pc_produtoTableAdapter.Fill(this.lP2DataSet1.pc_produto);
            // TODO: esta linha de código carrega dados na tabela 'lP2DataSet.pc_itemvenda'. Você pode movê-la ou removê-la conforme necessário.
            this.pc_itemvendaTableAdapter.Fill(this.lP2DataSet.pc_itemvenda);
            // TODO: esta linha de código carrega dados na tabela 'lP2DataSet.pc_venda'. Você pode movê-la ou removê-la conforme necessário.
            this.pc_vendaTableAdapter.Fill(this.lP2DataSet.pc_venda);
            if(dgvVendas.Rows.Count > 0)
            {
                dgvVendas.Rows[0].Selected = true;
            }

        }

        private void HabilitaCampos(Control container, bool hab)
        {
            foreach(Control control in container.Controls)
            {
                if(control is TextBox || control is DateTimePicker || control is ComboBox || control is NumericUpDown)
                {
                    ((TextBox)control).Enabled = hab;
                    // talvez control.Enabled = hab; se der problema
                }

            }
        }

        private void HabilitaBotoes(Control container, bool hab)
        {
            foreach (Control control in container.Controls)
            {
                if (control is Button)
                {
                    control.Enabled = hab;
                    if (control.Text == "&Gravar" || control.Text == "&Cancelar")
                    {
                        control.Enabled = !hab;
                    }
                }
            }
        }
        private void LimpaCampos(Control container)
        {
            foreach( Control item in container.Controls)
            {
                if(item is TextBox)
                {
                    ((TextBox)item).Text = "";
                    if (((TextBox)item).Name == "txtPrecounit" || ((TextBox)item).Name == "txtSubtotal" || ((TextBox)item).Name == "txtTotal")
                    {
                        ((TextBox)item).Text = "R$ 0.00";
                    }
                }
            }
        }

        private void dgvVendas_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void cmbProduto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nudQuantidade_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
