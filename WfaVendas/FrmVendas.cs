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
        double precotemp = 0;
        public FrmVendas()
        {
            InitializeComponent();
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

        private void habilitaCampos(Control container, bool hab)
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

        private void habilitaBotoes(Control container, bool hab)
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
                else if(item is NumericUpDown)
                {
                    ((NumericUpDown)item).Value = 1;
                }else if(item is MaskedTextBox)
                {
                    ((MaskedTextBox)item).Clear();
                }else if(item is ComboBox)
                {
                    if(((ComboBox)item).Items.Count > 0){
                        ((ComboBox)item).SelectedIndex = 0
                    }
                }else if(item is DateTimePicker)
                {
                    ((DateTimePicker)item).Value = DateTime.Now;
                }
            }

        }

        private void dgvVendas_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvVendas > 0)
                {
                    this.pc_itemvendaTableAdapter.FillByNumVenda(this.vendasDataSet.pc_itemvenda, Convert.ToInt32(dgvVendas[0, dgvVendas.CurrentRow.Index].Value.ToString()));
                    if (dgvItens.RowCount > 0)
                    {
                        double total = (Double)pc_itemvendaTableAdapter.TotalVenda(
                           Convert.ToInt32(dgvVendas[0, dgvVendas.CurrentRow.Index].Value.ToString()));
                        txtTotal.Text = total.ToString("R$ #,###,##0.00");
                    } else
                    {
                        txtTotal.Text = "R$ 0,00";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(null, "Ocorreu um erro:\n" + ex.Message, "Erro ao acessar os Itens da VENDA:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbProduto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nudQuantidade_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            incluir = true;
            habilitaCampos(this, true);
            habilitaBotoes(this, false);
            txtNumvenda.Focus();
        }
    }
}
