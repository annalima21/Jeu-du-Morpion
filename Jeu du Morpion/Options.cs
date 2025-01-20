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

    public partial class Options : Form
    {
        public int mode, level = 0;
        bool check1, check2 = false;

        
        public Options()
        {
            InitializeComponent();
            if (checkBox1 != null || checkBox2 != null) check1 = true;
            else if (checkBox3 != null || checkBox4 != null || checkBox6 != null) check2 = true;
            else
            {
                buttonMode.Enabled = false;
            }
            if (check1 == true && check2 == true) buttonMode.Enabled = true;
        }

        private void pictureFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
            {
                mode = 0;
                checkBox2.Checked = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                mode = 1;
                checkBox1.Checked = false;
            }

        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                level = 1;
                checkBox4.Checked = false;
                checkBox6.Checked = false;
            }

        }
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                level = 2;
                checkBox3.Checked = false;
                checkBox6.Checked = false;
            }
        }



        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox6.Checked)
            {
                level = 3;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
            }
        }

        private void buttonMode_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
