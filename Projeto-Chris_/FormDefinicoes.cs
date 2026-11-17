using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Projeto_Chris_.Globais;

namespace Projeto_Chris_
{
    public partial class FormDefinicoes : Form
    {
        public FormDefinicoes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            PagPrincipal form_ir = new PagPrincipal();
            form_ir.ShowDialog();
            this.Show();
        }

        private void FormDefinicoes_Load(object sender, EventArgs e)
        {
            label_emailexibir.Text = Globais.emails;
            label_passwordexibir.Text = Globais.passwords;
            label_apelidoexibir.Text = Globais.apelidoss;
        }

        private void button_guardarAlt_Click(object sender, EventArgs e)
        {
            bool alteracoesFeitas = false;
            Globais.Alterações alterações;
            alterações.apelido = textBox_ApelidoAlt.Text;
            alterações.emailAlt = textBox1_emailAlt.Text;
            alterações.palavraPasseAlt = textBox_passwordAlt.Text;
            Globais.listaApelidos[Globais.posicoesvazia] = alterações;
            Globais.posicaovazia++;

            Globais.apelidoss = textBox_ApelidoAlt.Text;
            alteracoesFeitas = true;
        }
    }
}
