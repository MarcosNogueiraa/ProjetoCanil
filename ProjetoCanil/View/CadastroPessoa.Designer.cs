
namespace ProjetoCanil.View
{
    partial class CadastroPessoa
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
            this.mTBCPF = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tBNomePessoa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tBIDPessoa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.mTBRG = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mTBCEP = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tBRua = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tBNumCasa = new System.Windows.Forms.TextBox();
            this.tBBairro = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mTBCPF
            // 
            this.mTBCPF.Location = new System.Drawing.Point(307, 81);
            this.mTBCPF.Mask = "000,000,000-00";
            this.mTBCPF.Name = "mTBCPF";
            this.mTBCPF.Size = new System.Drawing.Size(100, 23);
            this.mTBCPF.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(307, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "CPF";
            // 
            // tBNomePessoa
            // 
            this.tBNomePessoa.Location = new System.Drawing.Point(127, 81);
            this.tBNomePessoa.Name = "tBNomePessoa";
            this.tBNomePessoa.Size = new System.Drawing.Size(151, 23);
            this.tBNomePessoa.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nome";
            // 
            // tBIDPessoa
            // 
            this.tBIDPessoa.Location = new System.Drawing.Point(46, 81);
            this.tBIDPessoa.Name = "tBIDPessoa";
            this.tBIDPessoa.Size = new System.Drawing.Size(52, 23);
            this.tBIDPessoa.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "ID";
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTitulo.Location = new System.Drawing.Point(190, 11);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(193, 30);
            this.lbTitulo.TabIndex = 16;
            this.lbTitulo.Text = "Cadastro de Pessoa";
            // 
            // mTBRG
            // 
            this.mTBRG.Location = new System.Drawing.Point(437, 81);
            this.mTBRG.Mask = "00,000,000-0";
            this.mTBRG.Name = "mTBRG";
            this.mTBRG.Size = new System.Drawing.Size(100, 23);
            this.mTBRG.TabIndex = 18;
            this.mTBRG.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(437, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "RG";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // mTBCEP
            // 
            this.mTBCEP.Location = new System.Drawing.Point(46, 152);
            this.mTBCEP.Mask = "00000-999";
            this.mTBCEP.Name = "mTBCEP";
            this.mTBCEP.Size = new System.Drawing.Size(100, 23);
            this.mTBCEP.TabIndex = 20;
            this.mTBCEP.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox2_MaskInputRejected);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "CEP";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // tBRua
            // 
            this.tBRua.Location = new System.Drawing.Point(45, 213);
            this.tBRua.Name = "tBRua";
            this.tBRua.Size = new System.Drawing.Size(197, 23);
            this.tBRua.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 15);
            this.label6.TabIndex = 21;
            this.label6.Text = "Rua";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(295, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 15);
            this.label7.TabIndex = 23;
            this.label7.Text = "Nº";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // tBNumCasa
            // 
            this.tBNumCasa.Location = new System.Drawing.Point(295, 213);
            this.tBNumCasa.Name = "tBNumCasa";
            this.tBNumCasa.Size = new System.Drawing.Size(53, 23);
            this.tBNumCasa.TabIndex = 24;
            this.tBNumCasa.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tBBairro
            // 
            this.tBBairro.Location = new System.Drawing.Point(190, 152);
            this.tBBairro.Name = "tBBairro";
            this.tBBairro.Size = new System.Drawing.Size(217, 23);
            this.tBBairro.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(190, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 15);
            this.label8.TabIndex = 25;
            this.label8.Text = "Bairro";
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Red;
            this.btnExcluir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExcluir.Location = new System.Drawing.Point(55, 346);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(119, 40);
            this.btnExcluir.TabIndex = 29;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditar.Location = new System.Drawing.Point(227, 346);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(119, 40);
            this.btnEditar.TabIndex = 28;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSalvar.Location = new System.Drawing.Point(399, 346);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(119, 40);
            this.btnSalvar.TabIndex = 27;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // CadastroPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 450);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.tBBairro);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tBNumCasa);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tBRua);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mTBCEP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mTBRG);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.mTBCPF);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tBNomePessoa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tBIDPessoa);
            this.Controls.Add(this.label2);
            this.Name = "CadastroPessoa";
            this.Text = "CadastroPessoa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mTBCPF;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tBNomePessoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBIDPessoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.MaskedTextBox mTBRG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mTBCEP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tBRua;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tBNumCasa;
        private System.Windows.Forms.TextBox tBBairro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnSalvar;
    }
}