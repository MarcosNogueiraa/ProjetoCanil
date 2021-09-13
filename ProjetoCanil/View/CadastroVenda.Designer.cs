
namespace ProjetoCanil.View
{
    partial class CadastroVenda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tBNomeComprador = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tBIDComprador = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tBIDCachorro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tBIDVenda = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tBNomeCachorro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tBIDReserva = new System.Windows.Forms.TextBox();
            this.btGetDataAtual = new System.Windows.Forms.Button();
            this.mTBDataCompra = new System.Windows.Forms.MaskedTextBox();
            this.tBValorCompra = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tBValorPago = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tBValorTotal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Red;
            this.btnExcluir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExcluir.Location = new System.Drawing.Point(62, 308);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(119, 40);
            this.btnExcluir.TabIndex = 23;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditar.Location = new System.Drawing.Point(234, 308);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(119, 40);
            this.btnEditar.TabIndex = 22;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSalvar.Location = new System.Drawing.Point(406, 308);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(119, 40);
            this.btnSalvar.TabIndex = 21;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(283, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 32);
            this.label1.TabIndex = 24;
            this.label1.Text = "Venda";
            // 
            // tBNomeComprador
            // 
            this.tBNomeComprador.Location = new System.Drawing.Point(154, 135);
            this.tBNomeComprador.Name = "tBNomeComprador";
            this.tBNomeComprador.ReadOnly = true;
            this.tBNomeComprador.Size = new System.Drawing.Size(161, 23);
            this.tBNomeComprador.TabIndex = 32;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(154, 117);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 15);
            this.label10.TabIndex = 31;
            this.label10.Text = "Nome Comprador";
            // 
            // tBIDComprador
            // 
            this.tBIDComprador.Location = new System.Drawing.Point(41, 135);
            this.tBIDComprador.Name = "tBIDComprador";
            this.tBIDComprador.Size = new System.Drawing.Size(82, 23);
            this.tBIDComprador.TabIndex = 30;
            this.tBIDComprador.Leave += new System.EventHandler(this.tBIDComprador_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(41, 117);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 15);
            this.label11.TabIndex = 29;
            this.label11.Text = "ID Comprador";
            // 
            // tBIDCachorro
            // 
            this.tBIDCachorro.Location = new System.Drawing.Point(245, 80);
            this.tBIDCachorro.Name = "tBIDCachorro";
            this.tBIDCachorro.Size = new System.Drawing.Size(98, 23);
            this.tBIDCachorro.TabIndex = 28;
            this.tBIDCachorro.Leave += new System.EventHandler(this.tBIDCachorro_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(367, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 15);
            this.label3.TabIndex = 27;
            this.label3.Text = "Nome Cachorro";
            // 
            // tBIDVenda
            // 
            this.tBIDVenda.Location = new System.Drawing.Point(41, 80);
            this.tBIDVenda.Name = "tBIDVenda";
            this.tBIDVenda.ReadOnly = true;
            this.tBIDVenda.Size = new System.Drawing.Size(52, 23);
            this.tBIDVenda.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 25;
            this.label2.Text = "ID Venda";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(245, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 15);
            this.label4.TabIndex = 33;
            this.label4.Text = "ID Cachorro";
            // 
            // tBNomeCachorro
            // 
            this.tBNomeCachorro.Location = new System.Drawing.Point(367, 80);
            this.tBNomeCachorro.Name = "tBNomeCachorro";
            this.tBNomeCachorro.ReadOnly = true;
            this.tBNomeCachorro.Size = new System.Drawing.Size(161, 23);
            this.tBNomeCachorro.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 15);
            this.label5.TabIndex = 35;
            this.label5.Text = "Data Compra";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(115, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 15);
            this.label6.TabIndex = 37;
            this.label6.Text = "ID Reserva";
            // 
            // tBIDReserva
            // 
            this.tBIDReserva.Location = new System.Drawing.Point(116, 80);
            this.tBIDReserva.Name = "tBIDReserva";
            this.tBIDReserva.Size = new System.Drawing.Size(106, 23);
            this.tBIDReserva.TabIndex = 38;
            this.tBIDReserva.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.tBIDReserva.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // btGetDataAtual
            // 
            this.btGetDataAtual.Location = new System.Drawing.Point(147, 193);
            this.btGetDataAtual.Name = "btGetDataAtual";
            this.btGetDataAtual.Size = new System.Drawing.Size(75, 23);
            this.btGetDataAtual.TabIndex = 39;
            this.btGetDataAtual.Text = "Dt. Atual";
            this.btGetDataAtual.UseVisualStyleBackColor = true;
            this.btGetDataAtual.Click += new System.EventHandler(this.btGetDataAtual_Click);
            // 
            // mTBDataCompra
            // 
            this.mTBDataCompra.Location = new System.Drawing.Point(41, 194);
            this.mTBDataCompra.Mask = "00/00/0000";
            this.mTBDataCompra.Name = "mTBDataCompra";
            this.mTBDataCompra.Size = new System.Drawing.Size(77, 23);
            this.mTBDataCompra.TabIndex = 40;
            this.mTBDataCompra.ValidatingType = typeof(System.DateTime);
            // 
            // tBValorCompra
            // 
            this.tBValorCompra.Location = new System.Drawing.Point(446, 194);
            this.tBValorCompra.Name = "tBValorCompra";
            this.tBValorCompra.Size = new System.Drawing.Size(82, 23);
            this.tBValorCompra.TabIndex = 41;
            this.tBValorCompra.Leave += new System.EventHandler(this.tBValorCompra_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(446, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 15);
            this.label7.TabIndex = 42;
            this.label7.Text = "Valor Compra";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(411, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 21);
            this.label8.TabIndex = 43;
            this.label8.Text = "R$";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(266, 194);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 21);
            this.label9.TabIndex = 46;
            this.label9.Text = "R$";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(301, 176);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 15);
            this.label12.TabIndex = 45;
            this.label12.Text = "Valor Pago";
            // 
            // tBValorPago
            // 
            this.tBValorPago.Location = new System.Drawing.Point(301, 194);
            this.tBValorPago.Name = "tBValorPago";
            this.tBValorPago.ReadOnly = true;
            this.tBValorPago.Size = new System.Drawing.Size(82, 23);
            this.tBValorPago.TabIndex = 44;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(342, 247);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 21);
            this.label13.TabIndex = 49;
            this.label13.Text = "R$";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(377, 228);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 15);
            this.label14.TabIndex = 48;
            this.label14.Text = "Valor Total";
            // 
            // tBValorTotal
            // 
            this.tBValorTotal.Location = new System.Drawing.Point(377, 247);
            this.tBValorTotal.Name = "tBValorTotal";
            this.tBValorTotal.Size = new System.Drawing.Size(82, 23);
            this.tBValorTotal.TabIndex = 47;
            // 
            // CadastroVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 450);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tBValorTotal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tBValorPago);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tBValorCompra);
            this.Controls.Add(this.mTBDataCompra);
            this.Controls.Add(this.btGetDataAtual);
            this.Controls.Add(this.tBIDReserva);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tBNomeCachorro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tBNomeComprador);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tBIDComprador);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tBIDCachorro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tBIDVenda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnSalvar);
            this.Name = "CadastroVenda";
            this.Text = "CadastroVenda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBNomeComprador;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tBIDComprador;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tBIDCachorro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBIDVenda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tBNomeCachorro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tBIDReserva;
        private System.Windows.Forms.Button btGetDataAtual;
        private System.Windows.Forms.MaskedTextBox mTBDataCompra;
        private System.Windows.Forms.TextBox tBValorCompra;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tBValorPago;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tBValorTotal;
    }
}