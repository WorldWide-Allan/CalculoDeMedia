using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AqueleBaguiDeMediaQueTodaLinguagemTem
{
    public partial class Form1 : Form
    {
        Single nota1, nota2, nota3, calcular;
        String nome;
        public Form1()
        {
            InitializeComponent();
        }

        private void lbl_nome_Click(object sender, EventArgs e)
        {

        }

        private void txt_nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_nota1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_nota2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_nota3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btt_calcular_Click(object sender, EventArgs e)
        {
            nome = (txt_nome.Text);
            nota1 = Convert.ToSingle(txt_nota1.Text);
            nota2 = Convert.ToSingle(txt_nota2.Text);
            nota3 = Convert.ToSingle(txt_nota3.Text);
            calcular = (nota1 + nota2 + nota3) / 3;
            lbl_media.Text = string.Format("A média do aluno {0} foi de: {1}", nome, calcular); 
        }

        private void btt_limpar_Click(object sender, EventArgs e)
        {
            txt_nome.Text = "";
            txt_nota1.Text = "";
            txt_nota2.Text = "";
            txt_nota3.Text = "";
            lbl_media.Text = "";
        }

        private void lbl_media_Click(object sender, EventArgs e)
        {

        }
    }
}
