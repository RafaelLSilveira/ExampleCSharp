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
    public partial class FrmCidade : Form
    {
        private Boolean test = false; 
        public FrmCidade()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Cidade city = new Cidade();
            //DataTable dt = city.Pesquisar(tbCidade.Text);
            //dgvCidade.DataSource = dt;
            dgvCidade.DataSource = city.Pesquisar(tbCidade.Text);
            //test = true;
            //btnAlterar.Enabled = dt.Rows.Count > 0;
            btnAlterar.Enabled = (dgvCidade.DataSource as DataTable).Rows.Count > 0;
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            FrmCidadeCad city = new FrmCidadeCad();
            city.ShowDialog();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (test == true)
            {
                int codigo = int.Parse(dgvCidade.CurrentRow.Cells[0].Value.ToString());
                FrmCidadeCad cadastro = new FrmCidadeCad(codigo);
                cadastro.ShowDialog();
            }
        }
    }
}
