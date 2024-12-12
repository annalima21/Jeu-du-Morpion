using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.IO;
using System.Diagnostics;

namespace Jeu_du_Morpion
{
    public partial class Form1 : Form
    {
        bool Checker = true;
        int PlusOne;
        int Mode;
        bool fini = false;
        public int count = 0;

        void BoxNotWork()
        {
            Checker = true;
            fini = false;
            count = 5;
            Box1_1.Enabled = false;
            Box1_2.Enabled = false;
            Box1_3.Enabled = false;
            Box2_1.Enabled = false;
            Box2_2.Enabled = false;
            Box2_3.Enabled = false;
            Box3_1.Enabled = false;
            Box3_2.Enabled = false;
            Box3_3.Enabled = false;
        }

        void BoxWork()
        {
            Checker = true;
            fini = false;
            count = 5;
            Box1_1.Enabled = true;
            Box1_2.Enabled = true;
            Box1_3.Enabled = true;
            Box2_1.Enabled = true;
            Box2_2.Enabled = true;
            Box2_3.Enabled = true;
            Box3_1.Enabled = true;
            Box3_2.Enabled = true;
            Box3_3.Enabled = true;
        }

        void ResetBox()

        {
            Checker = true;
            fini = false;
            count = 0;
            Box1_1.Image = BoxReset.Image;
            Box1_2.Image = BoxReset.Image;
            Box1_3.Image = BoxReset.Image;
            Box2_1.Image = BoxReset.Image;
            Box2_2.Image = BoxReset.Image;
            Box2_3.Image = BoxReset.Image;
            Box3_1.Image = BoxReset.Image;
            Box3_2.Image = BoxReset.Image;
            Box3_3.Image = BoxReset.Image;

            Box1_1.BackColor = Color.LightGray;
            Box1_2.BackColor = Color.LightGray;
            Box1_3.BackColor = Color.LightGray;
            Box2_1.BackColor = Color.LightGray;
            Box2_2.BackColor = Color.LightGray;
            Box2_3.BackColor = Color.LightGray;
            Box3_1.BackColor = Color.LightGray;
            Box3_2.BackColor = Color.LightGray;
            Box3_3.BackColor = Color.LightGray;
        }

        //Sound Play
        void SoundX()
        {
            using (var soundPlayer = new SoundPlayer(@"C:\Users\userlocal\Documents\GEII\2eme Annee\IG\Projet Morpion\Sounds\SoundX.wav"))
            {
                soundPlayer.Play();
            }
        }
        void SoundO()
        {
            using (var soundPlayer = new SoundPlayer(@"C:\Users\userlocal\Documents\GEII\2eme Annee\IG\Projet Morpion\Sounds\SoundO.wav"))
            {
                soundPlayer.Play();
            }
        }
        void WinnerX()
        {
            using (var soundPlayer = new SoundPlayer(@"C:\Users\userlocal\Documents\GEII\2eme Annee\IG\Projet Morpion\Sounds\WinnerX.wav"))
            {
                soundPlayer.Play();
            }
        }
        void WinnerO()
        {
            using (var soundPlayer = new SoundPlayer(@"C:\Users\userlocal\Documents\GEII\2eme Annee\IG\Projet Morpion\Sounds\WinnerO.wav"))
            {
                soundPlayer.Play();
            }
        }
        void DrawGame()
        {
            using (var soundPlayer = new SoundPlayer(@"C:\Users\userlocal\Documents\GEII\2eme Annee\IG\Projet Morpion\Sounds\DrawGame.wav"))
            {
                soundPlayer.Play();
            }
        }
        
