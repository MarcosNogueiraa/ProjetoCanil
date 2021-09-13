using ProjetoCanil.DAO;
using ProjetoCanil.Model.Entidades;
using ProjetoCanil.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCanil
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadastroCachorro cadastroCachorro = new CadastroCachorro();
            DAOCachorro dAOCachorro = new DAOCachorro();
            cadastroCachorro.ShowDialog();
            
        }

        private void btCadPessoa_Click(object sender, EventArgs e)
        {
            CadastroPessoa cadastroPessoa = new CadastroPessoa();
            cadastroPessoa.ShowDialog();
            //cadastroPessoa.Activate();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            CadastroVenda cadastroVenda = new CadastroVenda();
            cadastroVenda.ShowDialog();
        }
    }
}
