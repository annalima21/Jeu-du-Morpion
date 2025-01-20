using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Threading;

namespace Jeu_du_Morpion
{
    public partial class Form1 : Form
    {
        bool Checker = true;
        int PlusOne;
        int selectedMode, selectedLevel;
        public int count = 0;
        public int countChecker = 0;


        // Déclare un tableau bidimensionnel de 3 lignes et 3 colonnes
        // Chaque case représente une position sur le plateau du jeu (Morpion).
        // Le tableau sera utilisé pour enregistrer l'état du jeu :
        // ' ' (vide), 'X' (joueur 1), ou 'O' (ordinateur ou joueur 2).
        int[,] tableau = new int[3, 3];

        private void Tableau()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    tableau[i, j] = ' '; //Initialiser tableau vide
                }
            }
        }
        void BoxNotWork()
        {
            Checker = true;
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
            countChecker++;
            count = 0;
            Tableau();
            ImprimirTableau();


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

            if (countChecker % 2 == 0)
            {
                Checker = true; // Jouer commence
                Console.WriteLine("jouer commence accept");

            }
            else if (countChecker % 2 != 0)
            {
                Checker = false; // O commence

                if (selectedMode == 1)
                {
                    Console.WriteLine("ordinateur commence accept");
                    EasyOrdinateur(); // teste si ordicommence
                }
            }

        }


        //Sound Play
        /*void SoundX()
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
        }*/

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
            Checker = true;
            Tableau();
            ImprimirTableau();
        }



        void Help()
        {
            Help help = new Help();
            help.ShowDialog();
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
                // WinnerX();
                MessageXShow();
                PlusOne = int.Parse(labelPoint_X.Text);
                labelPoint_X.Text = Convert.ToString(PlusOne + 1);
                BoxNotWork();
                return true;

            }
            else if (Box2_1.Image == pictureX.Image && Box2_2.Image == pictureX.Image && Box2_3.Image == pictureX.Image)
            {
                Box2_1.BackColor = Color.FromArgb(20, 250, 49, 74);
                Box2_2.BackColor = Color.FromArgb(20, 250, 49, 74);
                Box2_3.BackColor = Color.FromArgb(20, 250, 49, 74);
                // WinnerX();
                MessageXShow();
                PlusOne = int.Parse(labelPoint_X.Text);
                labelPoint_X.Text = Convert.ToString(PlusOne + 1);
                BoxNotWork();
                return true;
            }
            else if (Box3_1.Image == pictureX.Image && Box3_2.Image == pictureX.Image && Box3_3.Image == pictureX.Image)
            {
                Box3_1.BackColor = Color.FromArgb(20, 250, 49, 74);
                Box3_2.BackColor = Color.FromArgb(20, 250, 49, 74);
                Box3_3.BackColor = Color.FromArgb(20, 250, 49, 74);
                // WinnerX();
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
                // WinnerX();
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
                // WinnerX();
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
                // WinnerX();
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
                //WinnerX();
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
                // WinnerX();
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
                //  WinnerO();
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
                //  WinnerO();
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
                // WinnerO();
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
                //  WinnerO();
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
                //WinnerO();
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
                //  WinnerO();
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
                //  WinnerO();
                MessageOShow();
                PlusOne = int.Parse(labelPoints_O.Text);
                labelPoints_O.Text = Convert.ToString(PlusOne + 1);
                BoxNotWork();
                return true;
            }
            //DrawGame
            else if (Box1_1.Image != BoxReset.Image &&
                      Box1_2.Image != BoxReset.Image &&
                      Box1_3.Image != BoxReset.Image &&
                      Box2_1.Image != BoxReset.Image &&
                      Box2_2.Image != BoxReset.Image &&
                      Box2_3.Image != BoxReset.Image &&
                      Box3_1.Image != BoxReset.Image &&
                      Box3_2.Image != BoxReset.Image &&
                      Box3_3.Image != BoxReset.Image)
            {
                //  DrawGame();
                MessageDrawShow();
                PlusOne = int.Parse(labelPoint_Morpion.Text);
                labelPoint_Morpion.Text = Convert.ToString(PlusOne + 1);
                BoxNotWork();
                return true;

            }
            return false;

        }

        // DEBUG
        void ImprimirTableau()
        {
            Console.WriteLine("État actuel du tableau:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    char valor = tableau[i, j] == ' ' ? '.' : (char)tableau[i, j];
                    Console.Write(valor + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        //FIN DEBUG
        // Turn Ordinateur
        void Ordinateur(int i, int j)
        {
            PictureBox selectedPictureBox;
            string nomPictureBox = "Box" + i.ToString() + "_" + j.ToString();
            selectedPictureBox = (PictureBox)panelGame.Controls[nomPictureBox];
            Console.WriteLine("entre dans la fonction ordinateur" + " " + nomPictureBox);
            if (selectedPictureBox.Image == null)
            {
                Console.WriteLine("acepter fonction ordinateur" + " " + nomPictureBox);

                Thread.Sleep(500);
                selectedPictureBox.Image = pictureO.Image; // Ou pictureX.Image selon le choix
                selectedPictureBox.Enabled = false;
                tableau[i - 1, j - 1] = 'O';
                ImprimirTableau();

                selectedPictureBox.Refresh();
                Application.DoEvents();


                // SoundO();
                Checker = !Checker; // Alterne le joueur
                Console.WriteLine(Checker);

                return; // Quitte la fonction après avoir joué
            }
            else if (selectedPictureBox.Image != null)
            {
                Console.WriteLine("Casa já ocupada: " + nomPictureBox);
            }
            else
            {
                Console.WriteLine("Box não encontrada: " + nomPictureBox);
            }
        }
        void EasyOrdinateur()
        {
            Random rand = new Random(); // Générateur de nombres aléatoires


            // Boucle principale pour essayer de jouer
            // while (true)
            //  {
            int x = rand.Next(1, 4); // Génère un nombre aléatoire entre 1 et 3
            int y = rand.Next(1, 4);
            Ordinateur(x, y);
            Console.WriteLine("sortie de la fonction ordinateur");
            return;
            //  }


        }
        void MediumOrdinateur()
        {
            // Vérification des lignes et colonnes
            if (VerifierLignesEtColonnes('O')) return; // Priorité : gagner
            if (VerifierLignesEtColonnes('X')) return; // Deuxième priorité : bloquer l'adversaire

            // Vérification des diagonales
          //  if (VerifierDiagonales('O')) return; // Priorité : gagner
          //  if (VerifierDiagonales('X')) return; // Deuxième priorité : bloquer l'adversaire

            // Si aucune action prioritaire n'est trouvée, jouer dans une case vide aléatoire
            EasyOrdinateur();

            bool VerifierLignesEtColonnes(char symbole)
            {
                // Parcours des lignes et colonnes
                for (int i = 0; i < 3; i++)
                {
                    int compteurLigne = 0, compteurColonne = 0;
                    int videLigne = -1, videColonne = -1;

                    for (int j = 0; j < 3; j++)
                    {
                        // Vérification de la ligne
                        if (tableau[i, j] == symbole) compteurLigne++;
                        if (tableau[i, j] == ' ') videLigne = j;

                        // Vérification de la colonne
                        if (tableau[j, i] == symbole) compteurColonne++;
                        if (tableau[j, i] == ' ') videColonne = j;
                    }

                    // Si deux symboles sont alignés dans une ligne et qu'il reste une case vide
                    if (compteurLigne == 2 && videLigne != -1)
                    {
                        //   tableau[i, videLigne] = 'O'; // Le joueur ordinateur joue dans la ligne
                        Console.WriteLine("verification ligne true");
                        Ordinateur(i + 1, videLigne + 1); // Met à jour l'interface
                        return true;
                    }

                    // Si deux symboles sont alignés dans une colonne et qu'il reste une case vide
                    if (compteurColonne == 2 && videColonne != -1)
                    {
                        //   tableau[videColonne, i] = 'O'; // Le joueur ordinateur joue dans la colonne
                        Console.WriteLine("verification column true");
                        Ordinateur(videColonne + 1, i + 1); // Met à jour l'interface
                        return true;
                    }
                }


                // Aucun alignement trouvé
                return false;
            }

            /*bool VerifierDiagonales(char symbole)
            {
                // Diagonale principale (0,0 -> 1,1 -> 2,2)
                int compteurPrincipale = 0;
                int videPrincipale = -1;

                for (int i = 0; i < 3; i++)
                {
                    if (tableau[i, i] == symbole) compteurPrincipale++;
                    if (tableau[i, i] == ' ') videPrincipale = i;
                }

                if (compteurPrincipale == 2 && videPrincipale != -1)
                {
                    //  tableau[videPrincipale, videPrincipale] = 'O'; // Met à jour le tableau
                    Console.WriteLine("verification diagonale true");
                    Ordinateur(videPrincipale + 1, videPrincipale + 1); // Met à jour l'interface
                    return true;
                }

                // Diagonale secondaire (0,2 -> 1,1 -> 2,0)
                int compteurSecondaire = 0;
                int videSecondaire = -1;

                for (int i = 0; i < 3; i++)
                {
                    if (tableau[i, 2 - i] == symbole) compteurSecondaire++;
                    if (tableau[i, 2 - i] == ' ') videSecondaire = i;
                }

                if (compteurSecondaire == 2 && videSecondaire != -1)
                {
                    //  tableau[videSecondaire, 2 - videSecondaire] = 'O'; // Met à jour le tableau
                    Console.WriteLine("verification diagonale 2 true");
                    Ordinateur(videSecondaire + 1, (2 - videSecondaire) + 1); // Met à jour l'interface
                    return true;
                }
                // Aucun alignement trouvé
                return false;
            }*/
        }
        void HardOrdinateur()
        {
            Console.WriteLine("Entrando no modo HardOrdinateur...");

            int meilleurScore = int.MinValue; // Initialise le score maximum
            int meilleurX = -1, meilleurY = -1; // Coordonnées du meilleur mouvement

            // Parcourir toutes les cases du tableau
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    // Vérifie si la case est vide
                    if (tableau[i, j] == ' ')
                    {
                        // Simule le mouvement de l'ordinateur
                        tableau[i, j] = 'O';
                        Console.WriteLine($"Simulation du mouvement: tableau[{i},{j}] = 'O'");

                        // Appelle l'algorithme Minimax pour calculer le score du mouvement
                        int score = Minimax(false); // false signifie que c'est le tour du joueur humain

                        Console.WriteLine($"Score calculé pour tableau[{i},{j}]: {score}");

                        // Annule le mouvement simulé
                        tableau[i, j] = ' ';
                        Console.WriteLine($"Annulation du mouvement: tableau[{i},{j}] = ' '");

                        // Compare le score obtenu avec le meilleur score actuel
                        if (score > meilleurScore)
                        {
                            meilleurScore = score;
                            meilleurX = i + 1; // Ajustement des indices pour correspondre aux PictureBoxes
                            meilleurY = j + 1;
                            Console.WriteLine($"Nouveau meilleur mouvement trouvé: tableau[{i},{j}] avec score {meilleurScore}");
                        }
                    }
                }
            }

            // Effectue le meilleur mouvement trouvé
            if (meilleurX != -1 && meilleurY != -1)
            {
                Console.WriteLine($"Effectue le meilleur mouvement: Box{meilleurX}_{meilleurY}");
                Ordinateur(meilleurX, meilleurY); // Joue dans la meilleure position
            }
            else
            {
                Console.WriteLine("Aucun mouvement valide trouvé !");
                EasyOrdinateur();
            }
        }

        int Minimax(bool isMaximizing)
        {
            Console.WriteLine($"Entrée dans Minimax: isMaximizing = {isMaximizing}");

            // Vérifie si un joueur a gagné ou si le jeu est une égalité
            if (CheckWinner('O'))
            {
                Console.WriteLine("Minimax: L'ordinateur gagne");
                return 1;  // L'ordinateur gagne
            }
            if (CheckWinner('X'))
            {
                Console.WriteLine("Minimax: Le joueur gagne");
                return -1; // Le joueur humain gagne
            }
            if (IsDraw())
            {
                Console.WriteLine("Minimax: Match nul");
                return 0;  // Partie nulle
            }

            if (isMaximizing)
            {
                Console.WriteLine("Minimax: Tour de l'ordinateur (maximisation)");
                int meilleurScore = int.MinValue;

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (tableau[i, j] == ' ')
                        {
                            tableau[i, j] = 'O'; // Simule un mouvement de l'ordinateur
                            int score = Minimax(false); // Appelle récursivement Minimax pour minimiser
                            tableau[i, j] = ' '; // Annule le mouvement
                            meilleurScore = Math.Max(score, meilleurScore);
                            Console.WriteLine($"Minimax (maximisation): Score actuel: {score}, Meilleur score: {meilleurScore}");
                        }
                    }
                }
                return meilleurScore;
            }
            else
            {
                Console.WriteLine("Minimax: Tour du joueur (minimisation)");
                int meilleurScore = int.MaxValue;

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (tableau[i, j] == ' ')
                        {
                            tableau[i, j] = 'X'; // Simule un mouvement du joueur
                            int score = Minimax(true); // Appelle récursivement Minimax pour maximiser
                            tableau[i, j] = ' '; // Annule le mouvement
                            meilleurScore = Math.Min(score, meilleurScore);
                            Console.WriteLine($"Minimax (minimisation): Score actuel: {score}, Meilleur score: {meilleurScore}");
                        }
                    }
                }
                return meilleurScore;
            }
        }

        // Vérifie si un joueur a gagné
        bool CheckWinner(char symbole)
        {
            Console.WriteLine($"CheckWinner: Vérifie si {symbole} a gagné");

            for (int i = 0; i < 3; i++)
            {
                if (tableau[i, 0] == symbole && tableau[i, 1] == symbole && tableau[i, 2] == symbole) return true;
                if (tableau[0, i] == symbole && tableau[1, i] == symbole && tableau[2, i] == symbole) return true;
            }
            if (tableau[0, 0] == symbole && tableau[1, 1] == symbole && tableau[2, 2] == symbole) return true;
            if (tableau[0, 2] == symbole && tableau[1, 1] == symbole && tableau[2, 0] == symbole) return true;

            return false;
        }

        // Vérifie si toutes les cases sont remplies (égalité)
        bool IsDraw()
        {
            Console.WriteLine("IsDraw: Vérifie si toutes les cases sont remplies");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (tableau[i, j] == ' ') return false; // Il reste encore des cases vides
                }
            }
            return true; // Toutes les cases sont remplies
        }

        void Jouer(int x, int y)
        {
            // Entrée : x (int) - Coordonnée de la ligne
            // Entrée : y (int) - Coordonnée de la colonne

            // Construire le nom de la PictureBox en fonction des coordonnées (type : string)
            string pictureBoxName = "Box" + x.ToString() + "_" + y.ToString();
            // `x.ToString()` et `y.ToString()` convertissent les entiers en chaînes de caractères
            // Exemple de résultat : "Box1_2"

            // Rechercher la PictureBox dans les contrôles du formulaire
            PictureBox selectedPictureBox = (PictureBox)this.Controls.Find(pictureBoxName, true).FirstOrDefault();


            if (selectedPictureBox != null && selectedPictureBox.Image == null) // Vérifie si la PictureBox existe et n’a pas d’image
            {
                if (Checker)  // `Checker` (type : bool) - Indique si c'est au tour du joueur X (true) ou O (false)
                {
                    // `pictureX` (type : PictureBox) - Contient l'image du joueur X
                    selectedPictureBox.Image = pictureX.Image; // Affecte l'image associée au joueur X
                    selectedPictureBox.Enabled = false; // Désactive la PictureBox (type : bool)

                    tableau[x - 1, y - 1] = 'X'; //Actualiser tableau avec le choix du jouer
                    ImprimirTableau();
                    // `count` (type : int) - Compteur des coups joués
                    count++; // Incrémente le compteur de coups
                    //SoundX(); // Appelle la méthode SoundX() pour jouer un son (type : void)
                    Checker = !Checker;
                }
                else if (selectedMode == 0 && !Checker) // Si Checker est faux, c'est au tour du joueur O
                {
                    // `pictureO` (type : PictureBox) - Contient l'image du joueur O
                    selectedPictureBox.Image = pictureO.Image; // Affecte l'image associée au joueur O
                    selectedPictureBox.Enabled = false; // Désactive la PictureBox (type : bool)

                    tableau[x - 1, y - 1] = 'O';//Actualiser tableau avec le choix du jouer
                    ImprimirTableau();
                    Checker = !Checker;
                }

                // Alterne le joueur
                // `Checker` (type : bool) - Change de `true` à `false` ou vice-versa
                //Checker = !Checker;

                // Vérifie le score ou les conditions de victoire
                Console.WriteLine(countChecker);


                // Si le mode est "joueur contre ordinateur" et que c'est au tour de l'ordinateur de jouer
                while (selectedMode == 1 && !Checker && count <= 4)
                {
                    if (selectedLevel == 1)
                    {
                        EasyOrdinateur(); // Appelle la méthode `Ordinateur()` (type : void) pour exécuter le tour du CPU
                    }

                    if (selectedLevel == 2)
                    {
                        MediumOrdinateur();
                    }

                    if (selectedLevel == 3)
                    {
                        HardOrdinateur();
                    }
                }

                Score();
                Console.WriteLine(countChecker);


            }
        }

        public Form1()
        {
            InitializeComponent();
            OpenOptions();
            Tableau();

        }

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

        private void buttonNouveauJeu_Click_1(object sender, EventArgs e)
        {
            NewGame();
        }
        private void buttonOptions_Click(object sender, EventArgs e)
        {
            OpenOptions();
        }

        private void buttonAide_Click(object sender, EventArgs e)
        {
            Help();
        }
        private void buttonReset_Click(object sender, EventArgs e)
        {
            BoxWork();
            ResetBox();
        }

        private void OpenOptions()
        {
            Options options = new Options();
            if (options.ShowDialog() == DialogResult.OK)
            {
                selectedMode = options.mode;
                selectedLevel = options.level;
                if      (selectedMode == 0) label2.Text = "PvP" ;
                else if (selectedMode == 1) label2.Text = "PvC";
                else if (selectedLevel == 1) label3.Text = "Easy";
                else if (selectedLevel == 2) label3.Text = "Medium";
                else if (selectedLevel == 3) label3.Text = "Hard";
                else label3.Text = "You may select a Game Mode";
            }


        }

    }
}
