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
    public partial class FormContaIniciar : Form
    {
        public FormContaIniciar()
        {
            InitializeComponent();
        }

        private void button_entrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_email.Text == "" || textBox_password.Text == "")
                {
                    throw new ValidacaoCamposVaziosException("ATENÇÃO: É necessário preencher todos os campos!");
                }
                if (!textBox_email.Text.Contains("@") || !textBox_email.Text.Contains("."))
                {
                    throw new ValidacaoEmailException("ATENÇÃO: O email deve conter um @ e um .");
                }
            }
            catch (ValidacaoEmailException ex)
            {
                MessageBox.Show(ex.Message, "Validacao campos vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (ValidacaoCamposVaziosException ex)
            {
                MessageBox.Show(ex.Message, "Validacao Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Hide();
            PagPrincipal form = new PagPrincipal();
            form.ShowDialog();
            this.Close();

        }

        private void button_voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormTelaDeContas form_ir = new FormTelaDeContas();
            form_ir.ShowDialog();
            this.Close();
        }
    }
}
