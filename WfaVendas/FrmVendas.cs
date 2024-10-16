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
using WfaVendas.LP2DataSetTableAdapters;

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
            // TODO: esta linha de código carrega dados na tabela 'lP2DataSet.pc_clientes'. Você pode movê-la ou removê-la conforme necessário.
            this.pc_clientesTableAdapter.Fill(this.lP2DataSet.pc_clientes);
            // TODO: esta linha de código carrega dados na tabela 'lP2DataSet.pc_produto'. Você pode movê-la ou removê-la conforme necessário.
            this.pc_produtoTableAdapter1.Fill(this.lP2DataSet.pc_produto);
            // TODO: esta linha de código carrega dados na tabela 'lP2DataSet1.pc_produto'. Você pode movê-la ou removê-la conforme necessário.
            //this.pc_produtoTableAdapter.Fill(this.lP2DataSet1.pc_produto);
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
                    control.Enabled = hab;
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
                        ((ComboBox)item).SelectedIndex = 0;
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
                if (dgvVendas.SelectedRows.Count > 0)
                {
                    this.pc_itemvendaTableAdapter.FillByNumVenda(this.lP2DataSet.pc_itemvenda, Convert.ToInt32(dgvVendas[0, dgvVendas.CurrentRow.Index].Value.ToString()));
                    if (dgvItens.RowCount > 0)
                    {
                        double total = (Double)pc_itemvendaTableAdapter.TotalVenda(Convert.ToInt32(dgvVendas[0, dgvVendas.CurrentRow.Index].Value.ToString()));
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
            //DataTable produto = pc_produtoTableAdapter.GetDataByNumVenda(cmbProduto.Text);
            /*DataTable produto = pc_produtoTableAdapter.GetDataByDescricao(cmbProduto.Text);
            precotemp = 0;
            foreach (DataRow row in produto.Rows)
            {
                precotemp = Convert.ToDouble(row["precounit"].ToString());
            }
            nudQuantidade.Value = 1;
            txtPrecounit.Text = precotemp.ToString("R$ #,###,##0.00");
            txtSubtotal.Text = precotemp.ToString("R$ #,###,##0.00");
            */
            if (cmbProduto.Text != "")
            {
                DataTable produto = pc_produtoTableAdapter.GetDataByDescricao(cmbProduto.Text); // TODO: Arrumar o GetDataBy no database, capaz de ter que arrumar em todos os tables

                precotemp = 0; // Zerar precoTemp para garantir o cálculo

                foreach (DataRow row in produto.Rows)
                {
                    precotemp = Convert.ToDouble(row["precounit"].ToString());
                }

                nudQuantidade.Value = 1;
                txtPrecounit.Text = precotemp.ToString("R$ #,###,##0.00");
                txtSubtotal.Text = precotemp.ToString("R$ #,###,##0.00");
            }
        }

        private void nudQuantidade_ValueChanged(object sender, EventArgs e)
        {
            double subTotal = (Int32)nudQuantidade.Value * precotemp;
            txtSubtotal.Text = subTotal.ToString("R$ #,###,##0.00");
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            incluir = true;
            habilitaCampos(this, true);
            habilitaBotoes(this, false);
            //cmbCliente.Focus();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvVendas.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show(null, "Deseja mesmo excluir a venda selecionada?", "Atenção:", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                    {
                        pc_itemvendaTableAdapter.DeleteTodos(Convert.ToInt32(dgvVendas[0, dgvVendas.CurrentRow.Index].Value.ToString()));
                        pc_vendaTableAdapter.Delete(Convert.ToInt32(dgvVendas[0, dgvVendas.CurrentRow.Index].Value.ToString()));
                        FrmVendas_Load(null, null);
                        MessageBox.Show(null, "Apagado com sucesso!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    MessageBox.Show(null, "Selecione uma venda primeiro!", "Erro ao excluir", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(null, "Ocorreu um erro:\n" + ex.Message, "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                if (incluir)
                {
                    pc_vendaTableAdapter.Insert((Int32)cmbCliente.SelectedValue, dtpVenda.Value, dtpEntrega.Value, txtObs.Text);
                    MessageBox.Show("Incluído com sucesso!", "Aviso:", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    pc_vendaTableAdapter.Update((Int32)cmbCliente.SelectedValue, dtpVenda.Value, dtpEntrega.Value, txtObs.Text, Convert.ToInt32(txtNumvenda.Text));
                    MessageBox.Show(null, "Alterado com sucesso!", "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                FrmVendas_Load(null, null);
                btnCancelar_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro :\n" + ex.Message, "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            incluir = false;
            habilitaBotoes(this, true);
            habilitaCampos(this, false);
            habilitaBotoes(grpItens, true);
            habilitaCampos(grpItens, false);
            LimpaCampos(this);
            LimpaCampos(grpItens);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if(dgvVendas.SelectedRows.Count >0)
            {
                incluir = false;
                habilitaBotoes(this, false);
                habilitaCampos(this, true);
                txtNumvenda.Enabled = false;
                txtNumvenda.Text = dgvVendas[0, dgvVendas.CurrentRow.Index].Value.ToString();
                cmbCliente.SelectedValue = Convert.ToInt32(dgvVendas[1, dgvVendas.CurrentRow.Index].Value.ToString());
                dtpVenda.Value = Convert.ToDateTime(dgvVendas[2, dgvVendas.CurrentRow.Index].Value.ToString());
                dtpEntrega.Value = Convert.ToDateTime(dgvVendas[3, dgvVendas.CurrentRow.Index].Value.ToString());
                txtObs.Text = dgvVendas[5, dgvVendas.CurrentRow.Index].Value.ToString();
                cmbCliente.Focus();
            }
            else
            {
                MessageBox.Show(null, "Selecione uma VENDA primeiro!", "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if(cmbCliente.Enabled == false)
            {
                cmbCliente.Enabled = true;
                cmbCliente.Focus ();
                habilitaBotoes(this, false);
                btnPesquisar.Enabled = true;
                btnGravar.Enabled = false;
                btnCancelar.Enabled = false;
                MessageBox.Show(null, "Digite o nome do cliente desejado ou" + "\nparte dele", "Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                pc_vendaTableAdapter.FillByNome(this.lP2DataSet.pc_venda, "%" + cmbCliente.Text + "%");
                btnCancelar_Click(null, null);
            }
        }

        //inicio item

        private void HabilitaBotoesItem(bool hab)
        {
            btnAlterarItem.Enabled = hab;
            btnExcluirItem.Enabled = hab;
            btnPesquisarItem.Enabled = hab;
            btnIncluirItem.Enabled = hab;
            btnGravarItem.Enabled = !hab;
            btnCancelarItem.Enabled = !hab;
        }

        private void btnIncluirItem_Click(object sender, EventArgs e)
        {
            incluirItem = true;
            HabilitaCamposItem(true);
            HabilitaBotoesItem( false);
            cmbProduto_SelectedIndexChanged(null, null);
            cmbProduto.Focus();
        }
        private void HabilitaCamposItem(bool hab)
        {
            cmbProduto.Enabled = hab;
            nudQuantidade.Enabled = hab;
        }

        private void btnExcluirItem_Click(object sender, EventArgs e)
        {
            try
            {
                if(dgvItens.SelectedRows.Count > 0)
                {
                    if(MessageBox.Show(null, "Deseja mesmo excluir os itens da venda?", "Atenção:", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                    {
                        pc_itemvendaTableAdapter.DeleteTodos(
                            Convert.ToInt32(dgvVendas[0, dgvVendas.CurrentRow.Index].Value.ToString()));
                        dgvVendas_SelectionChanged(null, null);
                        MessageBox.Show(null, "Apagado com sucesso!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show(null, "Selecione um item primeiro!", "Erro ao excluir:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(null, "Ocorreu um erro:\n" + ex.Message, "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAlterarItem_Click(object sender, EventArgs e)
        {
            if(dgvItens.SelectedRows.Count > 0)
            {
                incluirItem = false;
                HabilitaBotoesItem( false);
                HabilitaCamposItem( true);
                cmbProduto.Text = dgvItens[1, dgvItens.CurrentRow.Index].Value.ToString();
                cmbProduto.Enabled = false;
                cmbProduto_SelectedIndexChanged(null, null);
                nudQuantidade.Value = Convert.ToInt32(dgvItens[2, dgvItens.CurrentRow.Index].Value.ToString());
                cmbProduto.Focus();
            }
            else
            {
                MessageBox.Show(null, "Selecione um ITEM primeiro!", "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error );
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
                        HabilitaBotoesItem(false);
                        btnPesquisarItem.Enabled = true;
                        btnGravarItem.Enabled = false;
                        btnCancelarItem.Enabled = false;
                        MessageBox.Show(null, "Digite o nome do ITEM desejado ou" + "\nparte dele.", "Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        pc_itemvendaTableAdapter.FillByDescricao(this.lP2DataSet.pc_itemvenda, Convert.ToInt32(dgvVendas[0, dgvVendas.CurrentRow.Index].Value.ToString()), Convert.ToInt32(cmbProduto.Text));
                        btnCancelarItem_Click(null, null);
                    }
                }
                else
                {
                    MessageBox.Show(null, "Cadastre um item primeiro!", "Erro ao excluir:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(null, "Ocorreu um erro:\n" + ex.Message, "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
        }

        private void btnCancelarItem_Click(object sender, EventArgs e)
        {
            LimpaCampos(grpItens);
            HabilitaBotoesItem(true);
            HabilitaCamposItem(false);
            incluirItem = false;
        }

        private void btnGravarItem_Click(object sender, EventArgs e)
        {
            try
            {
                if(incluirItem == true)
                {
                    pc_itemvendaTableAdapter.Insert(Convert.ToInt32(dgvVendas[0, dgvVendas.CurrentRow.Index].Value.ToString()), (Int32)cmbProduto.SelectedValue, (Int32)nudQuantidade.Value, precotemp);
                    MessageBox.Show(null, "Incluido com sucesso!", "Inclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    pc_itemvendaTableAdapter.Update((Int32)cmbProduto.SelectedValue, (Int32)nudQuantidade.Value, precotemp, Convert.ToInt32(dgvVendas[0, dgvVendas.CurrentRow.Index].Value.ToString()),
                        Convert.ToInt32(dgvItens[0, dgvItens.CurrentRow.Index].Value.ToString()));
                    MessageBox.Show(null, "Alterado com sucesso!", "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Information );
                }
                dgvVendas_SelectionChanged(null, null);
                btnCancelarItem_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(null, "Ocorreu um erro: " + ex.Message, "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            FrmVendas_Load(null, null);
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.pc_itemvendaTableAdapter.FillBy(this.lP2DataSet.pc_itemvenda);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
