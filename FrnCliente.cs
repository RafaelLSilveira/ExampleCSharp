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
    public partial class FrnCliente : Form
    {
        private Boolean test = false;
        public FrnCliente()
        {
            InitializeComponent();
           
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente();
            dgvClientes.DataSource = c.Pesquisar(tbNome.Text, tbTelefone.Text);
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            FrmClienteCad cadastro = new FrmClienteCad();
            cadastro.ShowDialog();
         }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (test == true)
            {
                int codigo = int.Parse(dgvClientes.CurrentRow.Cells[0].Value.ToString());
                FrmClienteCad cadastro = new FrmClienteCad(codigo);
                cadastro.ShowDialog();
            }
        }
    }
}
