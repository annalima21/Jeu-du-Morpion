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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureMinimizer = new System.Windows.Forms.PictureBox();
            this.pictureFermer = new System.Windows.Forms.PictureBox();
            this.pictureIcon = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Box3_3 = new System.Windows.Forms.PictureBox();
            this.Box2_3 = new System.Windows.Forms.PictureBox();
            this.Box1_3 = new System.Windows.Forms.PictureBox();
            this.Box3_2 = new System.Windows.Forms.PictureBox();
            this.Box3_1 = new System.Windows.Forms.PictureBox();
            this.Box2_2 = new System.Windows.Forms.PictureBox();
            this.Box2_1 = new System.Windows.Forms.PictureBox();
            this.Box1_2 = new System.Windows.Forms.PictureBox();
            this.Box1_1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Egal3 = new System.Windows.Forms.Label();
            this.Egal2 = new System.Windows.Forms.Label();
            this.Egal1 = new System.Windows.Forms.Label();
            this.labelPoint_Morpion = new System.Windows.Forms.Label();
            this.labelPoint_X = new System.Windows.Forms.Label();
            this.labelPoints_O = new System.Windows.Forms.Label();
            this.pictureMorpion = new System.Windows.Forms.PictureBox();
            this.pictureX = new System.Windows.Forms.PictureBox();
            this.pictureO = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonNouveauJeu = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMinimizer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFermer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureIcon)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Box3_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box2_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box1_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box3_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box3_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box2_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box2_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box1_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box1_1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMorpion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureO)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.pictureMinimizer);
            this.panel1.Controls.Add(this.pictureFermer);
            this.panel1.Controls.Add(this.pictureIcon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(911, 30);
            this.panel1.TabIndex = 0;
            // 
            // pictureMinimizer
            // 
            this.pictureMinimizer.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureMinimizer.ErrorImage = null;
            this.pictureMinimizer.Image = global::Jeu_du_Morpion.Properties.Resources.minimizar;
            this.pictureMinimizer.InitialImage = null;
            this.pictureMinimizer.Location = new System.Drawing.Point(851, 0);
            this.pictureMinimizer.Name = "pictureMinimizer";
            this.pictureMinimizer.Size = new System.Drawing.Size(30, 30);
            this.pictureMinimizer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureMinimizer.TabIndex = 2;
            this.pictureMinimizer.TabStop = false;
            // 
            // pictureFermer
            // 
            this.pictureFermer.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureFermer.ErrorImage = null;
            this.pictureFermer.Image = global::Jeu_du_Morpion.Properties.Resources.Capture;
            this.pictureFermer.InitialImage = null;
            this.pictureFermer.Location = new System.Drawing.Point(881, 0);
            this.pictureFermer.Name = "pictureFermer";
            this.pictureFermer.Size = new System.Drawing.Size(30, 30);
            this.pictureFermer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureFermer.TabIndex = 1;
            this.pictureFermer.TabStop = false;
            // 
            // pictureIcon
            // 
            this.pictureIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureIcon.ErrorImage = null;
            this.pictureIcon.Image = global::Jeu_du_Morpion.Properties.Resources.tic_tac_toe_ico;
            this.pictureIcon.InitialImage = null;
            this.pictureIcon.Location = new System.Drawing.Point(0, 0);
            this.pictureIcon.Name = "pictureIcon";
            this.pictureIcon.Size = new System.Drawing.Size(30, 30);
            this.pictureIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureIcon.TabIndex = 0;
            this.pictureIcon.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Box3_3);
            this.panel2.Controls.Add(this.Box2_3);
            this.panel2.Controls.Add(this.Box1_3);
            this.panel2.Controls.Add(this.Box3_2);
            this.panel2.Controls.Add(this.Box3_1);
            this.panel2.Controls.Add(this.Box2_2);
            this.panel2.Controls.Add(this.Box2_1);
            this.panel2.Controls.Add(this.Box1_2);
            this.panel2.Controls.Add(this.Box1_1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(511, 511);
            this.panel2.TabIndex = 1;
            // 
            // Box3_3
            // 
            this.Box3_3.BackColor = System.Drawing.SystemColors.Control;
            this.Box3_3.ErrorImage = null;
            this.Box3_3.InitialImage = null;
            this.Box3_3.Location = new System.Drawing.Point(343, 342);
            this.Box3_3.Name = "Box3_3";
            this.Box3_3.Size = new System.Drawing.Size(161, 161);
            this.Box3_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Box3_3.TabIndex = 0;
            this.Box3_3.TabStop = false;
            // 
            // Box2_3
            // 
            this.Box2_3.BackColor = System.Drawing.SystemColors.Control;
            this.Box2_3.ErrorImage = null;
            this.Box2_3.InitialImage = null;
            this.Box2_3.Location = new System.Drawing.Point(343, 175);
            this.Box2_3.Name = "Box2_3";
            this.Box2_3.Size = new System.Drawing.Size(161, 161);
            this.Box2_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Box2_3.TabIndex = 0;
            this.Box2_3.TabStop = false;
            // 
            // Box1_3
            // 
            this.Box1_3.BackColor = System.Drawing.SystemColors.Control;
            this.Box1_3.ErrorImage = null;
            this.Box1_3.InitialImage = null;
            this.Box1_3.Location = new System.Drawing.Point(343, 8);
            this.Box1_3.Name = "Box1_3";
            this.Box1_3.Size = new System.Drawing.Size(161, 161);
            this.Box1_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Box1_3.TabIndex = 0;
            this.Box1_3.TabStop = false;
            // 
            // Box3_2
            // 
            this.Box3_2.BackColor = System.Drawing.SystemColors.Control;
            this.Box3_2.ErrorImage = null;
            this.Box3_2.InitialImage = null;
            this.Box3_2.Location = new System.Drawing.Point(176, 342);
            this.Box3_2.Name = "Box3_2";
            this.Box3_2.Size = new System.Drawing.Size(161, 161);
            this.Box3_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Box3_2.TabIndex = 0;
            this.Box3_2.TabStop = false;
            // 
            // Box3_1
            // 
            this.Box3_1.BackColor = System.Drawing.SystemColors.Control;
            this.Box3_1.ErrorImage = null;
            this.Box3_1.InitialImage = null;
            this.Box3_1.Location = new System.Drawing.Point(9, 342);
            this.Box3_1.Name = "Box3_1";
            this.Box3_1.Size = new System.Drawing.Size(161, 161);
            this.Box3_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Box3_1.TabIndex = 0;
            this.Box3_1.TabStop = false;
            // 
            // Box2_2
            // 
            this.Box2_2.BackColor = System.Drawing.SystemColors.Control;
            this.Box2_2.ErrorImage = null;
            this.Box2_2.InitialImage = null;
            this.Box2_2.Location = new System.Drawing.Point(176, 175);
            this.Box2_2.Name = "Box2_2";
            this.Box2_2.Size = new System.Drawing.Size(161, 161);
            this.Box2_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Box2_2.TabIndex = 0;
            this.Box2_2.TabStop = false;
            // 
            // Box2_1
            // 
            this.Box2_1.BackColor = System.Drawing.SystemColors.Control;
            this.Box2_1.ErrorImage = null;
            this.Box2_1.InitialImage = null;
            this.Box2_1.Location = new System.Drawing.Point(9, 175);
            this.Box2_1.Name = "Box2_1";
            this.Box2_1.Size = new System.Drawing.Size(161, 161);
            this.Box2_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Box2_1.TabIndex = 0;
            this.Box2_1.TabStop = false;
            // 
            // Box1_2
            // 
            this.Box1_2.BackColor = System.Drawing.SystemColors.Control;
            this.Box1_2.ErrorImage = null;
            this.Box1_2.InitialImage = null;
            this.Box1_2.Location = new System.Drawing.Point(176, 8);
            this.Box1_2.Name = "Box1_2";
            this.Box1_2.Size = new System.Drawing.Size(161, 161);
            this.Box1_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Box1_2.TabIndex = 0;
            this.Box1_2.TabStop = false;
            // 
            // Box1_1
            // 
            this.Box1_1.BackColor = System.Drawing.SystemColors.Control;
            this.Box1_1.ErrorImage = null;
            this.Box1_1.InitialImage = null;
            this.Box1_1.Location = new System.Drawing.Point(9, 8);
            this.Box1_1.Name = "Box1_1";
            this.Box1_1.Size = new System.Drawing.Size(161, 161);
            this.Box1_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Box1_1.TabIndex = 0;
            this.Box1_1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Egal3);
            this.panel3.Controls.Add(this.Egal2);
            this.panel3.Controls.Add(this.Egal1);
            this.panel3.Controls.Add(this.labelPoint_Morpion);
            this.panel3.Controls.Add(this.labelPoint_X);
            this.panel3.Controls.Add(this.labelPoints_O);
            this.panel3.Controls.Add(this.pictureMorpion);
            this.panel3.Controls.Add(this.pictureX);
            this.panel3.Controls.Add(this.pictureO);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(511, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(400, 351);
            this.panel3.TabIndex = 2;
            // 
            // Egal3
            // 
            this.Egal3.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Egal3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Egal3.Location = new System.Drawing.Point(116, 242);
            this.Egal3.Name = "Egal3";
            this.Egal3.Size = new System.Drawing.Size(150, 100);
            this.Egal3.TabIndex = 3;
            this.Egal3.Text = "=";
            this.Egal3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Egal2
            // 
            this.Egal2.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Egal2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Egal2.Location = new System.Drawing.Point(116, 129);
            this.Egal2.Name = "Egal2";
            this.Egal2.Size = new System.Drawing.Size(150, 100);
            this.Egal2.TabIndex = 3;
            this.Egal2.Text = "=";
            this.Egal2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Egal1
            // 
            this.Egal1.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Egal1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Egal1.Location = new System.Drawing.Point(116, 11);
            this.Egal1.Name = "Egal1";
            this.Egal1.Size = new System.Drawing.Size(150, 100);
            this.Egal1.TabIndex = 3;
            this.Egal1.Text = "=";
            this.Egal1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPoint_Morpion
            // 
            this.labelPoint_Morpion.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPoint_Morpion.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelPoint_Morpion.Location = new System.Drawing.Point(238, 242);
            this.labelPoint_Morpion.Name = "labelPoint_Morpion";
            this.labelPoint_Morpion.Size = new System.Drawing.Size(150, 100);
            this.labelPoint_Morpion.TabIndex = 3;
            this.labelPoint_Morpion.Text = "0";
            this.labelPoint_Morpion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPoint_X
            // 
            this.labelPoint_X.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPoint_X.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelPoint_X.Location = new System.Drawing.Point(238, 129);
            this.labelPoint_X.Name = "labelPoint_X";
            this.labelPoint_X.Size = new System.Drawing.Size(150, 100);
            this.labelPoint_X.TabIndex = 3;
            this.labelPoint_X.Text = "0";
            this.labelPoint_X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPoints_O
            // 
            this.labelPoints_O.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPoints_O.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelPoints_O.Location = new System.Drawing.Point(238, 11);
            this.labelPoints_O.Name = "labelPoints_O";
            this.labelPoints_O.Size = new System.Drawing.Size(150, 100);
            this.labelPoints_O.TabIndex = 3;
            this.labelPoints_O.Text = "0";
            this.labelPoints_O.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureMorpion
            // 
            this.pictureMorpion.ErrorImage = null;
            this.pictureMorpion.Image = global::Jeu_du_Morpion.Properties.Resources.tic_tac_toe_ico;
            this.pictureMorpion.InitialImage = null;
            this.pictureMorpion.Location = new System.Drawing.Point(10, 242);
            this.pictureMorpion.Name = "pictureMorpion";
            this.pictureMorpion.Size = new System.Drawing.Size(100, 100);
            this.pictureMorpion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureMorpion.TabIndex = 2;
            this.pictureMorpion.TabStop = false;
            // 
            // pictureX
            // 
            this.pictureX.ErrorImage = null;
            this.pictureX.Image = global::Jeu_du_Morpion.Properties.Resources.X_tic_tac_toe;
            this.pictureX.InitialImage = null;
            this.pictureX.Location = new System.Drawing.Point(10, 129);
            this.pictureX.Name = "pictureX";
            this.pictureX.Size = new System.Drawing.Size(100, 100);
            this.pictureX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureX.TabIndex = 1;
            this.pictureX.TabStop = false;
            // 
            // pictureO
            // 
            this.pictureO.ErrorImage = null;
            this.pictureO.Image = global::Jeu_du_Morpion.Properties.Resources.O_tic_tac_toe;
            this.pictureO.InitialImage = null;
            this.pictureO.Location = new System.Drawing.Point(10, 11);
            this.pictureO.Name = "pictureO";
            this.pictureO.Size = new System.Drawing.Size(100, 100);
            this.pictureO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureO.TabIndex = 0;
            this.pictureO.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.buttonReset);
            this.panel4.Controls.Add(this.buttonNouveauJeu);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(511, 381);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(400, 160);
            this.panel4.TabIndex = 3;
            // 
            // buttonReset
            // 
            this.buttonReset.Font = new System.Drawing.Font("Miriam Mono CLM", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.Location = new System.Drawing.Point(20, 88);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(360, 50);
            this.buttonReset.TabIndex = 0;
            this.buttonReset.Text = "Redemarrer";
            this.buttonReset.UseVisualStyleBackColor = true;
            // 
            // buttonNouveauJeu
            // 
            this.buttonNouveauJeu.Font = new System.Drawing.Font("Miriam Mono CLM", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNouveauJeu.Location = new System.Drawing.Point(20, 22);
            this.buttonNouveauJeu.Name = "buttonNouveauJeu";
            this.buttonNouveauJeu.Size = new System.Drawing.Size(360, 50);
            this.buttonNouveauJeu.TabIndex = 0;
            this.buttonNouveauJeu.Text = "Nouveau Jeu";
            this.buttonNouveauJeu.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(911, 541);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jeu du Morpion";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureMinimizer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFermer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureIcon)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Box3_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box2_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box1_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box3_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box3_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box2_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box2_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box1_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box1_1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureMorpion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureO)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureMinimizer;
        private System.Windows.Forms.PictureBox pictureFermer;
        private System.Windows.Forms.PictureBox pictureIcon;
        private System.Windows.Forms.PictureBox Box3_3;
        private System.Windows.Forms.PictureBox Box2_3;
        private System.Windows.Forms.PictureBox Box1_3;
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
        private System.Windows.Forms.Button buttonNouveauJeu;
    }
}