        //Go for Different Forms Show
        void MessageXShow()
        {
            MessageX messageX = new MessageX();
            messageX.ShowDialog();
        }
        void MessageOShow()
        {
            MessageO messageO = new MessageO();
            messageO.ShowDialog();
        }
        void MessageDrawShow()
        {
            MessageDraw messageDraw = new MessageDraw();
            messageDraw.ShowDialog();

        }
        void NewGame()
        {
            NewGame newGame = new NewGame();
            newGame.ShowDialog();
            fini = false;
            Checker = true;
        }
        void ExitGame()
        {
            ExitGame exitGame = new ExitGame();
            exitGame.ShowDialog();
        }
        //That count Score
        bool Score()
        {


            //Player X Wins
            if (Box1_1.Image == pictureX.Image && Box1_2.Image == pictureX.Image && Box1_3.Image == pictureX.Image)
            {
                Box1_1.BackColor = Color.FromArgb(20, 250, 49, 74);
                Box1_2.BackColor = Color.FromArgb(20, 250, 49, 74);
                Box1_3.BackColor = Color.FromArgb(20, 250, 49, 74);
                WinnerX();
                MessageXShow();
                PlusOne = int.Parse(labelPoint_X.Text);
                labelPoint_X.Text = Convert.ToString(PlusOne+1);
                BoxNotWork();
                return true;

            }
            else if (Box2_1.Image == pictureX.Image && Box2_2.Image == pictureX.Image && Box2_3.Image == pictureX.Image)
            {
                Box2_1.BackColor = Color.FromArgb(20, 250, 49, 74);
                Box2_2.BackColor = Color.FromArgb(20, 250, 49, 74);
                Box2_3.BackColor = Color.FromArgb(20, 250, 49, 74);
                WinnerX();
                MessageXShow();
                PlusOne = int.Parse(labelPoint_X.Text);
                labelPoint_X.Text = Convert.ToString(PlusOne + 1);
                BoxNotWork();
                return  true;
            }
            else if (Box3_1.Image == pictureX.Image && Box3_2.Image == pictureX.Image && Box3_3.Image == pictureX.Image)
            {
                Box3_1.BackColor = Color.FromArgb(20, 250, 49, 74);
                Box3_2.BackColor = Color.FromArgb(20, 250, 49, 74);
                Box3_3.BackColor = Color.FromArgb(20, 250, 49, 74);
                WinnerX();
                MessageXShow();
                PlusOne = int.Parse(labelPoint_X.Text);
                labelPoint_X.Text = Convert.ToString(PlusOne + 1);
                BoxNotWork();
                return true;
            }
            else if (Box1_1.Image == pictureX.Image && Box2_1.Image == pictureX.Image && Box3_1.Image == pictureX.Image)
            {
                Box1_1.BackColor = Color.FromArgb(20, 250, 49, 74);
                Box2_1.BackColor = Color.FromArgb(20, 250, 49, 74);
                Box3_1.BackColor = Color.FromArgb(20, 250, 49, 74);
                WinnerX();
                MessageXShow();
                PlusOne = int.Parse(labelPoint_X.Text);
                labelPoint_X.Text = Convert.ToString(PlusOne + 1);
                BoxNotWork();
                return true;
            }
            else if (Box1_2.Image == pictureX.Image && Box2_2.Image == pictureX.Image && Box3_2.Image == pictureX.Image)
            {
                Box1_2.BackColor = Color.FromArgb(20, 250, 49, 74);
                Box2_2.BackColor = Color.FromArgb(20, 250, 49, 74);
                Box3_2.BackColor = Color.FromArgb(20, 250, 49, 74);
                WinnerX();
                MessageXShow();
                PlusOne = int.Parse(labelPoint_X.Text);
                labelPoint_X.Text = Convert.ToString(PlusOne + 1);
                BoxNotWork();
                return true;
            }
            else if (Box1_3.Image == pictureX.Image && Box2_3.Image == pictureX.Image && Box3_3.Image == pictureX.Image)
            {
                Box1_3.BackColor = Color.FromArgb(20, 250, 49, 74);
                Box2_3.BackColor = Color.FromArgb(20, 250, 49, 74);
                Box3_3.BackColor = Color.FromArgb(20, 250, 49, 74);
                WinnerX();
                MessageXShow();
                PlusOne = int.Parse(labelPoint_X.Text);
                labelPoint_X.Text = Convert.ToString(PlusOne + 1);
                BoxNotWork();
                return true;
            }
            else if (Box1_1.Image == pictureX.Image && Box2_2.Image == pictureX.Image && Box3_3.Image == pictureX.Image)
            {
                Box1_1.BackColor = Color.FromArgb(20, 250, 49, 74);
                Box2_2.BackColor = Color.FromArgb(20, 250, 49, 74);
                Box3_3.BackColor = Color.FromArgb(20, 250, 49, 74);
                WinnerX();
                MessageXShow();
                PlusOne = int.Parse(labelPoint_X.Text);
                labelPoint_X.Text = Convert.ToString(PlusOne + 1);
                BoxNotWork();
                return true;
            }
            else if (Box1_3.Image == pictureX.Image && Box2_2.Image == pictureX.Image && Box3_1.Image == pictureX.Image)
            {
                Box1_3.BackColor = Color.FromArgb(20, 250, 49, 74);
                Box2_2.BackColor = Color.FromArgb(20, 250, 49, 74);
                Box3_1.BackColor = Color.FromArgb(20, 250, 49, 74);
                WinnerX();
                MessageXShow();
                PlusOne = int.Parse(labelPoint_X.Text);
                labelPoint_X.Text = Convert.ToString(PlusOne + 1);
                BoxNotWork();
                return true;
            }
            //Player O wins
            if (Box1_1.Image == pictureO.Image && Box1_2.Image == pictureO.Image && Box1_3.Image == pictureO.Image)
            {
                Box1_1.BackColor = Color.FromArgb(20, 0, 185, 255);
                Box1_2.BackColor = Color.FromArgb(20, 0, 185, 255);
                Box1_3.BackColor = Color.FromArgb(20, 0, 185, 255);
                MessageOShow();
                PlusOne = int.Parse(labelPoints_O.Text);
                labelPoints_O.Text = Convert.ToString(PlusOne + 1);
                BoxNotWork();
                return true;
            }
            else if (Box2_1.Image == pictureO.Image && Box2_2.Image == pictureO.Image && Box2_3.Image == pictureO.Image)
            {
                Box2_1.BackColor = Color.FromArgb(20, 0, 185, 255);
                Box2_2.BackColor = Color.FromArgb(20, 0, 185, 255);
                Box2_3.BackColor = Color.FromArgb(20, 0, 185, 255);
                WinnerO();
                MessageOShow();
                PlusOne = int.Parse(labelPoints_O.Text);
                labelPoints_O.Text = Convert.ToString(PlusOne + 1);
                BoxNotWork();
                return true;
            }
            else if (Box3_1.Image == pictureO.Image && Box3_2.Image == pictureO.Image && Box3_3.Image == pictureO.Image)
            {
                Box3_1.BackColor = Color.FromArgb(20, 0, 185, 255);
                Box3_2.BackColor = Color.FromArgb(20, 0, 185, 255);
                Box3_3.BackColor = Color.FromArgb(20, 0, 185, 255);
                WinnerO();
                MessageOShow();
                PlusOne = int.Parse(labelPoints_O.Text);
                labelPoints_O.Text = Convert.ToString(PlusOne + 1);
                BoxNotWork();
                return true;
            }
            else if (Box1_1.Image == pictureO.Image && Box2_1.Image == pictureO.Image && Box3_1.Image == pictureO.Image)
            {
                Box1_1.BackColor = Color.FromArgb(20, 0, 185, 255);
                Box2_1.BackColor = Color.FromArgb(20, 0, 185, 255);
                Box3_1.BackColor = Color.FromArgb(20, 0, 185, 255);
                WinnerO();
                MessageOShow();
                PlusOne = int.Parse(labelPoints_O.Text);
                labelPoints_O.Text = Convert.ToString(PlusOne + 1);
                BoxNotWork();
                return true;
            }
            else if (Box1_2.Image == pictureO.Image && Box2_2.Image == pictureO.Image && Box3_2.Image == pictureO.Image)
            {
                Box1_2.BackColor = Color.FromArgb(20, 0, 185, 255);
                Box2_2.BackColor = Color.FromArgb(20, 0, 185, 255);
                Box3_2.BackColor = Color.FromArgb(20, 0, 185, 255);
                WinnerO();
                MessageOShow();
                PlusOne = int.Parse(labelPoints_O.Text);
                labelPoints_O.Text = Convert.ToString(PlusOne + 1);
                BoxNotWork();
                return true;
            }
            else if (Box1_3.Image == pictureO.Image && Box2_3.Image == pictureO.Image && Box3_3.Image == pictureO.Image)
            {
                Box1_3.BackColor = Color.FromArgb(20, 0, 185, 255);
                Box2_3.BackColor = Color.FromArgb(20, 0, 185, 255);
                Box3_3.BackColor = Color.FromArgb(20, 0, 185, 255);
                WinnerO();
                MessageOShow();
                PlusOne = int.Parse(labelPoints_O.Text);
                labelPoints_O.Text = Convert.ToString(PlusOne + 1);
                BoxNotWork(); 
                return true;
            }
            else if (Box1_1.Image == pictureO.Image && Box2_2.Image == pictureO.Image && Box3_3.Image == pictureO.Image)
            {
                Box1_1.BackColor = Color.FromArgb(20, 0, 185, 255);
                Box2_2.BackColor = Color.FromArgb(20, 0, 185, 255);
                Box3_3.BackColor = Color.FromArgb(20, 0, 185, 255);
                WinnerO();
                MessageOShow();
                PlusOne = int.Parse(labelPoints_O.Text);
                labelPoints_O.Text = Convert.ToString(PlusOne + 1);
                BoxNotWork();
                return true;
            }
            else if (Box1_3.Image == pictureO.Image && Box2_2.Image == pictureO.Image && Box3_1.Image == pictureO.Image)
            {
                Box1_3.BackColor = Color.FromArgb(20, 0, 185, 255);
                Box2_2.BackColor = Color.FromArgb(20, 0, 185, 255);
                Box3_1.BackColor = Color.FromArgb(20, 0, 185, 255);
                WinnerO();
                MessageOShow();
                PlusOne = int.Parse(labelPoints_O.Text);
                labelPoints_O.Text = Convert.ToString(PlusOne + 1);
                BoxNotWork();
                return true;
            }
            //DrawGame
            else if ( Box1_1.Image != BoxReset.Image && 
                      Box1_2.Image != BoxReset.Image && 
                      Box1_3.Image != BoxReset.Image && 
                      Box2_1.Image != BoxReset.Image && 
                      Box2_2.Image != BoxReset.Image && 
                      Box2_3.Image != BoxReset.Image && 
                      Box3_1.Image != BoxReset.Image && 
                      Box3_2.Image != BoxReset.Image && 
                      Box3_3.Image != BoxReset.Image)
            {
                DrawGame();
                MessageDrawShow();
                PlusOne = int.Parse(labelPoint_Morpion.Text);
                labelPoint_Morpion.Text = Convert.ToString(PlusOne + 1);
                BoxNotWork();
                return  true;

            }            
            return false;

        }

