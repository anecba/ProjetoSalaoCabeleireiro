using ProjetoSalaoCabeleireiro.view.cadastro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoSalaoCabeleireiro
{
    public partial class telaInicial : Form
    {
        public telaInicial()
        {
            InitializeComponent();
        }

        private void CadastroClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroCliente cadastroCliente = new CadastroCliente();
            cadastroCliente.Show();
        }
    }
}
