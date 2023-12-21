
namespace Tyuiu.GrigorevKU.Sprint7.Project.V4
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.buttonOK_GKU = new System.Windows.Forms.Button();
            this.pictureBoxIcon_GKU = new System.Windows.Forms.PictureBox();
            this.textBoxAbout_GKU = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon_GKU)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOK_GKU
            // 
            this.buttonOK_GKU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK_GKU.Location = new System.Drawing.Point(525, 317);
            this.buttonOK_GKU.Name = "buttonOK_GKU";
            this.buttonOK_GKU.Size = new System.Drawing.Size(116, 34);
            this.buttonOK_GKU.TabIndex = 0;
            this.buttonOK_GKU.Text = "Ок";
            this.buttonOK_GKU.UseVisualStyleBackColor = true;
            this.buttonOK_GKU.Click += new System.EventHandler(this.buttonOK_GKU_Click);
            // 
            // pictureBoxIcon_GKU
            // 
            this.pictureBoxIcon_GKU.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxIcon_GKU.Image")));
            this.pictureBoxIcon_GKU.Location = new System.Drawing.Point(12, 52);
            this.pictureBoxIcon_GKU.Name = "pictureBoxIcon_GKU";
            this.pictureBoxIcon_GKU.Size = new System.Drawing.Size(237, 217);
            this.pictureBoxIcon_GKU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxIcon_GKU.TabIndex = 1;
            this.pictureBoxIcon_GKU.TabStop = false;
            // 
            // textBoxAbout_GKU
            // 
            this.textBoxAbout_GKU.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxAbout_GKU.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAbout_GKU.Location = new System.Drawing.Point(270, 43);
            this.textBoxAbout_GKU.Multiline = true;
            this.textBoxAbout_GKU.Name = "textBoxAbout_GKU";
            this.textBoxAbout_GKU.ReadOnly = true;
            this.textBoxAbout_GKU.Size = new System.Drawing.Size(329, 267);
            this.textBoxAbout_GKU.TabIndex = 2;
            this.textBoxAbout_GKU.TabStop = false;
            this.textBoxAbout_GKU.Text = resources.GetString("textBoxAbout_GKU.Text");
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 363);
            this.Controls.Add(this.textBoxAbout_GKU);
            this.Controls.Add(this.pictureBoxIcon_GKU);
            this.Controls.Add(this.buttonOK_GKU);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon_GKU)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK_GKU;
        private System.Windows.Forms.PictureBox pictureBoxIcon_GKU;
        private System.Windows.Forms.TextBox textBoxAbout_GKU;
    }
}