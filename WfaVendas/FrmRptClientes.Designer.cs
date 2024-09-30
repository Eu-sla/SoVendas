namespace WfaVendas
{
    partial class FrmRptClientes
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lP2DataSet = new WfaVendas.LP2DataSet();
            this.lP2DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pc_clientesTableAdapter1 = new WfaVendas.LP2DataSetTableAdapters.pc_clientesTableAdapter();
            this.pc_clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pcclientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.lP2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lP2DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcclientesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.pcclientesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WfaVendas.RptClientes.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // lP2DataSet
            // 
            this.lP2DataSet.DataSetName = "LP2DataSet";
            this.lP2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lP2DataSetBindingSource
            // 
            this.lP2DataSetBindingSource.DataSource = this.lP2DataSet;
            this.lP2DataSetBindingSource.Position = 0;
            // 
            // pc_clientesTableAdapter1
            // 
            this.pc_clientesTableAdapter1.ClearBeforeFill = true;
            // 
            // pc_clientesBindingSource
            // 
            this.pc_clientesBindingSource.DataMember = "pc_clientes";
            this.pc_clientesBindingSource.DataSource = this.lP2DataSet;
            // 
            // pcclientesBindingSource
            // 
            this.pcclientesBindingSource.DataMember = "pc_clientes";
            this.pcclientesBindingSource.DataSource = this.lP2DataSet;
            // 
            // FrmRptClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmRptClientes";
            this.Text = "FrmRptClientes";
            this.Load += new System.EventHandler(this.FrmRptClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lP2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lP2DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcclientesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource lP2DataSetBindingSource;
        private LP2DataSet lP2DataSet;
        private LP2DataSetTableAdapters.pc_clientesTableAdapter pc_clientesTableAdapter1;
        private System.Windows.Forms.BindingSource pc_clientesBindingSource;
        private System.Windows.Forms.BindingSource pcclientesBindingSource;
    }
}