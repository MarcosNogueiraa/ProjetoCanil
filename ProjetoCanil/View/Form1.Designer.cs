
namespace ProjetoCanil
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.btCadCachorro = new System.Windows.Forms.Button();
            this.btCadPessoa = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(243, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gerenciamento Canil";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btCadCachorro
            // 
            this.btCadCachorro.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btCadCachorro.Location = new System.Drawing.Point(265, 182);
            this.btCadCachorro.Name = "btCadCachorro";
            this.btCadCachorro.Size = new System.Drawing.Size(149, 74);
            this.btCadCachorro.TabIndex = 1;
            this.btCadCachorro.Text = "Cadastrar Cachorro";
            this.btCadCachorro.UseVisualStyleBackColor = true;
            this.btCadCachorro.Click += new System.EventHandler(this.button1_Click);
            // 
            // btCadPessoa
            // 
            this.btCadPessoa.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btCadPessoa.Location = new System.Drawing.Point(265, 273);
            this.btCadPessoa.Name = "btCadPessoa";
            this.btCadPessoa.Size = new System.Drawing.Size(149, 74);
            this.btCadPessoa.TabIndex = 2;
            this.btCadPessoa.Text = "Cadastrar Pessoa";
            this.btCadPessoa.UseVisualStyleBackColor = true;
            this.btCadPessoa.Click += new System.EventHandler(this.btCadPessoa_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(265, 362);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 74);
            this.button1.TabIndex = 3;
            this.button1.Text = "Cadastrar Venda";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 468);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btCadPessoa);
            this.Controls.Add(this.btCadCachorro);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btCadCachorro;
        private System.Windows.Forms.Button btCadPessoa;
        private System.Windows.Forms.Button button1;
    }
}

