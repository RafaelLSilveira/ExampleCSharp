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
    public partial class FrmClienteCad : Form
    {
        Cliente cliente = new Cliente();
        public FrmClienteCad()
        {
            InitializeComponent();
        }
        public FrmClienteCad(int codigo)
        {
            InitializeComponent();
            cliente.Carregar(codigo);
            PopularComponentes();
        }
        private void PopularComponentes()
        {
            tbCodigo.Text = cliente.CODIGO.ToString();
            tbNome.Text = cliente.NOME.ToString();
            mtbTelefone.Text = cliente.TELEFONE.ToString();
            dtpData.Text = cliente.DATA_NASCIMENTO.ToString();

            cbCidades.DataSource = new Cidade().ListarTodas();
            cbCidades.DisplayMember = "NOME";
            //cbCidades.
        }
        private void btnGravar_Click(object sender, EventArgs e)
        {
            
            cliente.NOME = tbNome.Text;
            cliente.TELEFONE = mtbTelefone.Text;
            cliente.DATA_NASCIMENTO = dtpData.Value.Date;
            //INSERT
            if (dtpData.Checked) {
                cliente.DATA_NASCIMENTO = dtpData.Value.Date;
            }else
            {
                cliente.DATA_NASCIMENTO = null;
            }

            int resultado;
            if (cliente.CODIGO > 0)
            {
                resultado = cliente.Alterar();
            }else
            {
                resultado = cliente.Inserir();
                tbCodigo.Text = cliente.CODIGO.ToString();
            }

            if(resultado > 0)
            {
                MessageBox.Show("Dados gravados com sucesso!");
            }else
            {
                MessageBox.Show("Falha ao inserir os dados!!");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }
    }
}
