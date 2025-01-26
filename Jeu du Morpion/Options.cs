using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        public string image1Path;
        public string image2Path;


        public Options(int previousMode, int previousLevel)
        {
            InitializeComponent();

            // Restaurar seleções anteriores
            mode = previousMode;
            level = previousLevel;

            RestorePreviousSelections();
        }

        private void RestorePreviousSelections()
        {
            // Verificar o modo anterior
            if (mode == 0)
            {
                checkBox1.Checked = true; // PvP
            }
            else if (mode == 1)
            {
                checkBox2.Checked = true; // PvC
            }

            // Verificar o nível anterior
            switch (level)
            {
                case 1:
                    checkBox3.Checked = true; // Easy
                    break;
                case 2:
                    checkBox4.Checked = true; // Medium
                    break;
                case 3:
                    checkBox5.Checked = true; // Hard
                    break;
                case 4:
                    checkBox6.Checked = true; // Insane
                    break;
            }
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
                checkBox5.Checked = false;
                checkBox6.Checked = false;
            }
        }
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                level = 2;
                checkBox3.Checked = false;
                checkBox5.Checked = false;
                checkBox6.Checked = false;
            }
        }
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                level = 3;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox6.Checked = false;

            }
        }
        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox6.Checked)
            {
                level = 4;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;

            }
        }


        private void pictureFermer_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
                     

        private void buttonChoiceX_Click(object sender, EventArgs e)
        {
            //Donner le chemin des Images
            string imageDirectory = Path.Combine(Application.StartupPath, "Images");
            if (Directory.Exists(imageDirectory))
            {
                //Ouvrir le fichier des images
                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    InitialDirectory = imageDirectory,
                    Filter = "Images|*.jpg;*.jpeg;*.png;*.bmp",
                    Multiselect = false,
                    Title = "Choisir une image"
                };

                //Apliquer le choix
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string imagePath = openFileDialog.FileName;

                    // Vérifier si l'image est déjà dans pictureBox1
                    if (image2Path != null && image2Path == imagePath)
                    {
                        MessageBox.Show("Vous ne pouvez pas choisir le même icon pour les deux Joueurs !", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Charger l'image pour le Jouer X
                    BoxChoixX.Image = Image.FromFile(imagePath);
                    image1Path = imagePath; 
                }
            }

        }

        private void buttonChoiceO_Click(object sender, EventArgs e)
        {
            //Donner le chemin des Images
            string imageDirectory = Path.Combine(Application.StartupPath, "Images");
            if (Directory.Exists(imageDirectory))
            {
                //Ouvrir le fichier des images
                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    InitialDirectory = imageDirectory,
                    Filter = "Images|*.jpg;*.jpeg;*.png;*.bmp",
                    Multiselect = false,
                    Title = "Choisir une image"
                };

                //Apliquer le choix
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string imagePath = openFileDialog.FileName;

                    // Vérifier si l'image est déjà dans pictureBox1
                    if (image1Path != null && image1Path == imagePath)
                    {
                        MessageBox.Show("Vous ne pouvez pas choisir le même icon pour les deux Joueurs !", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Charger l'image pour le Jouer X
                    BoxChoixO.Image = Image.FromFile(imagePath);
                    image2Path = imagePath;
                }
            }

        }

        // Propriété publique pour exposer l'image de BoxChoixX
        public Image ImageChoisie1 // Stocker le chemin de l'image choisie
        {
            get { return BoxChoixX.Image; }
        }



        // Propriété publique pour exposer l'image de BoxChoixO
        public Image ImageChoisie2 // Stocker le chemin de l'image choisie
        {
            get { return BoxChoixO.Image; }
        }




        private void buttonMode_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }


    }
}
