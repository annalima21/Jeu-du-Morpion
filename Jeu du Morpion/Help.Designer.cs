namespace Jeu_du_Morpion
{
    partial class Help
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
            this.panelToolBar = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.pictureMinimizer = new System.Windows.Forms.PictureBox();
            this.pictureFermer = new System.Windows.Forms.PictureBox();
            this.pictureIcon = new System.Windows.Forms.PictureBox();
            this.panelToolBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMinimizer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFermer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panelToolBar
            // 
            this.panelToolBar.BackColor = System.Drawing.Color.DarkBlue;
            this.panelToolBar.Controls.Add(this.pictureMinimizer);
            this.panelToolBar.Controls.Add(this.pictureFermer);
            this.panelToolBar.Controls.Add(this.pictureIcon);
            this.panelToolBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelToolBar.Location = new System.Drawing.Point(0, 0);
            this.panelToolBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelToolBar.Name = "panelToolBar";
            this.panelToolBar.Size = new System.Drawing.Size(800, 30);
            this.panelToolBar.TabIndex = 2;
            this.panelToolBar.Paint += new System.Windows.Forms.PaintEventHandler(this.panelToolBar_Paint);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(26, 59);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(745, 311);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReset.Font = new System.Drawing.Font("Miriam Mono CLM", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonReset.Location = new System.Drawing.Point(340, 389);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(106, 35);
            this.buttonReset.TabIndex = 30;
            this.buttonReset.Text = "OK";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // pictureMinimizer
            // 
            this.pictureMinimizer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureMinimizer.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureMinimizer.ErrorImage = null;
            this.pictureMinimizer.Image = global::Jeu_du_Morpion.Properties.Resources.minimizar;
            this.pictureMinimizer.InitialImage = null;
            this.pictureMinimizer.Location = new System.Drawing.Point(742, 0);
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
            this.pictureFermer.Location = new System.Drawing.Point(771, 0);
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
            // Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.panelToolBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Help";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Help";
            this.panelToolBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureMinimizer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFermer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelToolBar;
        private System.Windows.Forms.PictureBox pictureMinimizer;
        private System.Windows.Forms.PictureBox pictureFermer;
        private System.Windows.Forms.PictureBox pictureIcon;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button buttonReset;
    }
}