        // Turn Ordinateur
        void Ordinateur()
        {
            Random rand = new Random(); // Générateur de nombres aléatoires
            HashSet<string> combinaisons = new HashSet<string>(); // Stocke les combinaisons testées
            int x, y;
            PictureBox selectedPictureBox;

            // Boucle principale pour essayer de jouer
            while (combinaisons.Count < 9)
            {
                x = rand.Next(1, 4); // Génère un nombre aléatoire entre 1 et 3
                y = rand.Next(1, 4);

                string nomPictureBox = "Box" + x.ToString() + "_" + y.ToString();

                if (combinaisons.Contains(nomPictureBox))
                {
                    continue; // Passe à la prochaine tentative
                }

                combinaisons.Add(nomPictureBox); // Marque la combinaison comme testée
                selectedPictureBox = (PictureBox)this.Controls.Find(nomPictureBox, true).FirstOrDefault();

                if (selectedPictureBox != null && selectedPictureBox.Image == null)
                {
                    selectedPictureBox.Image = pictureO.Image; // Ou pictureX.Image selon le choix
                    selectedPictureBox.Enabled = false;
                    SoundO();
                    Checker = !Checker; // Alterne le joueur
                    return; // Quitte la fonction après avoir joué
                }
            }

            return;
        }



        void Jouer(int x, int y)
        {
            
            // Construir o nome da PictureBox com base nas coordenadas linha e coluna
            string pictureBoxName = "Box" + x.ToString() + "_" + y.ToString();
            // Encontrar a PictureBox com o nome construído
            PictureBox selectedPictureBox = (PictureBox)this.Controls.Find(pictureBoxName, true).FirstOrDefault();
            if (selectedPictureBox != null && selectedPictureBox.Image == null)
            {
                // Aqui você pode alterar a imagem do PictureBox ou fazer outra ação
                if (Checker)  // Se true, jogador X joga
                {
                    selectedPictureBox.Image = pictureX.Image;
                    selectedPictureBox.Enabled = false;
                    count++;
                    SoundX();
                }
                else if (!Checker)  // Se false, jogador O joga
                {
                    selectedPictureBox.Image = pictureO.Image;
                    selectedPictureBox.Enabled = false;
                }
                // Alterna o jogador
                Checker = !Checker;  // Se estava 'true', muda para 'false' e vice-versa
                // Se o modo for 1xCom (jogador contra computador), chama a função do computador
                while (Mode == 1 && !Checker && count<=4)  // Quando a vez do computador chegar
                {
                    Ordinateur(); // Chama a função que simula o computador jogando
                }


                Score();
               
            }
            
            
        }

