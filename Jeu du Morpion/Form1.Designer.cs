namespace Jeu_du_Morpion
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelToolBar = new System.Windows.Forms.Panel();
            this.buttonAide = new System.Windows.Forms.Button();
            this.buttonOptions = new System.Windows.Forms.Button();
            this.buttonNouveauJeu = new System.Windows.Forms.Button();
            this.pictureMinimizer = new System.Windows.Forms.PictureBox();
            this.pictureFermer = new System.Windows.Forms.PictureBox();
            this.pictureIcon = new System.Windows.Forms.PictureBox();
            this.panelGame = new System.Windows.Forms.Panel();
            this.Box3_3 = new System.Windows.Forms.PictureBox();
            this.Box2_3 = new System.Windows.Forms.PictureBox();
            this.Box1_3 = new System.Windows.Forms.PictureBox();
            this.Box3_2 = new System.Windows.Forms.PictureBox();
            this.Box3_1 = new System.Windows.Forms.PictureBox();
            this.Box2_2 = new System.Windows.Forms.PictureBox();
            this.Box2_1 = new System.Windows.Forms.PictureBox();
            this.Box1_2 = new System.Windows.Forms.PictureBox();
            this.Box1_1 = new System.Windows.Forms.PictureBox();
            this.panelScore = new System.Windows.Forms.Panel();
            this.Egal3 = new System.Windows.Forms.Label();
            this.Egal2 = new System.Windows.Forms.Label();
            this.Egal1 = new System.Windows.Forms.Label();
            this.labelPoint_Morpion = new System.Windows.Forms.Label();
            this.labelPoint_X = new System.Windows.Forms.Label();
            this.labelPoints_O = new System.Windows.Forms.Label();
            this.pictureMorpion = new System.Windows.Forms.PictureBox();
            this.pictureX = new System.Windows.Forms.PictureBox();
            this.pictureO = new System.Windows.Forms.PictureBox();
            this.panelSettings = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BoxReset = new System.Windows.Forms.PictureBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.panelToolBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMinimizer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFermer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureIcon)).BeginInit();
            this.panelGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Box3_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box2_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box1_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box3_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box3_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box2_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box2_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box1_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box1_1)).BeginInit();
            this.panelScore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMorpion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureO)).BeginInit();
            this.panelSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BoxReset)).BeginInit();
            this.SuspendLayout();
            // 
            // panelToolBar
            // 
            this.panelToolBar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelToolBar.Controls.Add(this.buttonAide);
            this.panelToolBar.Controls.Add(this.buttonOptions);
            this.panelToolBar.Controls.Add(this.buttonNouveauJeu);
            this.panelToolBar.Controls.Add(this.pictureMinimizer);
            this.panelToolBar.Controls.Add(this.pictureFermer);
            this.panelToolBar.Controls.Add(this.pictureIcon);
            this.panelToolBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelToolBar.Location = new System.Drawing.Point(0, 0);
            this.panelToolBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelToolBar.Name = "panelToolBar";
            this.panelToolBar.Size = new System.Drawing.Size(911, 30);
            this.panelToolBar.TabIndex = 0;
            this.panelToolBar.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // buttonAide
            // 
            this.buttonAide.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAide.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAide.Location = new System.Drawing.Point(239, 0);
            this.buttonAide.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAide.Name = "buttonAide";
            this.buttonAide.Size = new System.Drawing.Size(107, 30);
            this.buttonAide.TabIndex = 23;
            this.buttonAide.Text = "Help";
            this.buttonAide.UseVisualStyleBackColor = false;
            this.buttonAide.Click += new System.EventHandler(this.buttonAide_Click);
            // 
            // buttonOptions
            // 
            this.buttonOptions.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonOptions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOptions.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOptions.Location = new System.Drawing.Point(134, 0);
            this.buttonOptions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonOptions.Name = "buttonOptions";
            this.buttonOptions.Size = new System.Drawing.Size(107, 30);
            this.buttonOptions.TabIndex = 22;
            this.buttonOptions.Text = "Options";
            this.buttonOptions.UseVisualStyleBackColor = false;
            this.buttonOptions.Click += new System.EventHandler(this.buttonOptions_Click);
            // 
            // buttonNouveauJeu
            // 
            this.buttonNouveauJeu.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonNouveauJeu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNouveauJeu.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNouveauJeu.Location = new System.Drawing.Point(29, 0);
            this.buttonNouveauJeu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonNouveauJeu.Name = "buttonNouveauJeu";
            this.buttonNouveauJeu.Size = new System.Drawing.Size(107, 30);
            this.buttonNouveauJeu.TabIndex = 21;
            this.buttonNouveauJeu.Text = "New Game";
            this.buttonNouveauJeu.UseVisualStyleBackColor = false;
            this.buttonNouveauJeu.Click += new System.EventHandler(this.buttonNouveauJeu_Click_1);
            // 
            // pictureMinimizer
            // 
            this.pictureMinimizer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureMinimizer.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureMinimizer.ErrorImage = null;
            this.pictureMinimizer.Image = global::Jeu_du_Morpion.Properties.Resources.minimizar;
            this.pictureMinimizer.InitialImage = null;
            this.pictureMinimizer.Location = new System.Drawing.Point(853, 0);
            this.pictureMinimizer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureMinimizer.Name = "pictureMinimizer";
            this.pictureMinimizer.Size = new System.Drawing.Size(29, 30);
            this.pictureMinimizer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureMinimizer.TabIndex = 2;
            this.pictureMinimizer.TabStop = false;
            this.pictureMinimizer.Click += new System.EventHandler(this.pictureMinimizer_Click);
            // 
            // pictureFermer
            // 
            this.pictureFermer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureFermer.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureFermer.ErrorImage = null;
            this.pictureFermer.Image = global::Jeu_du_Morpion.Properties.Resources.Capture;
            this.pictureFermer.InitialImage = null;
            this.pictureFermer.Location = new System.Drawing.Point(882, 0);
            this.pictureFermer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureFermer.Name = "pictureFermer";
            this.pictureFermer.Size = new System.Drawing.Size(29, 30);
            this.pictureFermer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureFermer.TabIndex = 1;
            this.pictureFermer.TabStop = false;
            this.pictureFermer.Click += new System.EventHandler(this.pictureFermer_Click);
            // 
            // pictureIcon
            // 
            this.pictureIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureIcon.ErrorImage = null;
            this.pictureIcon.Image = global::Jeu_du_Morpion.Properties.Resources.tic_tac_toe_vide;
            this.pictureIcon.InitialImage = null;
            this.pictureIcon.Location = new System.Drawing.Point(0, 0);
            this.pictureIcon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureIcon.Name = "pictureIcon";
            this.pictureIcon.Size = new System.Drawing.Size(29, 30);
            this.pictureIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureIcon.TabIndex = 0;
            this.pictureIcon.TabStop = false;
            // 
            // panelGame
            // 
            this.panelGame.Controls.Add(this.Box3_3);
            this.panelGame.Controls.Add(this.Box2_3);
            this.panelGame.Controls.Add(this.Box1_3);
            this.panelGame.Controls.Add(this.Box3_2);
            this.panelGame.Controls.Add(this.Box3_1);
            this.panelGame.Controls.Add(this.Box2_2);
            this.panelGame.Controls.Add(this.Box2_1);
            this.panelGame.Controls.Add(this.Box1_2);
            this.panelGame.Controls.Add(this.Box1_1);
            this.panelGame.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelGame.Location = new System.Drawing.Point(0, 30);
            this.panelGame.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelGame.Name = "panelGame";
            this.panelGame.Size = new System.Drawing.Size(511, 512);
            this.panelGame.TabIndex = 1;
            // 
            // Box3_3
            // 
            this.Box3_3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Box3_3.ErrorImage = null;
            this.Box3_3.InitialImage = null;
            this.Box3_3.Location = new System.Drawing.Point(343, 342);
            this.Box3_3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Box3_3.Name = "Box3_3";
            this.Box3_3.Size = new System.Drawing.Size(161, 161);
            this.Box3_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Box3_3.TabIndex = 0;
            this.Box3_3.TabStop = false;
            this.Box3_3.Click += new System.EventHandler(this.Box3_3_Click);
            // 
            // Box2_3
            // 
            this.Box2_3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Box2_3.ErrorImage = null;
            this.Box2_3.InitialImage = null;
            this.Box2_3.Location = new System.Drawing.Point(343, 175);
            this.Box2_3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Box2_3.Name = "Box2_3";
            this.Box2_3.Size = new System.Drawing.Size(161, 161);
            this.Box2_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Box2_3.TabIndex = 0;
            this.Box2_3.TabStop = false;
            this.Box2_3.Click += new System.EventHandler(this.Box2_3_Click);
            // 
            // Box1_3
            // 
            this.Box1_3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Box1_3.ErrorImage = null;
            this.Box1_3.InitialImage = null;
            this.Box1_3.Location = new System.Drawing.Point(343, 7);
            this.Box1_3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Box1_3.Name = "Box1_3";
            this.Box1_3.Size = new System.Drawing.Size(161, 161);
            this.Box1_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Box1_3.TabIndex = 0;
            this.Box1_3.TabStop = false;
            this.Box1_3.Click += new System.EventHandler(this.Box1_3_Click);
            // 
            // Box3_2
            // 
            this.Box3_2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Box3_2.ErrorImage = null;
            this.Box3_2.InitialImage = null;
            this.Box3_2.Location = new System.Drawing.Point(176, 342);
            this.Box3_2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Box3_2.Name = "Box3_2";
            this.Box3_2.Size = new System.Drawing.Size(161, 161);
            this.Box3_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Box3_2.TabIndex = 0;
            this.Box3_2.TabStop = false;
            this.Box3_2.Click += new System.EventHandler(this.Box3_2_Click);
            // 
            // Box3_1
            // 
            this.Box3_1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Box3_1.ErrorImage = null;
            this.Box3_1.InitialImage = null;
            this.Box3_1.Location = new System.Drawing.Point(9, 342);
            this.Box3_1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Box3_1.Name = "Box3_1";
            this.Box3_1.Size = new System.Drawing.Size(161, 161);
            this.Box3_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Box3_1.TabIndex = 0;
            this.Box3_1.TabStop = false;
            this.Box3_1.Click += new System.EventHandler(this.Box3_1_Click);
            // 
            // Box2_2
            // 
            this.Box2_2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Box2_2.ErrorImage = null;
            this.Box2_2.InitialImage = null;
            this.Box2_2.Location = new System.Drawing.Point(176, 175);
            this.Box2_2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Box2_2.Name = "Box2_2";
            this.Box2_2.Size = new System.Drawing.Size(161, 161);
            this.Box2_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Box2_2.TabIndex = 0;
            this.Box2_2.TabStop = false;
            this.Box2_2.Click += new System.EventHandler(this.Box2_2_Click);
            // 
            // Box2_1
            // 
            this.Box2_1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Box2_1.ErrorImage = null;
            this.Box2_1.InitialImage = null;
            this.Box2_1.Location = new System.Drawing.Point(9, 175);
            this.Box2_1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Box2_1.Name = "Box2_1";
            this.Box2_1.Size = new System.Drawing.Size(161, 161);
            this.Box2_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Box2_1.TabIndex = 0;
            this.Box2_1.TabStop = false;
            this.Box2_1.Click += new System.EventHandler(this.Box2_1_Click);
            // 
            // Box1_2
            // 
            this.Box1_2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Box1_2.ErrorImage = null;
            this.Box1_2.InitialImage = null;
            this.Box1_2.Location = new System.Drawing.Point(176, 7);
            this.Box1_2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Box1_2.Name = "Box1_2";
            this.Box1_2.Size = new System.Drawing.Size(161, 161);
            this.Box1_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Box1_2.TabIndex = 0;
            this.Box1_2.TabStop = false;
            this.Box1_2.Click += new System.EventHandler(this.Box1_2_Click);
            // 
            // Box1_1
            // 
            this.Box1_1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Box1_1.ErrorImage = null;
            this.Box1_1.InitialImage = null;
            this.Box1_1.Location = new System.Drawing.Point(9, 7);
            this.Box1_1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Box1_1.Name = "Box1_1";
            this.Box1_1.Size = new System.Drawing.Size(161, 161);
            this.Box1_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Box1_1.TabIndex = 0;
            this.Box1_1.TabStop = false;
            this.Box1_1.Click += new System.EventHandler(this.Box1_1_Click);
            // 
            // panelScore
            // 
            this.panelScore.Controls.Add(this.Egal3);
            this.panelScore.Controls.Add(this.Egal2);
            this.panelScore.Controls.Add(this.Egal1);
            this.panelScore.Controls.Add(this.labelPoint_Morpion);
            this.panelScore.Controls.Add(this.labelPoint_X);
            this.panelScore.Controls.Add(this.labelPoints_O);
            this.panelScore.Controls.Add(this.pictureMorpion);
            this.panelScore.Controls.Add(this.pictureX);
            this.panelScore.Controls.Add(this.pictureO);
            this.panelScore.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelScore.Location = new System.Drawing.Point(511, 30);
            this.panelScore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelScore.Name = "panelScore";
            this.panelScore.Size = new System.Drawing.Size(400, 261);
            this.panelScore.TabIndex = 2;
            // 
            // Egal3
            // 
            this.Egal3.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Egal3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Egal3.Location = new System.Drawing.Point(158, 176);
            this.Egal3.Name = "Egal3";
            this.Egal3.Size = new System.Drawing.Size(77, 83);
            this.Egal3.TabIndex = 3;
            this.Egal3.Text = "=";
            this.Egal3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Egal2
            // 
            this.Egal2.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Egal2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Egal2.Location = new System.Drawing.Point(158, 87);
            this.Egal2.Name = "Egal2";
            this.Egal2.Size = new System.Drawing.Size(77, 81);
            this.Egal2.TabIndex = 3;
            this.Egal2.Text = "=";
            this.Egal2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Egal1
            // 
            this.Egal1.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Egal1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Egal1.Location = new System.Drawing.Point(158, 0);
            this.Egal1.Name = "Egal1";
            this.Egal1.Size = new System.Drawing.Size(77, 76);
            this.Egal1.TabIndex = 3;
            this.Egal1.Text = "=";
            this.Egal1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPoint_Morpion
            // 
            this.labelPoint_Morpion.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPoint_Morpion.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelPoint_Morpion.Location = new System.Drawing.Point(223, 179);
            this.labelPoint_Morpion.Name = "labelPoint_Morpion";
            this.labelPoint_Morpion.Size = new System.Drawing.Size(122, 76);
            this.labelPoint_Morpion.TabIndex = 3;
            this.labelPoint_Morpion.Text = "0";
            this.labelPoint_Morpion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPoint_X
            // 
            this.labelPoint_X.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPoint_X.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelPoint_X.Location = new System.Drawing.Point(223, 0);
            this.labelPoint_X.Name = "labelPoint_X";
            this.labelPoint_X.Size = new System.Drawing.Size(122, 81);
            this.labelPoint_X.TabIndex = 3;
            this.labelPoint_X.Text = "0";
            this.labelPoint_X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPoints_O
            // 
            this.labelPoints_O.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPoints_O.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelPoints_O.Location = new System.Drawing.Point(223, 81);
            this.labelPoints_O.Name = "labelPoints_O";
            this.labelPoints_O.Size = new System.Drawing.Size(122, 100);
            this.labelPoints_O.TabIndex = 3;
            this.labelPoints_O.Text = "0";
            this.labelPoints_O.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureMorpion
            // 
            this.pictureMorpion.ErrorImage = null;
            this.pictureMorpion.Image = global::Jeu_du_Morpion.Properties.Resources.tic_tac_toe_vide;
            this.pictureMorpion.InitialImage = null;
            this.pictureMorpion.Location = new System.Drawing.Point(72, 195);
            this.pictureMorpion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureMorpion.Name = "pictureMorpion";
            this.pictureMorpion.Size = new System.Drawing.Size(60, 60);
            this.pictureMorpion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureMorpion.TabIndex = 2;
            this.pictureMorpion.TabStop = false;
            // 
            // pictureX
            // 
            this.pictureX.BackColor = System.Drawing.SystemColors.Window;
            this.pictureX.ErrorImage = null;
            this.pictureX.Image = global::Jeu_du_Morpion.Properties.Resources.X_tic_tac_toe;
            this.pictureX.InitialImage = null;
            this.pictureX.Location = new System.Drawing.Point(72, 16);
            this.pictureX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureX.Name = "pictureX";
            this.pictureX.Size = new System.Drawing.Size(60, 60);
            this.pictureX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureX.TabIndex = 1;
            this.pictureX.TabStop = false;
            // 
            // pictureO
            // 
            this.pictureO.ErrorImage = null;
            this.pictureO.Image = global::Jeu_du_Morpion.Properties.Resources.O_tic_tac_toe;
            this.pictureO.InitialImage = null;
            this.pictureO.Location = new System.Drawing.Point(72, 108);
            this.pictureO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureO.Name = "pictureO";
            this.pictureO.Size = new System.Drawing.Size(60, 60);
            this.pictureO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureO.TabIndex = 0;
            this.pictureO.TabStop = false;
            // 
            // panelSettings
            // 
            this.panelSettings.Controls.Add(this.label3);
            this.panelSettings.Controls.Add(this.label2);
            this.panelSettings.Controls.Add(this.label1);
            this.panelSettings.Controls.Add(this.BoxReset);
            this.panelSettings.Controls.Add(this.buttonReset);
            this.panelSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSettings.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelSettings.Location = new System.Drawing.Point(511, 291);
            this.panelSettings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSettings.Name = "panelSettings";
            this.panelSettings.Size = new System.Drawing.Size(400, 251);
            this.panelSettings.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Miriam Mono CLM", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(55, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 37);
            this.label3.TabIndex = 21;
            this.label3.Text = "level";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Miriam Mono CLM", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(16, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 37);
            this.label2.TabIndex = 20;
            this.label2.Text = "mode";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Miriam Mono CLM", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(85, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 42);
            this.label1.TabIndex = 19;
            this.label1.Text = "Game Mode:";
            // 
            // BoxReset
            // 
            this.BoxReset.ErrorImage = null;
            this.BoxReset.InitialImage = null;
            this.BoxReset.Location = new System.Drawing.Point(0, 0);
            this.BoxReset.Margin = new System.Windows.Forms.Padding(4);
            this.BoxReset.Name = "BoxReset";
            this.BoxReset.Size = new System.Drawing.Size(13, 12);
            this.BoxReset.TabIndex = 1;
            this.BoxReset.TabStop = false;
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReset.Font = new System.Drawing.Font("Miriam Mono CLM", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonReset.Location = new System.Drawing.Point(23, 174);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(360, 50);
            this.buttonReset.TabIndex = 0;
            this.buttonReset.Text = "Clear Board";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(911, 542);
            this.Controls.Add(this.panelSettings);
            this.Controls.Add(this.panelScore);
            this.Controls.Add(this.panelGame);
            this.Controls.Add(this.panelToolBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jeu du Morpion";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelToolBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureMinimizer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFermer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureIcon)).EndInit();
            this.panelGame.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Box3_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box2_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box1_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box3_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box3_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box2_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box2_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box1_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box1_1)).EndInit();
            this.panelScore.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureMorpion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureO)).EndInit();
            this.panelSettings.ResumeLayout(false);
            this.panelSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BoxReset)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelToolBar;
        private System.Windows.Forms.Panel panelGame;
        private System.Windows.Forms.Panel panelScore;
        private System.Windows.Forms.Panel panelSettings;
        private System.Windows.Forms.PictureBox pictureMinimizer;
        private System.Windows.Forms.PictureBox pictureFermer;
        private System.Windows.Forms.PictureBox pictureIcon;
        private System.Windows.Forms.PictureBox Box3_3;
        private System.Windows.Forms.PictureBox Box2_3;
        private System.Windows.Forms.PictureBox Box3_2;
        private System.Windows.Forms.PictureBox Box3_1;
        private System.Windows.Forms.PictureBox Box2_2;
        private System.Windows.Forms.PictureBox Box2_1;
        private System.Windows.Forms.PictureBox Box1_2;
        private System.Windows.Forms.PictureBox Box1_1;
        private System.Windows.Forms.PictureBox pictureMorpion;
        private System.Windows.Forms.PictureBox pictureX;
        private System.Windows.Forms.PictureBox pictureO;
        private System.Windows.Forms.Label labelPoints_O;
        private System.Windows.Forms.Label Egal3;
        private System.Windows.Forms.Label Egal2;
        private System.Windows.Forms.Label Egal1;
        private System.Windows.Forms.Label labelPoint_Morpion;
        private System.Windows.Forms.Label labelPoint_X;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.PictureBox BoxReset;
        private System.Windows.Forms.PictureBox Box1_3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonNouveauJeu;
        private System.Windows.Forms.Button buttonOptions;
        private System.Windows.Forms.Button buttonAide;
        private System.Windows.Forms.Label label3;
    }
}

