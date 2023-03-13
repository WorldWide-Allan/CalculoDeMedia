namespace AqueleBaguiDeMediaQueTodaLinguagemTem
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_nome = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_nota1 = new System.Windows.Forms.TextBox();
            this.lbl_nota1 = new System.Windows.Forms.Label();
            this.txt_nota2 = new System.Windows.Forms.TextBox();
            this.lbl_nota2 = new System.Windows.Forms.Label();
            this.txt_nota3 = new System.Windows.Forms.TextBox();
            this.lbl_nota3 = new System.Windows.Forms.Label();
            this.gb_notas = new System.Windows.Forms.GroupBox();
            this.lbl_media = new System.Windows.Forms.Label();
            this.btt_calcular = new System.Windows.Forms.Button();
            this.btt_limpar = new System.Windows.Forms.Button();
            this.gb_notas.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(65, 66);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(120, 20);
            this.lbl_nome.TabIndex = 0;
            this.lbl_nome.Text = "Nome do aluno:";
            this.lbl_nome.Click += new System.EventHandler(this.lbl_nome_Click);
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(192, 63);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(100, 26);
            this.txt_nome.TabIndex = 1;
            this.txt_nome.TextChanged += new System.EventHandler(this.txt_nome_TextChanged);
            // 
            // txt_nota1
            // 
            this.txt_nota1.Location = new System.Drawing.Point(142, 26);
            this.txt_nota1.Name = "txt_nota1";
            this.txt_nota1.Size = new System.Drawing.Size(100, 26);
            this.txt_nota1.TabIndex = 3;
            this.txt_nota1.TextChanged += new System.EventHandler(this.txt_nota1_TextChanged);
            // 
            // lbl_nota1
            // 
            this.lbl_nota1.AutoSize = true;
            this.lbl_nota1.Location = new System.Drawing.Point(15, 33);
            this.lbl_nota1.Name = "lbl_nota1";
            this.lbl_nota1.Size = new System.Drawing.Size(56, 20);
            this.lbl_nota1.TabIndex = 2;
            this.lbl_nota1.Text = "Nota 1";
            // 
            // txt_nota2
            // 
            this.txt_nota2.Location = new System.Drawing.Point(142, 58);
            this.txt_nota2.Name = "txt_nota2";
            this.txt_nota2.Size = new System.Drawing.Size(100, 26);
            this.txt_nota2.TabIndex = 5;
            this.txt_nota2.TextChanged += new System.EventHandler(this.txt_nota2_TextChanged);
            // 
            // lbl_nota2
            // 
            this.lbl_nota2.AutoSize = true;
            this.lbl_nota2.Location = new System.Drawing.Point(15, 65);
            this.lbl_nota2.Name = "lbl_nota2";
            this.lbl_nota2.Size = new System.Drawing.Size(56, 20);
            this.lbl_nota2.TabIndex = 4;
            this.lbl_nota2.Text = "Nota 2";
            // 
            // txt_nota3
            // 
            this.txt_nota3.Location = new System.Drawing.Point(142, 90);
            this.txt_nota3.Name = "txt_nota3";
            this.txt_nota3.Size = new System.Drawing.Size(100, 26);
            this.txt_nota3.TabIndex = 7;
            this.txt_nota3.TextChanged += new System.EventHandler(this.txt_nota3_TextChanged);
            // 
            // lbl_nota3
            // 
            this.lbl_nota3.AutoSize = true;
            this.lbl_nota3.Location = new System.Drawing.Point(15, 97);
            this.lbl_nota3.Name = "lbl_nota3";
            this.lbl_nota3.Size = new System.Drawing.Size(56, 20);
            this.lbl_nota3.TabIndex = 6;
            this.lbl_nota3.Text = "Nota 3";
            // 
            // gb_notas
            // 
            this.gb_notas.Controls.Add(this.lbl_nota1);
            this.gb_notas.Controls.Add(this.txt_nota3);
            this.gb_notas.Controls.Add(this.txt_nota1);
            this.gb_notas.Controls.Add(this.lbl_nota3);
            this.gb_notas.Controls.Add(this.lbl_nota2);
            this.gb_notas.Controls.Add(this.txt_nota2);
            this.gb_notas.Location = new System.Drawing.Point(50, 121);
            this.gb_notas.Name = "gb_notas";
            this.gb_notas.Size = new System.Drawing.Size(250, 130);
            this.gb_notas.TabIndex = 8;
            this.gb_notas.TabStop = false;
            this.gb_notas.Text = "Notas";
            // 
            // lbl_media
            // 
            this.lbl_media.AutoSize = true;
            this.lbl_media.Location = new System.Drawing.Point(65, 355);
            this.lbl_media.Name = "lbl_media";
            this.lbl_media.Size = new System.Drawing.Size(21, 20);
            this.lbl_media.TabIndex = 9;
            this.lbl_media.Text = "   ";
            this.lbl_media.Click += new System.EventHandler(this.lbl_media_Click);
            // 
            // btt_calcular
            // 
            this.btt_calcular.Location = new System.Drawing.Point(94, 274);
            this.btt_calcular.Name = "btt_calcular";
            this.btt_calcular.Size = new System.Drawing.Size(83, 41);
            this.btt_calcular.TabIndex = 10;
            this.btt_calcular.Text = "Calcular";
            this.btt_calcular.UseVisualStyleBackColor = true;
            this.btt_calcular.Click += new System.EventHandler(this.btt_calcular_Click);
            // 
            // btt_limpar
            // 
            this.btt_limpar.Location = new System.Drawing.Point(192, 274);
            this.btt_limpar.Name = "btt_limpar";
            this.btt_limpar.Size = new System.Drawing.Size(83, 41);
            this.btt_limpar.TabIndex = 11;
            this.btt_limpar.Text = "Limpar";
            this.btt_limpar.UseVisualStyleBackColor = true;
            this.btt_limpar.Click += new System.EventHandler(this.btt_limpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 450);
            this.Controls.Add(this.btt_limpar);
            this.Controls.Add(this.btt_calcular);
            this.Controls.Add(this.lbl_media);
            this.Controls.Add(this.gb_notas);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.lbl_nome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gb_notas.ResumeLayout(false);
            this.gb_notas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_nota1;
        private System.Windows.Forms.Label lbl_nota1;
        private System.Windows.Forms.TextBox txt_nota2;
        private System.Windows.Forms.Label lbl_nota2;
        private System.Windows.Forms.TextBox txt_nota3;
        private System.Windows.Forms.Label lbl_nota3;
        private System.Windows.Forms.GroupBox gb_notas;
        private System.Windows.Forms.Label lbl_media;
        private System.Windows.Forms.Button btt_calcular;
        private System.Windows.Forms.Button btt_limpar;
    }
}

