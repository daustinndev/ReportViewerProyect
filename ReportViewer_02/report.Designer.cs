namespace ReportViewer_02
{
    partial class report
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ventaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vENTADataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vENTADataSet = new ReportViewer_02.VENTADataSet();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vENTADataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vENTADataSet1 = new ReportViewer_02.VENTADataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ventaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ventaTableAdapter = new ReportViewer_02.VENTADataSetTableAdapters.ventaTableAdapter();
            this.ventaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.ventaTableAdapter1 = new ReportViewer_02.VENTADataSet1TableAdapters.ventaTableAdapter();
            this.clientesTableAdapter = new ReportViewer_02.VENTADataSet1TableAdapters.clientesTableAdapter();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ventaBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ventaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENTADataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENTADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENTADataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENTADataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // ventaBindingSource1
            // 
            this.ventaBindingSource1.DataMember = "venta";
            this.ventaBindingSource1.DataSource = this.vENTADataSetBindingSource;
            // 
            // vENTADataSetBindingSource
            // 
            this.vENTADataSetBindingSource.DataSource = this.vENTADataSet;
            this.vENTADataSetBindingSource.Position = 0;
            // 
            // vENTADataSet
            // 
            this.vENTADataSet.DataSetName = "VENTADataSet";
            this.vENTADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "clientes";
            this.clientesBindingSource.DataSource = this.vENTADataSet1BindingSource;
            // 
            // vENTADataSet1BindingSource
            // 
            this.vENTADataSet1BindingSource.DataSource = this.vENTADataSet1;
            this.vENTADataSet1BindingSource.Position = 0;
            // 
            // vENTADataSet1
            // 
            this.vENTADataSet1.DataSetName = "VENTADataSet1";
            this.vENTADataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.ventaBindingSource1;
            reportDataSource4.Name = "DataSet2";
            reportDataSource4.Value = this.ventaBindingSource3;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ReportViewer_02.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, -1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(873, 562);
            this.reportViewer1.TabIndex = 0;
            // 
            // ventaBindingSource
            // 
            this.ventaBindingSource.DataMember = "venta";
            this.ventaBindingSource.DataSource = this.vENTADataSet;
            // 
            // ventaTableAdapter
            // 
            this.ventaTableAdapter.ClearBeforeFill = true;
            // 
            // ventaBindingSource2
            // 
            this.ventaBindingSource2.DataMember = "venta";
            this.ventaBindingSource2.DataSource = this.vENTADataSet1BindingSource;
            // 
            // ventaTableAdapter1
            // 
            this.ventaTableAdapter1.ClearBeforeFill = true;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // usuariosBindingSource
            // 

            // 
            // ventaBindingSource3
            // 
            this.ventaBindingSource3.DataMember = "venta";
            this.ventaBindingSource3.DataSource = this.vENTADataSet1BindingSource;
            // 
            // report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 556);
            this.Controls.Add(this.reportViewer1);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.Name = "report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de Venta";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ventaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENTADataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENTADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENTADataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENTADataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaBindingSource3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource vENTADataSetBindingSource;
        private VENTADataSet vENTADataSet;
        private System.Windows.Forms.BindingSource ventaBindingSource;
        private System.Windows.Forms.BindingSource ventaBindingSource1;
        private VENTADataSetTableAdapters.ventaTableAdapter ventaTableAdapter;
        private System.Windows.Forms.BindingSource vENTADataSet1BindingSource;
        private VENTADataSet1 vENTADataSet1;
        private System.Windows.Forms.BindingSource ventaBindingSource2;
        private VENTADataSet1TableAdapters.ventaTableAdapter ventaTableAdapter1;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private VENTADataSet1TableAdapters.clientesTableAdapter clientesTableAdapter;

        private System.Windows.Forms.BindingSource usuariosBindingSource;

        private System.Windows.Forms.BindingSource ventaBindingSource3;
    }
}

