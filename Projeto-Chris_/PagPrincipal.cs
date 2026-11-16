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
            label_nomeUt.Text = Globais.emails;
        }
        
    }
}