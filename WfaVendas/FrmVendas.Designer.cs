namespace WfaVendas
{
    partial class FrmVendas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label lblNumVenda;
            System.Windows.Forms.Label datavendaLabel;
            System.Windows.Forms.Label dataentregaLabel;
            System.Windows.Forms.Label obsLabel;
            System.Windows.Forms.Label codproLabel;
            System.Windows.Forms.Label quantidadeLabel;
            System.Windows.Forms.Label precounitLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label codcliLabel;
            System.Windows.Forms.Label label3;
            this.btnSair = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.lP2DataSet = new WfaVendas.LP2DataSet();
            this.pc_vendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pc_vendaTableAdapter = new WfaVendas.LP2DataSetTableAdapters.pc_vendaTableAdapter();
            this.tableAdapterManager = new WfaVendas.LP2DataSetTableAdapters.TableAdapterManager();
            this.pc_itemvendaTableAdapter = new WfaVendas.LP2DataSetTableAdapters.pc_itemvendaTableAdapter();
            this.txtNumvenda = new System.Windows.Forms.TextBox();
            this.dtpVenda = new System.Windows.Forms.DateTimePicker();
            this.dtpEntrega = new System.Windows.Forms.DateTimePicker();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.grpItens = new System.Windows.Forms.GroupBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.btnCancelarItem = new System.Windows.Forms.Button();
            this.txtPrecounit = new System.Windows.Forms.TextBox();
            this.btnGravarItem = new System.Windows.Forms.Button();
            this.btnPesquisarItem = new System.Windows.Forms.Button();
            this.btnExcluirItem = new System.Windows.Forms.Button();
            this.nudQuantidade = new System.Windows.Forms.NumericUpDown();
            this.btnAlterarItem = new System.Windows.Forms.Button();
            this.btnIncluirItem = new System.Windows.Forms.Button();
            this.pc_itemvendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pcprodutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lP2DataSet1 = new WfaVendas.LP2DataSet1();
            this.panel1 = new System.Windows.Forms.Panel();
            this.jdkjhf = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.pcclientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pc_produtoTableAdapter = new WfaVendas.LP2DataSet1TableAdapters.pc_produtoTableAdapter();
            this.btnTodos = new System.Windows.Forms.Button();
            this.pc_produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pc_produtoTableAdapter1 = new WfaVendas.LP2DataSetTableAdapters.pc_produtoTableAdapter();
            this.lP2DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pc_clientesTableAdapter = new WfaVendas.LP2DataSetTableAdapters.pc_clientesTableAdapter();
            this.dgvItens = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvVendas = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbProduto = new System.Windows.Forms.ComboBox();
            lblNumVenda = new System.Windows.Forms.Label();
            datavendaLabel = new System.Windows.Forms.Label();
            dataentregaLabel = new System.Windows.Forms.Label();
            obsLabel = new System.Windows.Forms.Label();
            codproLabel = new System.Windows.Forms.Label();
            quantidadeLabel = new System.Windows.Forms.Label();
            precounitLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            codcliLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lP2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_vendaBindingSource)).BeginInit();
            this.grpItens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_itemvendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcprodutoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lP2DataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcclientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lP2DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumVenda
            // 
            lblNumVenda.AutoSize = true;
            lblNumVenda.ForeColor = System.Drawing.SystemColors.Window;
            lblNumVenda.Location = new System.Drawing.Point(113, 44);
            lblNumVenda.Name = "lblNumVenda";
            lblNumVenda.Size = new System.Drawing.Size(41, 13);
            lblNumVenda.TabIndex = 15;
            lblNumVenda.Text = "Venda:";
            // 
            // datavendaLabel
            // 
            datavendaLabel.AutoSize = true;
            datavendaLabel.ForeColor = System.Drawing.SystemColors.Window;
            datavendaLabel.Location = new System.Drawing.Point(72, 70);
            datavendaLabel.Name = "datavendaLabel";
            datavendaLabel.Size = new System.Drawing.Size(82, 13);
            datavendaLabel.TabIndex = 19;
            datavendaLabel.Text = "Data da Venda:";
            // 
            // dataentregaLabel
            // 
            dataentregaLabel.AutoSize = true;
            dataentregaLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataentregaLabel.Location = new System.Drawing.Point(386, 70);
            dataentregaLabel.Name = "dataentregaLabel";
            dataentregaLabel.Size = new System.Drawing.Size(88, 13);
            dataentregaLabel.TabIndex = 21;
            dataentregaLabel.Text = "Data da Entrega:";
            // 
            // obsLabel
            // 
            obsLabel.AutoSize = true;
            obsLabel.ForeColor = System.Drawing.SystemColors.Window;
            obsLabel.Location = new System.Drawing.Point(93, 93);
            obsLabel.Name = "obsLabel";
            obsLabel.Size = new System.Drawing.Size(27, 13);
            obsLabel.TabIndex = 23;
            obsLabel.Text = "obs:";
            // 
            // codproLabel
            // 
            codproLabel.AutoSize = true;
            codproLabel.Location = new System.Drawing.Point(58, 50);
            codproLabel.Name = "codproLabel";
            codproLabel.Size = new System.Drawing.Size(47, 13);
            codproLabel.TabIndex = 0;
            codproLabel.Text = "Produto:";
            // 
            // quantidadeLabel
            // 
            quantidadeLabel.AutoSize = true;
            quantidadeLabel.Location = new System.Drawing.Point(204, 50);
            quantidadeLabel.Name = "quantidadeLabel";
            quantidadeLabel.Size = new System.Drawing.Size(65, 13);
            quantidadeLabel.TabIndex = 2;
            quantidadeLabel.Text = "Quantidade:";
            // 
            // precounitLabel
            // 
            precounitLabel.AutoSize = true;
            precounitLabel.Location = new System.Drawing.Point(358, 50);
            precounitLabel.Name = "precounitLabel";
            precounitLabel.Size = new System.Drawing.Size(77, 13);
            precounitLabel.TabIndex = 4;
            precounitLabel.Text = "Preço Unitário:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(499, 50);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(49, 13);
            label1.TabIndex = 33;
            label1.Text = "Subtotal:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(823, 18);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(27, 13);
            label2.TabIndex = 35;
            label2.Text = "total";
            // 
            // codcliLabel
            // 
            codcliLabel.AutoSize = true;
            codcliLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            codcliLabel.Location = new System.Drawing.Point(432, 44);
            codcliLabel.Name = "codcliLabel";
            codcliLabel.Size = new System.Drawing.Size(42, 13);
            codcliLabel.TabIndex = 26;
            codcliLabel.Text = "Cliente:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            label3.Location = new System.Drawing.Point(647, 15);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(34, 13);
            label3.TabIndex = 35;
            label3.Text = "Total:";
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.SeaShell;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSair.Location = new System.Drawing.Point(638, 7);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 14;
            this.btnSair.Text = "Sai&r";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.SeaShell;
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancelar.Location = new System.Drawing.Point(539, 7);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.BackColor = System.Drawing.Color.SeaShell;
            this.btnGravar.Enabled = false;
            this.btnGravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGravar.Location = new System.Drawing.Point(440, 7);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 12;
            this.btnGravar.Text = "&Gravar";
            this.btnGravar.UseVisualStyleBackColor = false;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.SeaShell;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPesquisar.Location = new System.Drawing.Point(341, 7);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 11;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.SeaShell;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExcluir.Location = new System.Drawing.Point(242, 7);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 10;
            this.btnExcluir.Text = "&Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.SeaShell;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAlterar.Location = new System.Drawing.Point(143, 7);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 9;
            this.btnAlterar.Text = "&Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.BackColor = System.Drawing.Color.SeaShell;
            this.btnIncluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnIncluir.Location = new System.Drawing.Point(44, 7);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnIncluir.TabIndex = 8;
            this.btnIncluir.Text = "&Incluir";
            this.btnIncluir.UseVisualStyleBackColor = false;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // lP2DataSet
            // 
            this.lP2DataSet.DataSetName = "LP2DataSet";
            this.lP2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pc_vendaBindingSource
            // 
            this.pc_vendaBindingSource.DataMember = "pc_venda";
            this.pc_vendaBindingSource.DataSource = this.lP2DataSet;
            // 
            // pc_vendaTableAdapter
            // 
            this.pc_vendaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.pc_clientesTableAdapter = null;
            this.tableAdapterManager.pc_itemvendaTableAdapter = this.pc_itemvendaTableAdapter;
            this.tableAdapterManager.pc_produtoTableAdapter = null;
            this.tableAdapterManager.pc_vendaTableAdapter = this.pc_vendaTableAdapter;
            this.tableAdapterManager.UpdateOrder = WfaVendas.LP2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pc_itemvendaTableAdapter
            // 
            this.pc_itemvendaTableAdapter.ClearBeforeFill = true;
            // 
            // txtNumvenda
            // 
            this.txtNumvenda.Enabled = false;
            this.txtNumvenda.Location = new System.Drawing.Point(166, 41);
            this.txtNumvenda.Name = "txtNumvenda";
            this.txtNumvenda.ReadOnly = true;
            this.txtNumvenda.Size = new System.Drawing.Size(151, 20);
            this.txtNumvenda.TabIndex = 16;
            // 
            // dtpVenda
            // 
            this.dtpVenda.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pc_vendaBindingSource, "datavenda", true));
            this.dtpVenda.Enabled = false;
            this.dtpVenda.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpVenda.Location = new System.Drawing.Point(166, 66);
            this.dtpVenda.Name = "dtpVenda";
            this.dtpVenda.Size = new System.Drawing.Size(151, 20);
            this.dtpVenda.TabIndex = 20;
            this.dtpVenda.Value = new System.DateTime(2024, 9, 15, 0, 0, 0, 0);
            // 
            // dtpEntrega
            // 
            this.dtpEntrega.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pc_vendaBindingSource, "dataentrega", true));
            this.dtpEntrega.Enabled = false;
            this.dtpEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEntrega.Location = new System.Drawing.Point(480, 66);
            this.dtpEntrega.Name = "dtpEntrega";
            this.dtpEntrega.Size = new System.Drawing.Size(144, 20);
            this.dtpEntrega.TabIndex = 22;
            this.dtpEntrega.Value = new System.DateTime(2024, 9, 18, 0, 0, 0, 0);
            // 
            // txtObs
            // 
            this.txtObs.Enabled = false;
            this.txtObs.Location = new System.Drawing.Point(122, 93);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(512, 40);
            this.txtObs.TabIndex = 24;
            // 
            // grpItens
            // 
            this.grpItens.BackColor = System.Drawing.SystemColors.ControlLight;
            this.grpItens.Controls.Add(this.cmbProduto);
            this.grpItens.Controls.Add(label1);
            this.grpItens.Controls.Add(this.txtSubtotal);
            this.grpItens.Controls.Add(precounitLabel);
            this.grpItens.Controls.Add(this.btnCancelarItem);
            this.grpItens.Controls.Add(this.txtPrecounit);
            this.grpItens.Controls.Add(this.btnGravarItem);
            this.grpItens.Controls.Add(this.btnPesquisarItem);
            this.grpItens.Controls.Add(quantidadeLabel);
            this.grpItens.Controls.Add(this.btnExcluirItem);
            this.grpItens.Controls.Add(this.nudQuantidade);
            this.grpItens.Controls.Add(this.btnAlterarItem);
            this.grpItens.Controls.Add(codproLabel);
            this.grpItens.Controls.Add(this.btnIncluirItem);
            this.grpItens.ForeColor = System.Drawing.SystemColors.WindowText;
            this.grpItens.Location = new System.Drawing.Point(78, 278);
            this.grpItens.Name = "grpItens";
            this.grpItens.Size = new System.Drawing.Size(657, 109);
            this.grpItens.TabIndex = 25;
            this.grpItens.TabStop = false;
            this.grpItens.Text = "Itens da Venda";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Enabled = false;
            this.txtSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubtotal.Location = new System.Drawing.Point(502, 66);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(100, 20);
            this.txtSubtotal.TabIndex = 34;
            this.txtSubtotal.Text = "R$ 0,00";
            // 
            // btnCancelarItem
            // 
            this.btnCancelarItem.BackColor = System.Drawing.Color.Snow;
            this.btnCancelarItem.Enabled = false;
            this.btnCancelarItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancelarItem.Location = new System.Drawing.Point(539, 19);
            this.btnCancelarItem.Name = "btnCancelarItem";
            this.btnCancelarItem.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarItem.TabIndex = 31;
            this.btnCancelarItem.Text = "&Cancelar";
            this.btnCancelarItem.UseVisualStyleBackColor = false;
            this.btnCancelarItem.Click += new System.EventHandler(this.btnCancelarItem_Click);
            // 
            // txtPrecounit
            // 
            this.txtPrecounit.Location = new System.Drawing.Point(361, 68);
            this.txtPrecounit.Name = "txtPrecounit";
            this.txtPrecounit.ReadOnly = true;
            this.txtPrecounit.Size = new System.Drawing.Size(100, 20);
            this.txtPrecounit.TabIndex = 5;
            // 
            // btnGravarItem
            // 
            this.btnGravarItem.BackColor = System.Drawing.Color.Snow;
            this.btnGravarItem.Enabled = false;
            this.btnGravarItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravarItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGravarItem.Location = new System.Drawing.Point(440, 19);
            this.btnGravarItem.Name = "btnGravarItem";
            this.btnGravarItem.Size = new System.Drawing.Size(75, 23);
            this.btnGravarItem.TabIndex = 30;
            this.btnGravarItem.Text = "&Gravar";
            this.btnGravarItem.UseVisualStyleBackColor = false;
            this.btnGravarItem.Click += new System.EventHandler(this.btnGravarItem_Click);
            // 
            // btnPesquisarItem
            // 
            this.btnPesquisarItem.BackColor = System.Drawing.Color.Snow;
            this.btnPesquisarItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPesquisarItem.Location = new System.Drawing.Point(341, 19);
            this.btnPesquisarItem.Name = "btnPesquisarItem";
            this.btnPesquisarItem.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisarItem.TabIndex = 29;
            this.btnPesquisarItem.Text = "&Pesquisar";
            this.btnPesquisarItem.UseVisualStyleBackColor = false;
            this.btnPesquisarItem.Click += new System.EventHandler(this.btnPesquisarItem_Click);
            // 
            // btnExcluirItem
            // 
            this.btnExcluirItem.BackColor = System.Drawing.Color.Snow;
            this.btnExcluirItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExcluirItem.Location = new System.Drawing.Point(242, 19);
            this.btnExcluirItem.Name = "btnExcluirItem";
            this.btnExcluirItem.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirItem.TabIndex = 28;
            this.btnExcluirItem.Text = "&Excluir";
            this.btnExcluirItem.UseVisualStyleBackColor = false;
            this.btnExcluirItem.Click += new System.EventHandler(this.btnExcluirItem_Click);
            // 
            // nudQuantidade
            // 
            this.nudQuantidade.Location = new System.Drawing.Point(207, 67);
            this.nudQuantidade.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudQuantidade.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuantidade.Name = "nudQuantidade";
            this.nudQuantidade.Size = new System.Drawing.Size(120, 20);
            this.nudQuantidade.TabIndex = 3;
            this.nudQuantidade.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuantidade.ValueChanged += new System.EventHandler(this.nudQuantidade_ValueChanged);
            // 
            // btnAlterarItem
            // 
            this.btnAlterarItem.BackColor = System.Drawing.Color.Snow;
            this.btnAlterarItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAlterarItem.Location = new System.Drawing.Point(143, 19);
            this.btnAlterarItem.Name = "btnAlterarItem";
            this.btnAlterarItem.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarItem.TabIndex = 27;
            this.btnAlterarItem.Text = "&Alterar";
            this.btnAlterarItem.UseVisualStyleBackColor = false;
            this.btnAlterarItem.Click += new System.EventHandler(this.btnAlterarItem_Click);
            // 
            // btnIncluirItem
            // 
            this.btnIncluirItem.BackColor = System.Drawing.Color.Snow;
            this.btnIncluirItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluirItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnIncluirItem.Location = new System.Drawing.Point(44, 19);
            this.btnIncluirItem.Name = "btnIncluirItem";
            this.btnIncluirItem.Size = new System.Drawing.Size(75, 23);
            this.btnIncluirItem.TabIndex = 26;
            this.btnIncluirItem.Text = "&Incluir";
            this.btnIncluirItem.UseVisualStyleBackColor = false;
            this.btnIncluirItem.Click += new System.EventHandler(this.btnIncluirItem_Click);
            // 
            // pc_itemvendaBindingSource
            // 
            this.pc_itemvendaBindingSource.DataMember = "pc_itemvenda";
            this.pc_itemvendaBindingSource.DataSource = this.lP2DataSet;
            // 
            // pcprodutoBindingSource
            // 
            this.pcprodutoBindingSource.DataMember = "pc_produto";
            this.pcprodutoBindingSource.DataSource = this.lP2DataSet1;
            // 
            // lP2DataSet1
            // 
            this.lP2DataSet1.DataSetName = "LP2DataSet1";
            this.lP2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.jdkjhf);
            this.panel1.Controls.Add(label3);
            this.panel1.Controls.Add(label2);
            this.panel1.Controls.Add(this.txtTotal);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 542);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(808, 48);
            this.panel1.TabIndex = 26;
            // 
            // jdkjhf
            // 
            this.jdkjhf.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.jdkjhf.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pc_itemvendaBindingSource, "precounit", true));
            this.jdkjhf.ForeColor = System.Drawing.Color.Tomato;
            this.jdkjhf.Location = new System.Drawing.Point(687, 12);
            this.jdkjhf.Name = "jdkjhf";
            this.jdkjhf.ReadOnly = true;
            this.jdkjhf.Size = new System.Drawing.Size(100, 20);
            this.jdkjhf.TabIndex = 35;
            this.jdkjhf.Text = "R$ 0,00";
            // 
            // txtTotal
            // 
            this.txtTotal.ForeColor = System.Drawing.Color.LightCoral;
            this.txtTotal.Location = new System.Drawing.Point(883, 15);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 36;
            this.txtTotal.Text = "R$ 0.00";
            // 
            // cmbCliente
            // 
            this.cmbCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCliente.DataSource = this.pcclientesBindingSource;
            this.cmbCliente.DisplayMember = "nome";
            this.cmbCliente.Enabled = false;
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(480, 41);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(144, 21);
            this.cmbCliente.TabIndex = 27;
            this.cmbCliente.ValueMember = "codcli";
            // 
            // pcclientesBindingSource
            // 
            this.pcclientesBindingSource.DataMember = "pc_clientes";
            this.pcclientesBindingSource.DataSource = this.lP2DataSet;
            // 
            // pc_produtoTableAdapter
            // 
            this.pc_produtoTableAdapter.ClearBeforeFill = true;
            // 
            // btnTodos
            // 
            this.btnTodos.Location = new System.Drawing.Point(713, 110);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(75, 23);
            this.btnTodos.TabIndex = 28;
            this.btnTodos.Text = "Rese&tar";
            this.btnTodos.UseVisualStyleBackColor = true;
            this.btnTodos.Click += new System.EventHandler(this.btnTodos_Click);
            // 
            // pc_produtoBindingSource
            // 
            this.pc_produtoBindingSource.DataMember = "pc_produto";
            this.pc_produtoBindingSource.DataSource = this.lP2DataSet;
            // 
            // pc_produtoTableAdapter1
            // 
            this.pc_produtoTableAdapter1.ClearBeforeFill = true;
            // 
            // lP2DataSetBindingSource
            // 
            this.lP2DataSetBindingSource.DataSource = this.lP2DataSet;
            this.lP2DataSetBindingSource.Position = 0;
            // 
            // pc_clientesTableAdapter
            // 
            this.pc_clientesTableAdapter.ClearBeforeFill = true;
            // 
            // dgvItens
            // 
            this.dgvItens.AllowUserToAddRows = false;
            this.dgvItens.AllowUserToDeleteRows = false;
            this.dgvItens.AutoGenerateColumns = false;
            this.dgvItens.BackgroundColor = System.Drawing.Color.Bisque;
            this.dgvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.dgvItens.DataSource = this.pc_itemvendaBindingSource;
            this.dgvItens.Location = new System.Drawing.Point(12, 393);
            this.dgvItens.MultiSelect = false;
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.ReadOnly = true;
            this.dgvItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItens.Size = new System.Drawing.Size(776, 129);
            this.dgvItens.TabIndex = 28;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "numvenda";
            this.dataGridViewTextBoxColumn6.HeaderText = "numvenda";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "codpro";
            this.dataGridViewTextBoxColumn7.HeaderText = "codpro";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "quantidade";
            this.dataGridViewTextBoxColumn8.HeaderText = "quantidade";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "precounit";
            this.dataGridViewTextBoxColumn9.HeaderText = "precounit";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "descricao";
            this.dataGridViewTextBoxColumn11.HeaderText = "descricao";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Subtotal";
            this.dataGridViewTextBoxColumn12.HeaderText = "Subtotal";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dgvVendas
            // 
            this.dgvVendas.AllowUserToAddRows = false;
            this.dgvVendas.AllowUserToDeleteRows = false;
            this.dgvVendas.AutoGenerateColumns = false;
            this.dgvVendas.BackgroundColor = System.Drawing.Color.Bisque;
            this.dgvVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn10});
            this.dgvVendas.DataSource = this.pc_vendaBindingSource;
            this.dgvVendas.Location = new System.Drawing.Point(17, 139);
            this.dgvVendas.MultiSelect = false;
            this.dgvVendas.Name = "dgvVendas";
            this.dgvVendas.ReadOnly = true;
            this.dgvVendas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvVendas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVendas.Size = new System.Drawing.Size(771, 133);
            this.dgvVendas.TabIndex = 28;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "numvenda";
            this.dataGridViewTextBoxColumn1.HeaderText = "numvenda";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "codcli";
            this.dataGridViewTextBoxColumn2.HeaderText = "codcli";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "datavenda";
            this.dataGridViewTextBoxColumn3.HeaderText = "datavenda";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "dataentrega";
            this.dataGridViewTextBoxColumn4.HeaderText = "dataentrega";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "obs";
            this.dataGridViewTextBoxColumn5.HeaderText = "obs";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "nome";
            this.dataGridViewTextBoxColumn10.HeaderText = "nome";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // cmbProduto
            // 
            this.cmbProduto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbProduto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pc_itemvendaBindingSource, "codpro", true));
            this.cmbProduto.DataSource = this.pc_itemvendaBindingSource;
            this.cmbProduto.DisplayMember = "descricao";
            this.cmbProduto.FormattingEnabled = true;
            this.cmbProduto.Location = new System.Drawing.Point(61, 68);
            this.cmbProduto.Name = "cmbProduto";
            this.cmbProduto.Size = new System.Drawing.Size(121, 21);
            this.cmbProduto.TabIndex = 35;
            this.cmbProduto.ValueMember = "descricao";
            // 
            // FrmVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(808, 590);
            this.Controls.Add(this.dgvVendas);
            this.Controls.Add(this.dgvItens);
            this.Controls.Add(this.btnTodos);
            this.Controls.Add(codcliLabel);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grpItens);
            this.Controls.Add(lblNumVenda);
            this.Controls.Add(this.txtNumvenda);
            this.Controls.Add(datavendaLabel);
            this.Controls.Add(this.dtpVenda);
            this.Controls.Add(dataentregaLabel);
            this.Controls.Add(this.dtpEntrega);
            this.Controls.Add(obsLabel);
            this.Controls.Add(this.txtObs);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnIncluir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmVendas";
            this.Text = "Cadastro de Vendas";
            this.Load += new System.EventHandler(this.FrmVendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lP2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_vendaBindingSource)).EndInit();
            this.grpItens.ResumeLayout(false);
            this.grpItens.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_itemvendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcprodutoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lP2DataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcclientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lP2DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnIncluir;
        private LP2DataSet lP2DataSet;
        private System.Windows.Forms.BindingSource pc_vendaBindingSource;
        private LP2DataSetTableAdapters.pc_vendaTableAdapter pc_vendaTableAdapter;
        private LP2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private LP2DataSetTableAdapters.pc_itemvendaTableAdapter pc_itemvendaTableAdapter;
        private System.Windows.Forms.TextBox txtNumvenda;
        private System.Windows.Forms.DateTimePicker dtpVenda;
        private System.Windows.Forms.DateTimePicker dtpEntrega;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.GroupBox grpItens;
        private System.Windows.Forms.BindingSource pc_itemvendaBindingSource;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Button btnCancelarItem;
        private System.Windows.Forms.TextBox txtPrecounit;
        private System.Windows.Forms.Button btnGravarItem;
        private System.Windows.Forms.Button btnPesquisarItem;
        private System.Windows.Forms.Button btnExcluirItem;
        private System.Windows.Forms.NumericUpDown nudQuantidade;
        private System.Windows.Forms.Button btnAlterarItem;
        private System.Windows.Forms.Button btnIncluirItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.ComboBox cmbCliente;
        private LP2DataSet1 lP2DataSet1;
        private System.Windows.Forms.BindingSource pcprodutoBindingSource;
        private LP2DataSet1TableAdapters.pc_produtoTableAdapter pc_produtoTableAdapter;
        private System.Windows.Forms.TextBox jdkjhf;
        private System.Windows.Forms.Button btnTodos;
        private System.Windows.Forms.BindingSource pc_produtoBindingSource;
        private LP2DataSetTableAdapters.pc_produtoTableAdapter pc_produtoTableAdapter1;
        private System.Windows.Forms.BindingSource lP2DataSetBindingSource;
        private System.Windows.Forms.BindingSource pcclientesBindingSource;
        private LP2DataSetTableAdapters.pc_clientesTableAdapter pc_clientesTableAdapter;
        private System.Windows.Forms.DataGridView dgvItens;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridView dgvVendas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.ComboBox cmbProduto;
    }
}