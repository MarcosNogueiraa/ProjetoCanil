using ProjetoCanil.DAO;
using ProjetoCanil.Model.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoCanil.View
{
    public partial class CadastroPessoa : Form
    {
        public CadastroPessoa()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //validaCampos();
            DAOPessoa dAOPessoa = new DAOPessoa();
            Pessoa pessoa = new Pessoa();

            pessoa.Nome = tBNomePessoa.Text.Trim();
            pessoa.CPF = int.Parse(tBCPF.Text.Trim() != "" ? tBCPF.Text.Trim() : "0");
            pessoa.RG = int.Parse(tBRG.Text.Trim() != "" ? tBRG.Text.Trim() : "0");
            pessoa.Celular = int.Parse(tBCelular.Text.Trim() != "" ? tBCelular.Text.Trim() : "0");
            pessoa.CEP = int.Parse(tBCEP.Text.Trim() != "" ? tBCEP.Text.Trim() : "0");
            pessoa.Bairro = tBBairro.Text.Trim();
            pessoa.Rua = tBRua.Text.Trim();
            pessoa.NumeroCasa = int.Parse(tBNumCasa.Text.Trim() != "" ? tBNumCasa.Text.Trim() : "0"); ;

            if (dAOPessoa.CadastraPessoa(pessoa))
                MessageBox.Show("Pessoa cadastrada com sucesso");
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(tBCPF.Text + " " + tBRG.Text + " " + tBCEP.Text);//+ " INT: " + int.Parse(mTBCPF.Text));
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tBIDPessoa_TextChanged(object sender, EventArgs e)
        {

        }

        private void tBNomePessoa_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tBCPF_TextChanged(object sender, EventArgs e)
        {

        }

        private void tBRG_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
