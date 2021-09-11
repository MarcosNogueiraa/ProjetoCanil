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

            pessoa.IDPessoa = int.Parse(tBIDPessoa.Text);
            pessoa.Nome = tBNomePessoa.Text;
            mTBCPF.Text.Replace("-", "");
            mTBCPF.Text.Replace(".", "");
            pessoa.CPF = int.Parse(mTBCPF.Text != "" ? mTBCPF.Text : "0");
          //  pessoa.IDMae = int.Parse(tBIDMae.Text != "" ? tBIDMae.Text : "0");
            //pessoa.DataNasc = DateTime.Parse(mTBDataNasc.Text);
           // pessoa.Pedigree = tBPedigree.Text;

            if (dAOPessoa.CadastraPessoa(pessoa))
                MessageBox.Show("Pessoa cadastrado com sucesso");
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(mTBCPF.Text.Replace("-||.", ""));//+ " INT: " + int.Parse(mTBCPF.Text));
        }
    }
}
