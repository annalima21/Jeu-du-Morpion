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
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();

                // Empêche l'utilisateur de modifier le texte
                richTextBox1.ReadOnly = true;

                // Optionnel : Ajuste l'apparence
                richTextBox1.BackColor = this.BackColor; // Assure que l'arrière-plan correspond au formulaire
                richTextBox1.BorderStyle = BorderStyle.None; // Supprime les bordures pour une meilleure intégration visuelle

                // Vide le RichTextBox avant d'ajouter du texte
                richTextBox1.Clear();

                // Titre principal
                richTextBox1.SelectionFont = new Font("Arial", 14, FontStyle.Bold);
                richTextBox1.SelectionColor = Color.Black;
                richTextBox1.AppendText("Règles du Jeu du Morpion\n\n");

                // Section 1 : Objectif du jeu
                richTextBox1.SelectionFont = new Font("Arial", 12, FontStyle.Bold);
                richTextBox1.SelectionColor = Color.Black;
                richTextBox1.AppendText("Objectif du jeu :\n");

                richTextBox1.SelectionFont = new Font("Arial", 12, FontStyle.Regular);
                richTextBox1.SelectionColor = Color.Gray;
                richTextBox1.AppendText("Être le premier à aligner 3 symboles identiques (en ligne, en colonne ou en diagonale).\n\n");

                // Section 2 : Joueurs
                richTextBox1.SelectionFont = new Font("Arial", 12, FontStyle.Bold);
                richTextBox1.SelectionColor = Color.Black;
                richTextBox1.AppendText("Joueurs :\n");

                richTextBox1.SelectionFont = new Font("Arial", 12, FontStyle.Regular);
                richTextBox1.SelectionColor = Color.Gray;
                richTextBox1.AppendText("Le jeu se joue entre deux joueurs.\n" +
                                        "Le premier joueur utilise le symbole \"X\".\n" +
                                        "Le second joueur utilise le symbole \"O\".\n\n");

                // Section 3 : Déroulement
                richTextBox1.SelectionFont = new Font("Arial", 12, FontStyle.Bold);
                richTextBox1.SelectionColor = Color.Black;
                richTextBox1.AppendText("Déroulement :\n");

                richTextBox1.SelectionFont = new Font("Arial", 12, FontStyle.Regular);
                richTextBox1.SelectionColor = Color.Gray;
                richTextBox1.AppendText("Les joueurs jouent chacun leur tour.\n"+
                                        "À chaque tour, un joueur place son symbole dans une case vide.\n\n");

                // Section 4 : Conditions de victoire
                richTextBox1.SelectionFont = new Font("Arial", 12, FontStyle.Bold);
                richTextBox1.SelectionColor = Color.Black;
                richTextBox1.AppendText("Conditions de victoire :\n");

                richTextBox1.SelectionFont = new Font("Arial", 12, FontStyle.Regular);
                richTextBox1.SelectionColor = Color.Gray;
                richTextBox1.AppendText("Un joueur gagne s’il parvient à aligner 3 de ses symboles en ligne, en colonne ou en diagonale.\n\n");

                // Section 5 : Égalité
                richTextBox1.SelectionFont = new Font("Arial", 12, FontStyle.Bold);
                richTextBox1.SelectionColor = Color.Black;
                richTextBox1.AppendText("Égalité :\n");

                richTextBox1.SelectionFont = new Font("Arial", 12, FontStyle.Regular);
                richTextBox1.SelectionColor = Color.Gray;
                richTextBox1.AppendText("Si toutes les cases sont remplies et qu’aucun joueur n’a aligné 3 symboles, la partie se termine par une égalité.\n\n");

                // Section 6 : Modes de jeu
                richTextBox1.SelectionFont = new Font("Arial", 12, FontStyle.Bold);
                richTextBox1.SelectionColor = Color.Black;
                richTextBox1.AppendText("Modes de jeu :\n");

                richTextBox1.SelectionFont = new Font("Arial", 12, FontStyle.Regular);
                richTextBox1.SelectionColor = Color.Gray;
                richTextBox1.AppendText("Joueur vs Joueur (PvP) : Deux joueurs s’affrontent.\n"+
                                        "Joueur vs Ordinateur (PvC) : Le joueur affronte l’ordinateur.\n\n");

                // Section 7 : Difficultés
                richTextBox1.SelectionFont = new Font("Arial", 12, FontStyle.Bold);
                richTextBox1.SelectionColor = Color.Black;
                richTextBox1.AppendText("Difficultés (si applicable pour le mode PvC) :\n");

                richTextBox1.SelectionFont = new Font("Arial", 12, FontStyle.Regular);
                richTextBox1.SelectionColor = Color.Gray;
                richTextBox1.AppendText("Facile : L’ordinateur joue aléatoirement.\n"+
                                        "Moyen : L’ordinateur joue en évitant les erreurs simples.\n"+
                                        "Difficile : L’ordinateur joue de manière stratégique pour gagner ou bloquer.\n\n");

                // Section 8 : Règle d'annulation
                richTextBox1.SelectionFont = new Font("Arial", 12, FontStyle.Bold);
                richTextBox1.SelectionColor = Color.Black;
                richTextBox1.AppendText("Règle d'annulation :\n");

                richTextBox1.SelectionFont = new Font("Arial", 12, FontStyle.Regular);
                richTextBox1.SelectionColor = Color.Gray;
                richTextBox1.AppendText("Une case déjà remplie ne peut pas être utilisée à nouveau.\n\n");

                // Optionnel : Fait défiler le texte vers le haut
                richTextBox1.SelectionStart = 0;
                richTextBox1.ScrollToCaret();
            
        }

        private void pictureFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelToolBar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
   
}
