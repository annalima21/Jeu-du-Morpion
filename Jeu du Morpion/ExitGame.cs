using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jeu_du_Morpion
{
    public partial class ExitGame : Form
    {
        public ExitGame()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ExitGame_Load(object sender, EventArgs e)
        {

        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonYes_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
