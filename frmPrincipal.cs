using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbarrotesMario
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void verCreditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vistas.frmBuscarDeudor frm = new Vistas.frmBuscarDeudor();
            frm.ShowDialog();
        }

        private void nuevaVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vistas.frmVentas frm = new Vistas.frmVentas();
            frm.ShowDialog();
        }

        private void verVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vistas.frmVerVenta frm = new Vistas.frmVerVenta();
            frm.ShowDialog();
        }

        private void corteCajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vistas.frmCorteCaja frm = new Vistas.frmCorteCaja();
            frm.ShowDialog();
        }

        private void nuevaCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vistas.frmCompras frm = new Vistas.frmCompras();
            frm.ShowDialog();
        }

        private void verCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vistas.frmVerCompra frm = new Vistas.frmVerCompra();
            frm.ShowDialog();
        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vistas.frmInventario frm = new Vistas.frmInventario();
            frm.ShowDialog();

        }

        private void sucursalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vistas.frmSucursales frm = new Vistas.frmSucursales();
            frm.ShowDialog();
        }

        private void creditosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vistas.frmCreditos frm = new Vistas.frmCreditos();
            frm.ShowDialog();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vistas.frmUsuarios frm = new Vistas.frmUsuarios();
            frm.ShowDialog();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
             
        }
    }
}
