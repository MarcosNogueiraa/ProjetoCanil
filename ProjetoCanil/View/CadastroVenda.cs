using ProjetoCanil.Controller;
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
            AtualizaGrid();
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
            //DAOVenda daovenda= new DAOVenda();
            VendaController vendaController = new VendaController();
            Venda venda = new Venda();

            venda.IDCachorro = int.Parse(tBIDCachorro.Text);
            venda.IDPessoa = int.Parse(tBIDComprador.Text);

            if (!string.IsNullOrEmpty(tBIDReserva.Text))
                venda.IDReserva = int.Parse( tBIDReserva.Text);

            venda.DataCompra = Convert.ToDateTime(mTBDataCompra.Text);
            venda.Valor = int.Parse(tBIDCachorro.Text);

            vendaController.CadastraVenda(venda);
            AtualizaGrid();

           
            
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
            LiberaCamposEdicao();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void AtualizaGrid()
        {
            DGReservas.Rows.Clear();
            ReservaController reservaController= new ReservaController();
            PessoaController pessoaController = new PessoaController();
            CachorroController cachorroController = new CachorroController();

            List<Reserva> ListaReserva = reservaController.GetReservas();

            foreach (Reserva reserva in ListaReserva)
            {
                DGReservas.Rows.Add(reserva.IDReserva, 
                                    pessoaController.GetNomePessoaPorID(reserva.IDComprador),
                                    cachorroController.GetNomeCachorroPorID(reserva.IDCachorro));
            }
        }

        private void PreencheCamposPorReservaSelecionada(Reserva reserva)
        {           
           
            tBIDReserva.Text = reserva.IDReserva.ToString();
            tBIDCachorro.Text = reserva.IDCachorro.ToString();
            tBNomeCachorro.Text = getNomeCachorro(reserva.IDCachorro);
            tBIDComprador.Text = reserva.IDComprador.ToString();
            tBNomeComprador.Text = getNomeDono(reserva.IDComprador);
            tBValorPago.Text = reserva.ValorAdiantamento.ToString();
            double ValorTotal = double.Parse(tBValorPago.Text) + double.Parse(tBValorCompra.Text != "" ? tBValorCompra.Text : "0");
            tBValorTotal.Text = ValorTotal.ToString();
                  
        }

        private void LimpaCampos()
        {
            tBIDVenda.Text = "";
            tBIDReserva.Text = "";
            tBIDCachorro.Text = "";
            tBNomeCachorro.Text = "";
            tBIDComprador.Text = "";
            tBNomeComprador.Text = "";
            mTBDataCompra.Text = "";
            tBValorPago.Text = "";
            tBValorCompra.Text = "";
            tBValorTotal.Text = "";
        }

        private void LiberaCamposEdicao()
        {
            tBIDReserva.ReadOnly = false;;
            tBIDCachorro.ReadOnly = false;;
            tBIDComprador.ReadOnly = false;;
            mTBDataCompra.ReadOnly = false;
            tBValorCompra.ReadOnly = false;;
            tBValorTotal.ReadOnly = false;;
        }

        private void TravaCampos()
        {
            tBIDReserva.ReadOnly = true; ;
            tBIDCachorro.ReadOnly = true; ;
            tBIDComprador.ReadOnly = true; ;
            mTBDataCompra.ReadOnly = true;
            tBValorCompra.ReadOnly = true; ;
            tBValorTotal.ReadOnly = true; ;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimpaCampos();
            LiberaCamposEdicao();
        }

        private void DGReservas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGReservas.CurrentRow.Cells[0].Value != null)
            {
                ReservaController reservaController = new ReservaController();
                Reserva reserva = reservaController.GetReservaPorID(int.Parse(DGReservas.CurrentRow.Cells[0].Value.ToString()));

                TravaCampos();
                PreencheCamposPorReservaSelecionada(reserva);
            }
            else
                LimpaCampos();
        }
    }
}
