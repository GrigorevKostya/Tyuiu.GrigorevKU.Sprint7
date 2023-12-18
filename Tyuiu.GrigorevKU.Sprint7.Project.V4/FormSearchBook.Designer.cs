
namespace Tyuiu.GrigorevKU.Sprint7.Project.V4
{
    partial class FormSearchBook
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
            this.buttonAddNewBook_GKU = new System.Windows.Forms.Button();
            this.labelIsBookNew_GKU = new System.Windows.Forms.Label();
            this.labelArticle_GKU = new System.Windows.Forms.Label();
            this.comboBoxIsBookNew_GKU = new System.Windows.Forms.ComboBox();
            this.textBoxBookSearch_GKU = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonAddNewBook_GKU
            // 
            this.buttonAddNewBook_GKU.Location = new System.Drawing.Point(500, 152);
            this.buttonAddNewBook_GKU.Name = "buttonAddNewBook_GKU";
            this.buttonAddNewBook_GKU.Size = new System.Drawing.Size(147, 42);
            this.buttonAddNewBook_GKU.TabIndex = 24;
            this.buttonAddNewBook_GKU.Text = "Найти";
            this.buttonAddNewBook_GKU.UseVisualStyleBackColor = true;
            this.buttonAddNewBook_GKU.Click += new System.EventHandler(this.buttonAddNewBook_GKU_Click);
            // 
            // labelIsBookNew_GKU
            // 
            this.labelIsBookNew_GKU.AutoSize = true;
            this.labelIsBookNew_GKU.Location = new System.Drawing.Point(363, 57);
            this.labelIsBookNew_GKU.Name = "labelIsBookNew_GKU";
            this.labelIsBookNew_GKU.Size = new System.Drawing.Size(58, 17);
            this.labelIsBookNew_GKU.TabIndex = 22;
            this.labelIsBookNew_GKU.Text = "Искать:";
            // 
            // labelArticle_GKU
            // 
            this.labelArticle_GKU.AutoSize = true;
            this.labelArticle_GKU.Location = new System.Drawing.Point(13, 57);
            this.labelArticle_GKU.Name = "labelArticle_GKU";
            this.labelArticle_GKU.Size = new System.Drawing.Size(72, 17);
            this.labelArticle_GKU.TabIndex = 17;
            this.labelArticle_GKU.Text = "Поиск по:";
            // 
            // comboBoxIsBookNew_GKU
            // 
            this.comboBoxIsBookNew_GKU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIsBookNew_GKU.FormattingEnabled = true;
            this.comboBoxIsBookNew_GKU.Items.AddRange(new object[] {
            "артикулу",
            "названию",
            "автору",
            "дате издания",
            "жанру",
            "аннотации"});
            this.comboBoxIsBookNew_GKU.Location = new System.Drawing.Point(85, 54);
            this.comboBoxIsBookNew_GKU.Name = "comboBoxIsBookNew_GKU";
            this.comboBoxIsBookNew_GKU.Size = new System.Drawing.Size(220, 24);
            this.comboBoxIsBookNew_GKU.TabIndex = 16;
            this.comboBoxIsBookNew_GKU.TabStop = false;
            // 
            // textBoxBookSearch_GKU
            // 
            this.textBoxBookSearch_GKU.Location = new System.Drawing.Point(427, 54);
            this.textBoxBookSearch_GKU.Name = "textBoxBookSearch_GKU";
            this.textBoxBookSearch_GKU.Size = new System.Drawing.Size(220, 22);
            this.textBoxBookSearch_GKU.TabIndex = 15;
            // 
            // FormSearchBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 206);
            this.Controls.Add(this.buttonAddNewBook_GKU);
            this.Controls.Add(this.labelIsBookNew_GKU);
            this.Controls.Add(this.labelArticle_GKU);
            this.Controls.Add(this.comboBoxIsBookNew_GKU);
            this.Controls.Add(this.textBoxBookSearch_GKU);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSearchBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Найти книгу";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddNewBook_GKU;
        private System.Windows.Forms.Label labelIsBookNew_GKU;
        private System.Windows.Forms.Label labelArticle_GKU;
        private System.Windows.Forms.ComboBox comboBoxIsBookNew_GKU;
        private System.Windows.Forms.TextBox textBoxBookSearch_GKU;
    }
}