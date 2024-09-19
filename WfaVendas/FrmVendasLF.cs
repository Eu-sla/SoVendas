using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WfaVendas.LP2DataSet1TableAdapters;

namespace WfaVendas
{
    public partial class FrmVendasLF : Form
    {
        bool incluir = false;
        bool editar = false;
        bool editarItem = false;
        bool incluirItem = false;
        double precoTemp = 0;

        public FrmVendasLF()
        {
            InitializeComponent();
        }

        private void FrmVendasLF_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'lP2DataSet.pc_produto'. Você pode movê-la ou removê-la conforme necessário.
            this.pc_produtoTableAdapter.Fill(this.lP2DataSet.pc_produto);
            // TODO: esta linha de código carrega dados na tabela 'lP2DataSet.pc_clientes'. Você pode movê-la ou removê-la conforme necessário.
            this.pc_clientesTableAdapter.Fill(this.lP2DataSet.pc_clientes);
            // TODO: esta linha de código carrega dados na tabela 'lP2DataSet.pc_itemvenda'. Você pode movê-la ou removê-la conforme necessário.
            this.pc_itemvendaTableAdapter.Fill(this.lP2DataSet.pc_itemvenda);
            // TODO: esta linha de código carrega dados na tabela 'lP2DataSet.pc_venda'. Você pode movê-la ou removê-la conforme necessário.
            this.pc_vendaTableAdapter.Fill(this.lP2DataSet.pc_venda);
            if (dgvVendas.Rows.Count > 0)
            {
                dgvVendas.Rows[0].Selected = true;
            }
        }

        private void habilitaCampos(bool hab)
        {
            txtNumVenda.Enabled = hab;
            cmbCliente.Enabled = hab;
            dtpDataVenda.Enabled = hab;
            dtpDataVenda.Enabled = hab;
            txtObs.Enabled = hab;
        }
        private void habilitaCamposItem(bool hab)
        {
            cmbProduto.Enabled = hab;
            nudQuantidade.Enabled = hab;
        }
        private void habilitaBotoes(bool hab)
        {
            btnIncluir.Enabled = hab;
            btnExcluir.Enabled = hab;
            btnAlterar.Enabled = hab;
            btnPesquisar.Enabled = hab;
            btnSair.Enabled = hab;
            btnGravar.Enabled = hab;
            btnCancelar.Enabled = hab;
        }
        private void habilitaBotoesItem(bool hab)
        {
            btnIncluirItem.Enabled = hab;
            btnExcluirItem.Enabled = hab;
            btnAlterarItem.Enabled = hab;
            btnPesquisarItem.Enabled = hab;
            btnSair.Enabled = hab;
            btnGravarItem.Enabled = hab;
            btnCancelarItem.Enabled = hab;
        }

