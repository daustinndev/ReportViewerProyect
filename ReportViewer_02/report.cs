using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportViewer_02
{
    public partial class report : Form
    {
        public report()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'vENTADataSet2.usuarios' Puede moverla o quitarla según sea necesario.
           
            // TODO: esta línea de código carga datos en la tabla 'vENTADataSet1.clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.vENTADataSet1.clientes);
            // TODO: esta línea de código carga datos en la tabla 'vENTADataSet1.venta' Puede moverla o quitarla según sea necesario.
            this.ventaTableAdapter1.Fill(this.vENTADataSet1.venta);
            // TODO: esta línea de código carga datos en la tabla 'vENTADataSet.venta' Puede moverla o quitarla según sea necesario.
            this.ventaTableAdapter.Fill(this.vENTADataSet.venta);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            //this.reportViewer2.RefreshReport();
        }
    }
}