        public Form1()
        {
            InitializeComponent();


        }

        // Custom Close and Minimize Button
      

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureFermer_Click(object sender, EventArgs e)
        {
            ExitGame();
        }

        private void pictureMinimizer_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Box1_1_Click(object sender, EventArgs e)
        {
           // ButtonBox1_1();
            Jouer(1, 1);

        }

        private void Box1_2_Click(object sender, EventArgs e)
        {
           // ButtonBox1_2();
            Jouer(1, 2);
        }

        private void Box1_3_Click(object sender, EventArgs e)
        {
            // ButtonBox1_3();
            Jouer(1, 3);
        }

        private void Box2_1_Click(object sender, EventArgs e)
        {
            //ButtonBox2_1();
            Jouer(2, 1);
        }

        private void Box2_2_Click(object sender, EventArgs e)
        {
           // ButtonBox2_2();
            Jouer(2, 2);
        }

        private void Box2_3_Click(object sender, EventArgs e)
        {
          // ButtonBox2_3();
            Jouer(2, 3);
        }

        private void Box3_1_Click(object sender, EventArgs e)
        {
            //ButtonBox3_1();
            Jouer(3, 1);
        }

        private void Box3_2_Click(object sender, EventArgs e)
        {
            // ButtonBox3_2();
            Jouer(3, 2);
        }

        private void Box3_3_Click(object sender, EventArgs e)
        {
            // ButtonBox3_3();
            Jouer(3, 3);
        }

        private void buttonNouveauJeu_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            BoxWork();
            ResetBox();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Mode = 0;
                label2.Text = checkBox1.Text;
                checkBox2.Checked = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                Mode = 1;
                label2.Text = checkBox2.Text;
                checkBox1.Checked = false;
            }
        }
    }
}
