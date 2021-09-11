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
    public partial class CadastroCachorro : Form
    {
        public CadastroCachorro()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //validaCampos();
            DAOCachorro daocachorro = new DAOCachorro();
            Cachorro cachorro = new Cachorro();

            cachorro.IDCachorro = int.Parse(tBIDCachorro.Text);
            cachorro.IDDono = int.Parse(tBIDDono.Text != "" ? tBIDDono.Text : "0" );
            cachorro.Nome = tBNomeCachorro.Text;
            cachorro.IDPai = int.Parse(tBIDPai.Text != "" ? tBIDPai.Text : "0");
            cachorro.IDMae = int.Parse(tBIDMae.Text != "" ? tBIDMae.Text : "0");
            cachorro.DataNasc = DateTime.Parse(mTBDataNasc.Text);
            cachorro.Pedigree = tBPedigree.Text;

            if (daocachorro.CadastraCachorro(cachorro))
                MessageBox.Show("Cachorro cadastrado com sucesso");
        }

        public Boolean ValidaCampos()
        {
            bool ret = true;




            return ret;
        }

        private void tBIDDono_Leave(object sender, EventArgs e)
        {
            DAOPessoa dAOPessoa = new DAOPessoa();
            tBNomeDono.Text = dAOPessoa.GetNomePessoaPorID(int.Parse(tBIDDono.Text != "" ? tBIDDono.Text : "0"));
        }

        private void tBIDPai_Leave(object sender, EventArgs e)
        {
            DAOCachorro dAOCachorro = new DAOCachorro();
            tBNomePai.Text = dAOCachorro.GetNomeCachorroPorID(int.Parse(tBIDPai.Text != "" ? tBIDPai.Text : "0"));
        }

        private void tBIDMae_Leave(object sender, EventArgs e)
        {
            DAOCachorro dAOCachorro = new DAOCachorro();
            tBNomeMae.Text = dAOCachorro.GetNomeCachorroPorID(int.Parse(tBIDMae.Text != "" ? tBIDMae.Text : "0"));
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
    }
}
