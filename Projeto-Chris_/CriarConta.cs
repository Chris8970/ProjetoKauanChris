using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Chris_
{
    public partial class CriarConta : Form
    {
        public CriarConta()
        {
            InitializeComponent();
        }

        private void button_voltar2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormTelaDeContas form_ir = new FormTelaDeContas();
            form_ir.ShowDialog();
            this.Show();
        }

        private void button_criar_Click(object sender, EventArgs e)
        {
            bool ContaCriada = false;
            Globais.Utilizador NovoUt;
            NovoUt.email = textBox_email2.Text;
            NovoUt.palavraPasse = textBox_password2.Text;
            Globais.listaUtilizadores[Globais.posicaovazia] = NovoUt;
            Globais.posicaovazia++;

            try
            {
                if (textBox_email2.Text == "" || textBox_password2.Text == "")
                {
                    throw new ValidacaoCamposVaziosException("ATENÇÃO: É necessário preencher todos os campos!");
                }
                if (!textBox_email2.Text.Contains("@") || !textBox_email2.Text.Contains("."))
                {
                    throw new ValidacaoEmailException("ATENÇÃO: O email deve conter um @ e um .");
                }
            }

            catch (ValidacaoCamposVaziosException ex)
            {
                MessageBox.Show(ex.Message, "Validacão campos vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (ValidacaoEmailException ex)
            {
                MessageBox.Show(ex.Message, "Validacão Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Globais.emails = textBox_email2.Text;
            Globais.passwords = textBox_password2.Text;

            this.Hide();
            FormTelaDeContas form_ir = new FormTelaDeContas();
            form_ir.ShowDialog();
            this.Show();
        }
    }
}
