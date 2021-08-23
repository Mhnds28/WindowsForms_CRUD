using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Floricuturaa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addFuncionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addFuncionario add = new addFuncionario();
            add.ShowDialog();
        }

        private void sAIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MENU_Load(object sender, EventArgs e)
        {

        }
    }
}
