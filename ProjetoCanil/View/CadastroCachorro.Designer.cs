
namespace ProjetoCanil.View
{
    partial class CadastroCachorro
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tBIDCachorro = new System.Windows.Forms.TextBox();
            this.tBNomeCachorro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tBPedigree = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mTBDataNasc = new System.Windows.Forms.MaskedTextBox();
            this.tBNomePai = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tBIDPai = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tBNomeMae = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tBIDMae = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.tBNomeDono = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tBIDDono = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(179, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro Cachorro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // tBIDCachorro
            // 
            this.tBIDCachorro.Location = new System.Drawing.Point(33, 71);
            this.tBIDCachorro.Name = "tBIDCachorro";
            this.tBIDCachorro.ReadOnly = true;
            this.tBIDCachorro.Size = new System.Drawing.Size(52, 23);
            this.tBIDCachorro.TabIndex = 2;
            // 
            // tBNomeCachorro
            // 
            this.tBNomeCachorro.Location = new System.Drawing.Point(114, 71);
            this.tBNomeCachorro.Name = "tBNomeCachorro";
            this.tBNomeCachorro.Size = new System.Drawing.Size(151, 23);
            this.tBNomeCachorro.TabIndex = 4;
            this.tBNomeCachorro.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nome";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(294, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Data de Nascimento";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tBPedigree
            // 
            this.tBPedigree.Location = new System.Drawing.Point(431, 71);
            this.tBPedigree.Name = "tBPedigree";
            this.tBPedigree.Size = new System.Drawing.Size(114, 23);
            this.tBPedigree.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(431, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Pedigree";
            // 
            // mTBDataNasc
            // 
            this.mTBDataNasc.Location = new System.Drawing.Point(294, 71);
            this.mTBDataNasc.Mask = "00/00/0000";
            this.mTBDataNasc.Name = "mTBDataNasc";
            this.mTBDataNasc.Size = new System.Drawing.Size(100, 23);
            this.mTBDataNasc.TabIndex = 9;
            this.mTBDataNasc.ValidatingType = typeof(System.DateTime);
            // 
            // tBNomePai
            // 
            this.tBNomePai.Location = new System.Drawing.Point(114, 192);
            this.tBNomePai.Name = "tBNomePai";
            this.tBNomePai.ReadOnly = true;
            this.tBNomePai.Size = new System.Drawing.Size(151, 23);
            this.tBNomePai.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(114, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Nome Pai";
            // 
            // tBIDPai
            // 
            this.tBIDPai.Location = new System.Drawing.Point(33, 192);
            this.tBIDPai.Name = "tBIDPai";
            this.tBIDPai.Size = new System.Drawing.Size(52, 23);
            this.tBIDPai.TabIndex = 11;
            this.tBIDPai.Leave += new System.EventHandler(this.tBIDPai_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "ID Pai";
            // 
            // tBNomeMae
            // 
            this.tBNomeMae.Location = new System.Drawing.Point(114, 256);
            this.tBNomeMae.Name = "tBNomeMae";
            this.tBNomeMae.ReadOnly = true;
            this.tBNomeMae.Size = new System.Drawing.Size(151, 23);
            this.tBNomeMae.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(114, 238);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "Nome Mãe";
            // 
            // tBIDMae
            // 
            this.tBIDMae.Location = new System.Drawing.Point(33, 256);
            this.tBIDMae.Name = "tBIDMae";
            this.tBIDMae.Size = new System.Drawing.Size(52, 23);
            this.tBIDMae.TabIndex = 15;
            this.tBIDMae.Leave += new System.EventHandler(this.tBIDMae_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 238);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 15);
            this.label9.TabIndex = 14;
            this.label9.Text = "ID Mãe";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSalvar.Location = new System.Drawing.Point(397, 345);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(119, 40);
            this.btnSalvar.TabIndex = 18;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditar.Location = new System.Drawing.Point(225, 345);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(119, 40);
            this.btnEditar.TabIndex = 19;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Red;
            this.btnExcluir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExcluir.Location = new System.Drawing.Point(53, 345);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(119, 40);
            this.btnExcluir.TabIndex = 20;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = false;
            // 
            // tBNomeDono
            // 
            this.tBNomeDono.Location = new System.Drawing.Point(114, 126);
            this.tBNomeDono.Name = "tBNomeDono";
            this.tBNomeDono.ReadOnly = true;
            this.tBNomeDono.Size = new System.Drawing.Size(151, 23);
            this.tBNomeDono.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(114, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 15);
            this.label10.TabIndex = 23;
            this.label10.Text = "Nome Dono";
            // 
            // tBIDDono
            // 
            this.tBIDDono.Location = new System.Drawing.Point(33, 126);
            this.tBIDDono.Name = "tBIDDono";
            this.tBIDDono.Size = new System.Drawing.Size(52, 23);
            this.tBIDDono.TabIndex = 22;
            this.tBIDDono.TextChanged += new System.EventHandler(this.tBIDDono_TextChanged);
            this.tBIDDono.Leave += new System.EventHandler(this.tBIDDono_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(33, 108);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 15);
            this.label11.TabIndex = 21;
            this.label11.Text = "ID Dono";
            // 
            // CadastroCachorro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 445);
            this.Controls.Add(this.tBNomeDono);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tBIDDono);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.tBNomeMae);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tBIDMae);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tBNomePai);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tBIDPai);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.mTBDataNasc);
            this.Controls.Add(this.tBPedigree);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tBNomeCachorro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tBIDCachorro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CadastroCachorro";
            this.Text = "CadastroCachorro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBIDCachorro;
        private System.Windows.Forms.TextBox tBNomeCachorro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tBPedigree;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mTBDataNasc;
        private System.Windows.Forms.TextBox tBNomePai;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tBIDPai;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tBNomeMae;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tBIDMae;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.TextBox tBNomeDono;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tBIDDono;
        private System.Windows.Forms.Label label11;
    }
}