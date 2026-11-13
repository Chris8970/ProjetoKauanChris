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
    public partial class FormTelaDeContas : Form
    {
        public FormTelaDeContas()
        {
            InitializeComponent();
        }

        private void button_iniciarSessaoForm2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormContaIniciar form_ir = new FormContaIniciar();
            form_ir.ShowDialog();
            this.Show();
        }

        private void FormTelaDeContas_Load(object sender, EventArgs e)
        {

        }

        private void button_criarContaForm2_Click(object sender, EventArgs e)
        {
            this.Hide();
            CriarConta form_ir = new CriarConta();
            form_ir.ShowDialog();
            this.Show();
        }
    }
}
