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
    }
}