        private void limpaCampos(Control local)//(Form form) //TODO mostrar
        {
            foreach (Control item in local.Controls)//form.Controls)
            {
                if (item is TextBox)//(item is TextBox || item is MaskedTextBox)
                {
                    ((TextBox)item).Clear();
                    if (((TextBox)item).Name == "txtPrecoUnit"
                        || ((TextBox)item).Name == "txtSubTotal"
                        || ((TextBox)item).Name == "txtTotal")
                    {
                        ((TextBox)item).Text = "R$ 0,00";
                    }
                }
                if (item is NumericUpDown)
                {
                    ((NumericUpDown)item).Value = 1;
                }
                if (item is MaskedTextBox)
                {
                    ((MaskedTextBox)item).Clear();
                }
                if (item is ComboBox)
                {
                    if (((ComboBox)item).Items.Count > 0)
                    {
                        ((ComboBox)item).SelectedIndex = 0;
                    }
                }
                if (item is DateTimePicker)
                {
                    ((DateTimePicker)item).Value = DateTime.Now;
                }
            }
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            incluir = true;
            habilitaCampos(true);
            habilitaBotoes(false);
            txtNumVenda.Focus();
        }
        private void dgvVendas_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvVendas.RowCount > 0) //TODO mostrar
                {
                    this.pc_itemvendaTableAdapter.FillByNumVenda(this.lP2DataSet.pc_itemvenda,
                        Convert.ToInt32(dgvVendas[0, dgvVendas.CurrentRow.Index].Value.ToString()));
                    if (dgvItens.RowCount > 0)
                    {
                        double total = (double)pc_itemvendaTableAdapter.TotalVenda(
                            Convert.ToInt32(dgvVendas[0, dgvVendas.CurrentRow.Index].Value.ToString()));
                        txtTotal.Text = total.ToString("R$ #,###,##0.00");
                    }
                    else
                    {
                        txtTotal.Text = "R$ 0,00";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(null, "Ocorreu um erro:\n" + ex.Message,
                    "Erro ao acessar os Itens da VENDA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }
        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                if (incluir)
                {
                    pc_vendaTableAdapter.Insert(
                        (int)cmbCliente.SelectedValue, dtpDataVenda.Value, dtpDataVenda.Value, txtObs.Text);
                    MessageBox.Show(null, "Incluído com sucesso!", "Inclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (editar)
                {
                    pc_vendaTableAdapter.Update(Convert.ToInt32(cmbCliente.SelectedValue), dtpDataVenda.Value,
                        dtpDataVenda.Value, txtObs.Text, Convert.ToInt32(txtNumVenda.Text));
                    MessageBox.Show(null, "Alterado com sucesso!", "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                btnCancelar_Click(null, null);
                FrmVendasLF_Load(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(null, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpaCampos(this);//TODO mostrar
            limpaCampos(grpItem);
            habilitaCampos(false);
            habilitaBotoes(false);
            incluir = false;
            editar = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if(dgvVendas.SelectedRows.Count > 0)
            {
                editar = true;
                habilitaBotoes(false);
                habilitaCampos(true);
                txtNumVenda.Enabled = false;
                txtNumVenda.Text = dgvVendas[0, dgvVendas.CurrentRow.Index].Value.ToString();
                cmbCliente.SelectedValue = Convert.ToInt32(dgvVendas[1, dgvVendas.CurrentRow.Index].Value.ToString());
                dtpDataVenda.Value = Convert.ToDateTime(dgvVendas[3, dgvVendas.CurrentRow.Index].Value.ToString());
                dtpDataEntrega.Value = Convert.ToDateTime(dgvVendas[4, dgvVendas.CurrentRow.Index].Value.ToString());
                txtObs.Text = dgvVendas[5, dgvVendas.CurrentRow.Index].Value.ToString();
                cmbCliente.Focus();
            }
            else
            {
                MessageBox.Show(null, "Selecione uma VENDA primeiro!", "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPesquisar_Click (object sender, EventArgs e)
        {
            if(cmbCliente.Enabled == false)
            {
                cmbCliente.Enabled = true;
                cmbCliente.Focus ();
                habilitaBotoes(false);
                btnPesquisar.Enabled = true;
                btnCancelar.Enabled = false;
                MessageBox.Show(null, "Digite o nome do cliente desejado ou\nparte dele.", "Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                pc_vendaTableAdapter.FillByNome(this.lP2DataSet.pc_venda, "%" + cmbCliente.Text + "%");
                btnCancelar_Click(null, null);
            }
        }

        private void btnIncluirItem_Click (object sender, EventArgs e)
        {
            incluirItem = true;
            habilitaCamposItem(true);
            habilitaBotoesItem(false);
            cmbProduto_SelectedIndexChanged(null, null);
            cmbProduto.Focus    ();
        }

        private void cmbProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable produto = pc_produtoTableAdapter.GetDataBy(cmbProduto.Text);
            precoTemp = 0;
            foreach (DataRow row in produto.Rows)
            {
                precoTemp = Convert.ToDouble(row["precounit"].ToString());
            }
            nudQuantidade.Value = 1;
            txtPrecounit.Text = precoTemp.ToString("R$ #,###,##0.00");
            txtSubtotal.Text = precoTemp.ToString("R$ #,###,##0.00");
        }

        private void btnExcluirItem_Click(object sender, EventArgs e)
        {
            try
            {
                if(dgvVendas.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show(null, "Deseja mesmo excluir o ITEM selecionado?", "Atenção:", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes) 
                    {
                        pc_itemvendaTableAdapter.Delete(
                            Convert.ToInt32(dgvVendas[0, dgvVendas.CurrentRow.Index].Value.ToString()),
                            Convert.ToInt32(dgvItens[0, dgvItens.CurrentRow.Index].Value.ToString()));
                        dgvVendas_SelectionChanged(null, null);
                        MessageBox.Show(null, "Apagado com sucesso!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                else
                {
                    MessageBox.Show(null, "Selecione um item primeiro!", "Erro ao excluir:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } catch (Exception ex)
            {
                MessageBox.Show(null, "Ocorreu um erro:\n" + ex.Message,"Erro ao excluir:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAlterarItem_Click(object sender, EventArgs e)
        {
            if(dgvVendas.SelectedRows.Count > 0)
            {
                editarItem = true;
                habilitaBotoesItem(false);
                habilitaCamposItem(true);
                cmbProduto.Text = dgvItens[1, dgvItens.CurrentRow.Index].Value.ToString();
                cmbProduto_SelectedIndexChanged(null, null);
                nudQuantidade.Value = Convert.ToInt32(
                    dgvItens[2, dgvItens.CurrentRow.Index].Value.ToString());
                cmbProduto.Focus();
            }
            else
            {
                MessageBox.Show(null, "Selecione um ITEM primeiro!", "Erro:",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPesquisarItem_Click(object sender, EventArgs e)
        {
            try
            {
                if(dgvItens.RowCount > 0)
                {
                    if(cmbProduto.Enabled == false)
                    {
                        cmbProduto.Enabled = true;
                        cmbProduto.Focus();
                        habilitaBotoesItem(false);
                        btnPesquisarItem.Enabled = true;
                        btnGravarItem.Enabled = false;
                        btnCancelarItem.Enabled = false;
                        MessageBox.Show(null, "Didite o no nome do ITEM desejado ou \nparte dele", "Pesquisa",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        pc_itemvendaTableAdapter.FillByDescricao(this.lP2DataSet.pc_itemvenda, Convert.ToInt32(dgvVendas[0, dgvVendas.CurrentRow.Index].Value.ToString()), "%" + cmbProduto.Text + "%");
                        btnCancelarItem_Click(null, null);
                    }
                }
            }
        }

        private void btnCancelarItem_Click(object sender, EventArgs e)
        {
            limpaCampos(grpItem);
            habilitaCamposItem(false);
            habilitaBotoesItem(true);
            editarItem = false;
            incluirItem = false;
        }

        private void nudQuantidade_ValueChanged(object sender, EventArgs e)
        {
            double subTotal = (Int32)nudQuantidade.Value * precoTemp;
            txtSubtotal.Text = subTotal.ToString("R$ #,###,##0.00");

        }
    }
}

