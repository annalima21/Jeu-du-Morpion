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
    public partial class MessageDraw : Form
    {
        // Déclarez la variable d'instance _image (si elle n'est pas déjà définie ailleurs dans la classe)
        private Image _image;
        public MessageDraw(Image image)
        {
            InitializeComponent();
            _image = image;  // Utilisez l'image passée dans le constructeur
            pictureBox1.Image = _image ?? global::Jeu_du_Morpion.Properties.Resources.O_tic_tac_toe;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
