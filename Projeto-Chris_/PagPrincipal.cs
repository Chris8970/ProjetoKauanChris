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
    public partial class PagPrincipal : Form
    {
        public PagPrincipal()
        {
            InitializeComponent();
            
        }

        private void PagPrincipal_Load(object sender, EventArgs e)
        {
           
        }

        private void button_sair_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Obrigado, volte sempre!");
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDefinicoes form_ir = new FormDefinicoes();
            form_ir.ShowDialog();
            this.Show();
        }
    }
}