namespace Jeu_du_Morpion
{
    partial class Options
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.buttonMode = new System.Windows.Forms.Button();
            this.panelToolBar = new System.Windows.Forms.Panel();
            this.pictureMinimizer = new System.Windows.Forms.PictureBox();
            this.pictureFermer = new System.Windows.Forms.PictureBox();
            this.pictureIcon = new System.Windows.Forms.PictureBox();
            this.buttonChoiceX = new System.Windows.Forms.Button();
            this.buttonChoiceO = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.BoxChoixO = new System.Windows.Forms.PictureBox();
            this.BoxChoixX = new System.Windows.Forms.PictureBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.panelToolBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMinimizer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFermer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoxChoixO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoxChoixX)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Miriam Mono CLM", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(31, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 34);
            this.label1.TabIndex = 22;
            this.label1.Text = "Game Mode:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Miriam Mono CLM", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.checkBox1.Location = new System.Drawing.Point(52, 80);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(146, 30);
            this.checkBox1.TabIndex = 20;
            this.checkBox1.Text = "1x1(PvP)";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Miriam Mono CLM", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.checkBox2.Location = new System.Drawing.Point(52, 106);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(174, 30);
            this.checkBox2.TabIndex = 21;
            this.checkBox2.Text = "1xCOM(PvC)";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Miriam Mono CLM", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(6, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 34);
            this.label2.TabIndex = 23;
            this.label2.Text = "Computer Mode";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Miriam Mono CLM", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.checkBox3.Location = new System.Drawing.Point(68, 173);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(90, 30);
            this.checkBox3.TabIndex = 24;
            this.checkBox3.Text = "Easy";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("Miriam Mono CLM", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.checkBox4.Location = new System.Drawing.Point(68, 199);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(118, 30);
            this.checkBox4.TabIndex = 25;
            this.checkBox4.Text = "Medium";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Font = new System.Drawing.Font("Miriam Mono CLM", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.checkBox6.Location = new System.Drawing.Point(68, 249);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(118, 30);
            this.checkBox6.TabIndex = 27;
            this.checkBox6.Text = "Insane";
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // buttonMode
            // 
            this.buttonMode.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonMode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMode.Font = new System.Drawing.Font("Miriam Mono CLM", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonMode.Location = new System.Drawing.Point(72, 441);
            this.buttonMode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonMode.Name = "buttonMode";
            this.buttonMode.Size = new System.Drawing.Size(106, 35);
            this.buttonMode.TabIndex = 29;
            this.buttonMode.Text = "Apply";
            this.buttonMode.UseVisualStyleBackColor = false;
            this.buttonMode.Click += new System.EventHandler(this.buttonMode_Click_1);
            // 
            // panelToolBar
            // 
            this.panelToolBar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelToolBar.Controls.Add(this.pictureMinimizer);
            this.panelToolBar.Controls.Add(this.pictureFermer);
            this.panelToolBar.Controls.Add(this.pictureIcon);
            this.panelToolBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelToolBar.Location = new System.Drawing.Point(0, 0);
            this.panelToolBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelToolBar.Name = "panelToolBar";
            this.panelToolBar.Size = new System.Drawing.Size(263, 30);
            this.panelToolBar.TabIndex = 30;
            // 
            // pictureMinimizer
            // 
            this.pictureMinimizer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureMinimizer.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureMinimizer.ErrorImage = null;
            this.pictureMinimizer.Image = global::Jeu_du_Morpion.Properties.Resources.minimizar;
            this.pictureMinimizer.InitialImage = null;
            this.pictureMinimizer.Location = new System.Drawing.Point(205, 0);
            this.pictureMinimizer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureMinimizer.Name = "pictureMinimizer";
            this.pictureMinimizer.Size = new System.Drawing.Size(29, 30);
            this.pictureMinimizer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureMinimizer.TabIndex = 2;
            this.pictureMinimizer.TabStop = false;
            // 
            // pictureFermer
            // 
            this.pictureFermer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureFermer.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureFermer.ErrorImage = null;
            this.pictureFermer.Image = global::Jeu_du_Morpion.Properties.Resources.Capture;
            this.pictureFermer.InitialImage = null;
            this.pictureFermer.Location = new System.Drawing.Point(234, 0);
            this.pictureFermer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureFermer.Name = "pictureFermer";
            this.pictureFermer.Size = new System.Drawing.Size(29, 30);
            this.pictureFermer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureFermer.TabIndex = 1;
            this.pictureFermer.TabStop = false;
            this.pictureFermer.Click += new System.EventHandler(this.pictureFermer_Click_1);
            // 
            // pictureIcon
            // 
            this.pictureIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureIcon.ErrorImage = null;
            this.pictureIcon.Image = global::Jeu_du_Morpion.Properties.Resources.tic_tac_toe_ico;
            this.pictureIcon.InitialImage = null;
            this.pictureIcon.Location = new System.Drawing.Point(0, 0);
            this.pictureIcon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureIcon.Name = "pictureIcon";
            this.pictureIcon.Size = new System.Drawing.Size(29, 30);
            this.pictureIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureIcon.TabIndex = 0;
            this.pictureIcon.TabStop = false;
            // 
            // buttonChoiceX
            // 
            this.buttonChoiceX.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonChoiceX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonChoiceX.Font = new System.Drawing.Font("Miriam Mono CLM", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonChoiceX.Location = new System.Drawing.Point(52, 325);
            this.buttonChoiceX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonChoiceX.Name = "buttonChoiceX";
            this.buttonChoiceX.Size = new System.Drawing.Size(35, 35);
            this.buttonChoiceX.TabIndex = 31;
            this.buttonChoiceX.Text = "X";
            this.buttonChoiceX.UseVisualStyleBackColor = false;
            this.buttonChoiceX.Click += new System.EventHandler(this.buttonChoiceX_Click);
            // 
            // buttonChoiceO
            // 
            this.buttonChoiceO.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonChoiceO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonChoiceO.Font = new System.Drawing.Font("Miriam Mono CLM", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonChoiceO.Location = new System.Drawing.Point(172, 325);
            this.buttonChoiceO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonChoiceO.Name = "buttonChoiceO";
            this.buttonChoiceO.Size = new System.Drawing.Size(35, 35);
            this.buttonChoiceO.TabIndex = 32;
            this.buttonChoiceO.Text = "O";
            this.buttonChoiceO.UseVisualStyleBackColor = false;
            this.buttonChoiceO.Click += new System.EventHandler(this.buttonChoiceO_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Miriam Mono CLM", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(6, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(249, 34);
            this.label3.TabIndex = 33;
            this.label3.Text = "Icones Jouers";
            // 
            // BoxChoixO
            // 
            this.BoxChoixO.BackColor = System.Drawing.SystemColors.Control;
            this.BoxChoixO.ErrorImage = null;
            this.BoxChoixO.Image = global::Jeu_du_Morpion.Properties.Resources.O_tic_tac_toe;
            this.BoxChoixO.InitialImage = null;
            this.BoxChoixO.Location = new System.Drawing.Point(158, 365);
            this.BoxChoixO.Name = "BoxChoixO";
            this.BoxChoixO.Size = new System.Drawing.Size(60, 60);
            this.BoxChoixO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BoxChoixO.TabIndex = 35;
            this.BoxChoixO.TabStop = false;
            // 
            // BoxChoixX
            // 
            this.BoxChoixX.BackColor = System.Drawing.SystemColors.Control;
            this.BoxChoixX.ErrorImage = null;
            this.BoxChoixX.Image = global::Jeu_du_Morpion.Properties.Resources.X_tic_tac_toe;
            this.BoxChoixX.InitialImage = null;
            this.BoxChoixX.Location = new System.Drawing.Point(37, 365);
            this.BoxChoixX.Name = "BoxChoixX";
            this.BoxChoixX.Size = new System.Drawing.Size(60, 60);
            this.BoxChoixX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BoxChoixX.TabIndex = 34;
            this.BoxChoixX.TabStop = false;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Font = new System.Drawing.Font("Miriam Mono CLM", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.checkBox5.Location = new System.Drawing.Point(68, 224);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(90, 30);
            this.checkBox5.TabIndex = 36;
            this.checkBox5.Text = "Hard";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 495);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.BoxChoixO);
            this.Controls.Add(this.BoxChoixX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonChoiceO);
            this.Controls.Add(this.buttonChoiceX);
            this.Controls.Add(this.panelToolBar);
            this.Controls.Add(this.buttonMode);
            this.Controls.Add(this.checkBox6);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.checkBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Options";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options";
            this.panelToolBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureMinimizer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFermer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoxChoixO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoxChoixX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.Button buttonMode;
        private System.Windows.Forms.Panel panelToolBar;
        private System.Windows.Forms.PictureBox pictureMinimizer;
        private System.Windows.Forms.PictureBox pictureFermer;
        private System.Windows.Forms.PictureBox pictureIcon;
        private System.Windows.Forms.Button buttonChoiceX;
        private System.Windows.Forms.Button buttonChoiceO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox BoxChoixX;
        private System.Windows.Forms.PictureBox BoxChoixO;
        private System.Windows.Forms.CheckBox checkBox5;
    }
}