namespace Jeu_du_Morpion
{
    partial class NewGame
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureIcon = new System.Windows.Forms.PictureBox();
            this.buttonNo = new System.Windows.Forms.Button();
            this.buttonYes = new System.Windows.Forms.Button();
            this.labelNewGame = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.Controls.Add(this.pictureIcon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 30);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureIcon
            // 
            this.pictureIcon.BackColor = System.Drawing.Color.GhostWhite;
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
            // buttonNo
            // 
            this.buttonNo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonNo.Font = new System.Drawing.Font("Miriam Mono CLM", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonNo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonNo.Location = new System.Drawing.Point(41, 148);
            this.buttonNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonNo.Name = "buttonNo";
            this.buttonNo.Size = new System.Drawing.Size(117, 48);
            this.buttonNo.TabIndex = 6;
            this.buttonNo.Text = "NO";
            this.buttonNo.UseVisualStyleBackColor = false;
            this.buttonNo.Click += new System.EventHandler(this.buttonNo_Click);
            // 
            // buttonYes
            // 
            this.buttonYes.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonYes.Font = new System.Drawing.Font("Miriam Mono CLM", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonYes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonYes.Location = new System.Drawing.Point(211, 148);
            this.buttonYes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonYes.Name = "buttonYes";
            this.buttonYes.Size = new System.Drawing.Size(117, 48);
            this.buttonYes.TabIndex = 7;
            this.buttonYes.Text = "YES";
            this.buttonYes.UseVisualStyleBackColor = false;
            this.buttonYes.Click += new System.EventHandler(this.buttonYes_Click);
            // 
            // labelNewGame
            // 
            this.labelNewGame.AutoSize = true;
            this.labelNewGame.Font = new System.Drawing.Font("Miriam Mono CLM", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelNewGame.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.labelNewGame.Location = new System.Drawing.Point(67, 65);
            this.labelNewGame.Name = "labelNewGame";
            this.labelNewGame.Size = new System.Drawing.Size(235, 44);
            this.labelNewGame.TabIndex = 8;
            this.labelNewGame.Text = "New Game?";
            this.labelNewGame.Click += new System.EventHandler(this.labelNewGame_Click);
            // 
            // NewGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 220);
            this.Controls.Add(this.labelNewGame);
            this.Controls.Add(this.buttonYes);
            this.Controls.Add(this.buttonNo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NewGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewGame";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureIcon;
        private System.Windows.Forms.Button buttonNo;
        private System.Windows.Forms.Button buttonYes;
        private System.Windows.Forms.Label labelNewGame;
    }
}