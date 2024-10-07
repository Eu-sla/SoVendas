
namespace WfaVendas
{
    partial class FrmRptVendas
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
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lP2DataSet1 = new WfaVendas.LP2DataSet();
            this.rptVendasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rptVendasTableAdapter1 = new WfaVendas.LP2DataSetTableAdapters.RptVendasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.lP2DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptVendasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "WfaVendas.RptVendas.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(0, 0);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(654, 419);
            this.reportViewer2.TabIndex = 0;
            // 
            // lP2DataSet1
            // 
            this.lP2DataSet1.DataSetName = "LP2DataSet";
            this.lP2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rptVendasBindingSource
            // 
            this.rptVendasBindingSource.DataMember = "RptVendas";
            this.rptVendasBindingSource.DataSource = this.lP2DataSet1;
            // 
            // rptVendasTableAdapter1
            // 
            this.rptVendasTableAdapter1.ClearBeforeFill = true;
            // 
            // FrmRptVendas
            // 
            this.ClientSize = new System.Drawing.Size(654, 419);
            this.Controls.Add(this.reportViewer2);
            this.Name = "FrmRptVendas";
            this.Load += new System.EventHandler(this.FrmRptVendas_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.lP2DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptVendasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private LP2DataSet LP2DataSet;
        private LP2DataSetTableAdapters.RptVendasTableAdapter RptVendasTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private LP2DataSet lP2DataSet1;
        private System.Windows.Forms.BindingSource rptVendasBindingSource;
        private LP2DataSetTableAdapters.RptVendasTableAdapter rptVendasTableAdapter1;
    }
}