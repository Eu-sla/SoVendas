namespace WfaVendas
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.mnuMenu = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeVendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeSeuTemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatoriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatorioDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatorioDeVendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatorioDeProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatorioDoSeuTemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.janelasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.organizarNaHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.organizarNaVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.organizarEmCascataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.relatórioDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioDeVendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.sstStatus = new System.Windows.Forms.StatusStrip();
            this.sslTexto = new System.Windows.Forms.ToolStripStatusLabel();
            this.sslHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.tmrHora = new System.Windows.Forms.Timer(this.components);
            this.mnuMenu.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.sstStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMenu
            // 
            this.mnuMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.arquivoToolStripMenuItem,
            this.relatoriosToolStripMenuItem,
            this.janelasToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.mnuMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMenu.MdiWindowListItem = this.janelasToolStripMenuItem;
            this.mnuMenu.Name = "mnuMenu";
            this.mnuMenu.Size = new System.Drawing.Size(800, 24);
            this.mnuMenu.TabIndex = 1;
            this.mnuMenu.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeClientesToolStripMenuItem,
            this.cadastroDeVendasToolStripMenuItem,
            this.cadastroDeProdutosToolStripMenuItem,
            this.cadastroDeSeuTemaToolStripMenuItem,
            this.toolStripSeparator1,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "&Arquivo";
            // 
            // cadastroDeClientesToolStripMenuItem
            // 
            this.cadastroDeClientesToolStripMenuItem.Name = "cadastroDeClientesToolStripMenuItem";
            this.cadastroDeClientesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.cadastroDeClientesToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.cadastroDeClientesToolStripMenuItem.Text = "Cadastro de &Clientes";
            this.cadastroDeClientesToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeClientesToolStripMenuItem_Click);
            // 
            // cadastroDeVendasToolStripMenuItem
            // 
            this.cadastroDeVendasToolStripMenuItem.Name = "cadastroDeVendasToolStripMenuItem";
            this.cadastroDeVendasToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.cadastroDeVendasToolStripMenuItem.Text = "Cadastro de &Vendas";
            this.cadastroDeVendasToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeVendasToolStripMenuItem_Click);
            // 
            // cadastroDeProdutosToolStripMenuItem
            // 
            this.cadastroDeProdutosToolStripMenuItem.Name = "cadastroDeProdutosToolStripMenuItem";
            this.cadastroDeProdutosToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.cadastroDeProdutosToolStripMenuItem.Text = "Cadastro de &Produtos";
            // 
            // cadastroDeSeuTemaToolStripMenuItem
            // 
            this.cadastroDeSeuTemaToolStripMenuItem.Name = "cadastroDeSeuTemaToolStripMenuItem";
            this.cadastroDeSeuTemaToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.cadastroDeSeuTemaToolStripMenuItem.Text = "Cadastro de Seu Tema";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(253, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.sairToolStripMenuItem.Text = "Sai&r";
            // 
            // relatoriosToolStripMenuItem
            // 
            this.relatoriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.relatorioDeClientesToolStripMenuItem,
            this.relatorioDeVendasToolStripMenuItem,
            this.relatorioDeProdutosToolStripMenuItem,
            this.relatorioDoSeuTemaToolStripMenuItem});
            this.relatoriosToolStripMenuItem.Name = "relatoriosToolStripMenuItem";
            this.relatoriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatoriosToolStripMenuItem.Text = "&Relatórios";
            // 
            // relatorioDeClientesToolStripMenuItem
            // 
            this.relatorioDeClientesToolStripMenuItem.Name = "relatorioDeClientesToolStripMenuItem";
            this.relatorioDeClientesToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.relatorioDeClientesToolStripMenuItem.Text = "Relatório de &Clientes";
            this.relatorioDeClientesToolStripMenuItem.Click += new System.EventHandler(this.relatorioDeClientesToolStripMenuItem_Click);
            // 
            // relatorioDeVendasToolStripMenuItem
            // 
            this.relatorioDeVendasToolStripMenuItem.Name = "relatorioDeVendasToolStripMenuItem";
            this.relatorioDeVendasToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.relatorioDeVendasToolStripMenuItem.Text = "Relatório de &Vendas";
            // 
            // relatorioDeProdutosToolStripMenuItem
            // 
            this.relatorioDeProdutosToolStripMenuItem.Name = "relatorioDeProdutosToolStripMenuItem";
            this.relatorioDeProdutosToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.relatorioDeProdutosToolStripMenuItem.Text = "Relatório de &Produtos";
            // 
            // relatorioDoSeuTemaToolStripMenuItem
            // 
            this.relatorioDoSeuTemaToolStripMenuItem.Name = "relatorioDoSeuTemaToolStripMenuItem";
            this.relatorioDoSeuTemaToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.relatorioDoSeuTemaToolStripMenuItem.Text = "Relatório do Seu Tema";
            // 
            // janelasToolStripMenuItem
            // 
            this.janelasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.organizarNaHorizontalToolStripMenuItem,
            this.organizarNaVerticalToolStripMenuItem,
            this.organizarEmCascataToolStripMenuItem});
            this.janelasToolStripMenuItem.Name = "janelasToolStripMenuItem";
            this.janelasToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.janelasToolStripMenuItem.Text = "&Janelas";
            // 
            // organizarNaHorizontalToolStripMenuItem
            // 
            this.organizarNaHorizontalToolStripMenuItem.Name = "organizarNaHorizontalToolStripMenuItem";
            this.organizarNaHorizontalToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.organizarNaHorizontalToolStripMenuItem.Text = "Organizar na &Horizontal";
            // 
            // organizarNaVerticalToolStripMenuItem
            // 
            this.organizarNaVerticalToolStripMenuItem.Name = "organizarNaVerticalToolStripMenuItem";
            this.organizarNaVerticalToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.organizarNaVerticalToolStripMenuItem.Text = "Organizar na &Vertical";
            // 
            // organizarEmCascataToolStripMenuItem
            // 
            this.organizarEmCascataToolStripMenuItem.Name = "organizarEmCascataToolStripMenuItem";
            this.organizarEmCascataToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.organizarEmCascataToolStripMenuItem.Text = "Organizar em &Cascata";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Aj&uda";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.sobreToolStripMenuItem.Text = "&Sobre...";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator2,
            this.toolStripSplitButton1,
            this.toolStripSeparator3,
            this.toolStripButton5});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "toolStripButton4";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.relatórioDeClientesToolStripMenuItem,
            this.relatórioDeVendasToolStripMenuItem});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(32, 22);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            this.toolStripSplitButton1.ButtonClick += new System.EventHandler(this.toolStripSplitButton1_ButtonClick);
            // 
            // relatórioDeClientesToolStripMenuItem
            // 
            this.relatórioDeClientesToolStripMenuItem.Name = "relatórioDeClientesToolStripMenuItem";
            this.relatórioDeClientesToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.relatórioDeClientesToolStripMenuItem.Text = "Relatório de &Clientes";
            this.relatórioDeClientesToolStripMenuItem.Click += new System.EventHandler(this.relatórioDeClientesToolStripMenuItem_Click);
            // 
            // relatórioDeVendasToolStripMenuItem
            // 
            this.relatórioDeVendasToolStripMenuItem.Name = "relatórioDeVendasToolStripMenuItem";
            this.relatórioDeVendasToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.relatórioDeVendasToolStripMenuItem.Text = "Relatório de &Vendas";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "toolStripButton5";
            // 
            // sstStatus
            // 
            this.sstStatus.AutoSize = false;
            this.sstStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sslTexto,
            this.sslHora});
            this.sstStatus.Location = new System.Drawing.Point(0, 428);
            this.sstStatus.Name = "sstStatus";
            this.sstStatus.Size = new System.Drawing.Size(800, 22);
            this.sstStatus.TabIndex = 4;
            this.sstStatus.Text = "statusStrip1";
            // 
            // sslTexto
            // 
            this.sslTexto.AutoSize = false;
            this.sslTexto.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.sslTexto.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.sslTexto.Name = "sslTexto";
            this.sslTexto.Size = new System.Drawing.Size(605, 17);
            this.sslTexto.Spring = true;
            // 
            // sslHora
            // 
            this.sslHora.AutoSize = false;
            this.sslHora.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.sslHora.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.sslHora.Name = "sslHora";
            this.sslHora.Size = new System.Drawing.Size(180, 17);
            this.sslHora.Text = "toolStripStatusLabel2";
            // 
            // tmrHora
            // 
            this.tmrHora.Enabled = true;
            this.tmrHora.Interval = 1000;
            this.tmrHora.Tick += new System.EventHandler(this.tmrHora_Tick);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sstStatus);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.mnuMenu);
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.mnuMenu;
            this.Name = "FrmMenu";
            this.Text = "Controle de Vendas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMenu_FormClosing);
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.mnuMenu.ResumeLayout(false);
            this.mnuMenu.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.sstStatus.ResumeLayout(false);
            this.sstStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip sstStatus;
        private System.Windows.Forms.Timer tmrHora;
        private System.Windows.Forms.ToolStripStatusLabel sslTexto;
        private System.Windows.Forms.ToolStripStatusLabel sslHora;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatoriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem janelasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeVendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatorioDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatorioDeVendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatorioDeProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatorioDoSeuTemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem organizarNaHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem organizarNaVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem organizarEmCascataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeSeuTemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripMenuItem relatórioDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatórioDeVendasToolStripMenuItem;
    }
}