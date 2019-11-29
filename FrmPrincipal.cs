using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO.NET
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FrnCliente clientes = new FrnCliente();
            clientes.ShowDialog();
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            FrmCidade city = new FrmCidade();
            city.ShowDialog();
        }
    }
}
