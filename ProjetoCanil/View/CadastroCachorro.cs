using ProjetoCanil.Controller;
using ProjetoCanil.DAO;
using ProjetoCanil.Logs;
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
            AtualizaGrid();
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
            if (tBIDCachorro.Text == "")
            {


                //validaCampos();
                //DAOCachorro daocachorro = new DAOCachorro();
                CachorroController cachorroController = new CachorroController();
                Cachorro cachorro = new Cachorro();

                cachorro.IDDono = int.Parse(tBIDDono.Text != "" ? tBIDDono.Text : "0");
                cachorro.Nome = tBNomeCachorro.Text;
                cachorro.IDPai = int.Parse(tBIDPai.Text != "" ? tBIDPai.Text : "0");
                cachorro.IDMae = int.Parse(tBIDMae.Text != "" ? tBIDMae.Text : "0");
                cachorro.DataNasc = DateTime.Parse(mTBDataNasc.Text.Replace("/", "").Trim() != "" ? mTBDataNasc.Text : "01/01/2001");
                cachorro.Pedigree = tBPedigree.Text;

                cachorroController.CadastraCachorro(cachorro);
                AtualizaGrid();

            }
            else
            {
                CachorroController cachorroController = new CachorroController();
                Cachorro cachorro = new Cachorro();

                cachorro.IDCachorro = int.Parse(tBIDCachorro.Text);
                cachorro.IDDono = int.Parse(tBIDDono.Text != "" ? tBIDDono.Text : "0");
                cachorro.Nome = tBNomeCachorro.Text;
                cachorro.IDPai = int.Parse(tBIDPai.Text != "" ? tBIDPai.Text : "0");
                cachorro.IDMae = int.Parse(tBIDMae.Text != "" ? tBIDMae.Text : "0");
                cachorro.DataNasc = DateTime.Parse(mTBDataNasc.Text.Replace("/", "").Trim() != "" ? mTBDataNasc.Text : "01/01/2001");
                cachorro.Pedigree = tBPedigree.Text;

                cachorroController.AtualizaCachorro(cachorro);
                AtualizaGrid();

            }

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

        private void tBIDDono_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            LiberaCamposEdicao();
            AtualizaGrid();
        }

        private void DGCachorros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGCachorros.CurrentRow.Cells[0].Value != null)
            {
                CachorroController cachorroController = new CachorroController();
                Cachorro cachorro = cachorroController.GetCachorroPorID(int.Parse(DGCachorros.CurrentRow.Cells[0].Value.ToString()));

                TravaCampos();
                preencheCampos(cachorro);
            }
            else
                LimpaCampos();
        }

        private void TravaCampos()
        {
            tBNomeCachorro.ReadOnly = true;
            mTBDataNasc.ReadOnly = true;
            tBPedigree.ReadOnly = true;
            tBIDDono.ReadOnly = true;
            tBIDPai.ReadOnly = true;
            tBIDMae.ReadOnly = true;
        }

        private void LiberaCamposEdicao()
        {
            tBNomeCachorro.ReadOnly = false;
            mTBDataNasc.ReadOnly = false;
            tBPedigree.ReadOnly = false;
            tBIDDono.ReadOnly = false;
            tBIDPai.ReadOnly = false;
            tBIDMae.ReadOnly = false;

        }

        private void LimpaCampos()
        {
            tBIDCachorro.Text = "";
            tBNomeCachorro.Text = "";
            mTBDataNasc.Text = "";
            tBPedigree.Text = "";
            tBIDDono.Text = "";
            tBNomeDono.Text = "";
            tBIDMae.Text = "";
            tBNomeMae.Text = "";
            tBIDPai.Text = "";
            tBNomePai.Text = "";
        }

        private void preencheCampos(Cachorro cachorro)
        {
            CachorroController cachorroController = new CachorroController();
            PessoaController pessoaController= new PessoaController();
            tBIDCachorro.Text = cachorro.IDCachorro.ToString();
            tBNomeCachorro.Text = cachorro.Nome;
            mTBDataNasc.Text = cachorro.DataNasc.ToString();
            tBIDDono.Text = cachorro.IDDono.ToString();
            tBIDPai.Text = cachorro.IDPai.ToString();
            tBIDMae.Text = cachorro.IDMae.ToString();
            tBPedigree.Text = cachorro.Pedigree;
            tBNomeMae.Text = cachorroController.GetNomeCachorroPorID(int.Parse(tBIDMae.Text != "" ? tBIDMae.Text : "0"));
            tBNomePai.Text = cachorroController.GetNomeCachorroPorID(int.Parse(tBIDPai.Text != "" ? tBIDPai.Text : "0"));
            tBNomeDono.Text = pessoaController.GetNomePessoaPorID(int.Parse(tBIDDono.Text != "" ? tBIDDono.Text : "0"));

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            CachorroController cachorroController = new CachorroController();
            cachorroController.ExcluiCachorroPorID(int.Parse(tBIDCachorro.Text));
            AtualizaGrid();
        }

        private void AtualizaGrid()
        {
            DGCachorros.Rows.Clear();
            CachorroController cachorroController = new CachorroController();
            List<Cachorro> ListaCachorro = cachorroController.GetCachorros();

            foreach (Cachorro cachorro in ListaCachorro)
            {
                DGCachorros.Rows.Add(cachorro.IDCachorro,
                                     cachorro.Nome);
            }
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            LimpaCampos();
            LiberaCamposEdicao();
        }
    }
}
