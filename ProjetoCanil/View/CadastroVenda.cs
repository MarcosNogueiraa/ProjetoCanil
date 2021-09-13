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
    public partial class CadastroVenda : Form
    {
        public CadastroVenda()
        {
            InitializeComponent();
            //TODO Pergunta se venda é referente á um cachorro já reservado

        }

        private void tBIDCachorro_Leave(object sender, EventArgs e)
        {
            DAOCachorro dAOCachorro = new DAOCachorro();
            tBNomeCachorro.Text = dAOCachorro.GetNomeCachorroPorID(int.Parse(tBIDCachorro.Text.Trim()));
            //valida se cachorro já está reservado, caso esteja, 
        }

        private void btGetDataAtual_Click(object sender, EventArgs e)
        {
            mTBDataCompra.Text = DateTime.Now.ToString();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void tBIDComprador_Leave(object sender, EventArgs e)
        {
            DAOPessoa dAOPessoa = new DAOPessoa();
            tBNomeComprador.Text = dAOPessoa.GetNomePessoaPorID(int.Parse(tBIDComprador.Text != "" ? tBIDComprador.Text : "0"));
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //validaCampos();
            
            DAOVenda daovenda= new DAOVenda();
            Venda venda = new Venda();

            venda.IDCachorro = int.Parse(tBIDCachorro.Text);
            venda.IDPessoa = int.Parse(tBIDComprador.Text);

            if (!string.IsNullOrEmpty(tBIDReserva.Text))
                venda.IDReserva = int.Parse( tBIDReserva.Text);

            venda.DataCompra = Convert.ToDateTime(mTBDataCompra.Text);
            venda.Valor = int.Parse(tBIDCachorro.Text);

            if (daovenda.CadastraVenda(venda))
                MessageBox.Show("Venda realizada com sucesso");
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (tBIDReserva.Text != "")
            {
                DAOReserva dAOReserva = new DAOReserva();
                if (dAOReserva.GetReservaPorID(int.Parse(tBIDReserva.Text)) != null)
                {
                    Reserva reserva = dAOReserva.GetReservaPorID(int.Parse(tBIDReserva.Text));
                    tBIDCachorro.Text = reserva.IDCachorro.ToString();
                    tBNomeCachorro.Text = getNomeCachorro(reserva.IDCachorro);
                    tBIDComprador.Text = reserva.IDComprador.ToString();
                    tBNomeComprador.Text = getNomeDono(reserva.IDComprador);

                    tBValorPago.Text = reserva.ValorAdiantamento.ToString();

                    double ValorTotal = double.Parse(tBValorPago.Text) + double.Parse(tBValorCompra.Text != "" ? tBValorCompra.Text : "0");
                    tBValorTotal.Text = ValorTotal.ToString();
                }
            }
        }

        public string getNomeCachorro(int idCachorro)
        {
            DAOCachorro dAOCachorro = new DAOCachorro();

            return dAOCachorro.GetNomeCachorroPorID(idCachorro);
        }

        public string getNomeDono(int idDono)
        {
            DAOPessoa dAOPessoa= new DAOPessoa();

            return dAOPessoa.GetNomePessoaPorID(idDono);
        }

        private void tBValorCompra_Leave(object sender, EventArgs e)
        {
            double ValorTotal = double.Parse(tBValorPago.Text != "" ? tBValorCompra.Text : "0") + double.Parse(tBValorCompra.Text != "" ? tBValorCompra.Text : "0");
            tBValorTotal.Text = ValorTotal.ToString();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(mTBDataCompra.Text.Replace("/", ""));
        }
    }
}
