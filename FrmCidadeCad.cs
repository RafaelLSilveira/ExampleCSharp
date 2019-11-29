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
    public partial class FrmCidadeCad : Form
    {
        Cidade city = new Cidade();
        public FrmCidadeCad()
        {
            InitializeComponent();
        }
        public FrmCidadeCad(int codigo)
        {
            InitializeComponent();
            city.Carregar(codigo);
            PopularComponentes();
        }

        private void PopularComponentes()
        {
            tbCodigo.Text = city.CODIGO.ToString();
            tbNome.Text = city.NOME.ToString();
            tbEstado.Text = city.ESTADO.ToString();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {

            city.NOME = tbNome.Text;
            city.ESTADO = tbEstado.Text;
            
            //INSERT
            int resultado;
            if (city.CODIGO > 0)
            {
                resultado = city.Alterar();
            }
            else
            {
                resultado = city.Inserir();
                tbCodigo.Text = city.CODIGO.ToString();
            }

            if (resultado > 0)
            {
                MessageBox.Show("Dados gravados com sucesso!");
            }
            else
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
