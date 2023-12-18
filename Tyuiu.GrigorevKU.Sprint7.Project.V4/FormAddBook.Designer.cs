
namespace Tyuiu.GrigorevKU.Sprint7.Project.V4
{
    partial class FormAddBook
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
            this.textBoxBookArticle_GKU = new System.Windows.Forms.TextBox();
            this.textBoxBookName_GKU = new System.Windows.Forms.TextBox();
            this.textBoxBookAuthor_GKU = new System.Windows.Forms.TextBox();
            this.textBoxBookYear_GKU = new System.Windows.Forms.TextBox();
            this.textBoxBookGenre_GKU = new System.Windows.Forms.TextBox();
            this.textBoxBookAnnotation_GKU = new System.Windows.Forms.TextBox();
            this.comboBoxIsBookNew_GKU = new System.Windows.Forms.ComboBox();
            this.labelArticle_GKU = new System.Windows.Forms.Label();
            this.labelBook_Name = new System.Windows.Forms.Label();
            this.labelAuthor_GKU = new System.Windows.Forms.Label();
            this.labelYear_GKU = new System.Windows.Forms.Label();
            this.labelGenre_GKU = new System.Windows.Forms.Label();
            this.labelIsBookNew_GKU = new System.Windows.Forms.Label();
            this.labelAnnotation_GKU = new System.Windows.Forms.Label();
            this.buttonAddNewBook_GKU = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxBookArticle_GKU
            // 
            this.textBoxBookArticle_GKU.Location = new System.Drawing.Point(124, 24);
            this.textBoxBookArticle_GKU.Name = "textBoxBookArticle_GKU";
            this.textBoxBookArticle_GKU.Size = new System.Drawing.Size(220, 22);
            this.textBoxBookArticle_GKU.TabIndex = 0;
            // 
            // textBoxBookName_GKU
            // 
            this.textBoxBookName_GKU.Location = new System.Drawing.Point(124, 73);
            this.textBoxBookName_GKU.Name = "textBoxBookName_GKU";
            this.textBoxBookName_GKU.Size = new System.Drawing.Size(220, 22);
            this.textBoxBookName_GKU.TabIndex = 0;
            // 
            // textBoxBookAuthor_GKU
            // 
            this.textBoxBookAuthor_GKU.Location = new System.Drawing.Point(124, 128);
            this.textBoxBookAuthor_GKU.Name = "textBoxBookAuthor_GKU";
            this.textBoxBookAuthor_GKU.Size = new System.Drawing.Size(220, 22);
            this.textBoxBookAuthor_GKU.TabIndex = 0;
            // 
            // textBoxBookYear_GKU
            // 
            this.textBoxBookYear_GKU.Location = new System.Drawing.Point(124, 190);
            this.textBoxBookYear_GKU.Name = "textBoxBookYear_GKU";
            this.textBoxBookYear_GKU.Size = new System.Drawing.Size(220, 22);
            this.textBoxBookYear_GKU.TabIndex = 0;
            // 
            // textBoxBookGenre_GKU
            // 
            this.textBoxBookGenre_GKU.Location = new System.Drawing.Point(124, 252);
            this.textBoxBookGenre_GKU.Name = "textBoxBookGenre_GKU";
            this.textBoxBookGenre_GKU.Size = new System.Drawing.Size(220, 22);
            this.textBoxBookGenre_GKU.TabIndex = 0;
            // 
            // textBoxBookAnnotation_GKU
            // 
            this.textBoxBookAnnotation_GKU.Location = new System.Drawing.Point(124, 376);
            this.textBoxBookAnnotation_GKU.Name = "textBoxBookAnnotation_GKU";
            this.textBoxBookAnnotation_GKU.Size = new System.Drawing.Size(220, 22);
            this.textBoxBookAnnotation_GKU.TabIndex = 0;
            // 
            // comboBoxIsBookNew_GKU
            // 
            this.comboBoxIsBookNew_GKU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIsBookNew_GKU.FormattingEnabled = true;
            this.comboBoxIsBookNew_GKU.Items.AddRange(new object[] {
            "да",
            "нет"});
            this.comboBoxIsBookNew_GKU.Location = new System.Drawing.Point(124, 316);
            this.comboBoxIsBookNew_GKU.Name = "comboBoxIsBookNew_GKU";
            this.comboBoxIsBookNew_GKU.Size = new System.Drawing.Size(220, 24);
            this.comboBoxIsBookNew_GKU.TabIndex = 1;
            this.comboBoxIsBookNew_GKU.TabStop = false;
            this.comboBoxIsBookNew_GKU.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelArticle_GKU
            // 
            this.labelArticle_GKU.AutoSize = true;
            this.labelArticle_GKU.Location = new System.Drawing.Point(52, 27);
            this.labelArticle_GKU.Name = "labelArticle_GKU";
            this.labelArticle_GKU.Size = new System.Drawing.Size(66, 17);
            this.labelArticle_GKU.TabIndex = 2;
            this.labelArticle_GKU.Text = "Артикул:";
            // 
            // labelBook_Name
            // 
            this.labelBook_Name.AutoSize = true;
            this.labelBook_Name.Location = new System.Drawing.Point(42, 76);
            this.labelBook_Name.Name = "labelBook_Name";
            this.labelBook_Name.Size = new System.Drawing.Size(76, 17);
            this.labelBook_Name.TabIndex = 3;
            this.labelBook_Name.Text = "Название:";
            // 
            // labelAuthor_GKU
            // 
            this.labelAuthor_GKU.AutoSize = true;
            this.labelAuthor_GKU.Location = new System.Drawing.Point(67, 128);
            this.labelAuthor_GKU.Name = "labelAuthor_GKU";
            this.labelAuthor_GKU.Size = new System.Drawing.Size(51, 17);
            this.labelAuthor_GKU.TabIndex = 4;
            this.labelAuthor_GKU.Text = "Автор:";
            // 
            // labelYear_GKU
            // 
            this.labelYear_GKU.AutoSize = true;
            this.labelYear_GKU.Location = new System.Drawing.Point(24, 193);
            this.labelYear_GKU.Name = "labelYear_GKU";
            this.labelYear_GKU.Size = new System.Drawing.Size(94, 17);
            this.labelYear_GKU.TabIndex = 5;
            this.labelYear_GKU.Text = "Год выпуска:";
            // 
            // labelGenre_GKU
            // 
            this.labelGenre_GKU.AutoSize = true;
            this.labelGenre_GKU.Location = new System.Drawing.Point(69, 255);
            this.labelGenre_GKU.Name = "labelGenre_GKU";
            this.labelGenre_GKU.Size = new System.Drawing.Size(49, 17);
            this.labelGenre_GKU.TabIndex = 6;
            this.labelGenre_GKU.Text = "Жанр:";
            // 
            // labelIsBookNew_GKU
            // 
            this.labelIsBookNew_GKU.AutoSize = true;
            this.labelIsBookNew_GKU.Location = new System.Drawing.Point(6, 319);
            this.labelIsBookNew_GKU.Name = "labelIsBookNew_GKU";
            this.labelIsBookNew_GKU.Size = new System.Drawing.Size(112, 17);
            this.labelIsBookNew_GKU.TabIndex = 7;
            this.labelIsBookNew_GKU.Text = "Новое издание:";
            // 
            // labelAnnotation_GKU
            // 
            this.labelAnnotation_GKU.AutoSize = true;
            this.labelAnnotation_GKU.Location = new System.Drawing.Point(34, 376);
            this.labelAnnotation_GKU.Name = "labelAnnotation_GKU";
            this.labelAnnotation_GKU.Size = new System.Drawing.Size(84, 17);
            this.labelAnnotation_GKU.TabIndex = 8;
            this.labelAnnotation_GKU.Text = "Аннотация:";
            // 
            // buttonAddNewBook_GKU
            // 
            this.buttonAddNewBook_GKU.Location = new System.Drawing.Point(286, 404);
            this.buttonAddNewBook_GKU.Name = "buttonAddNewBook_GKU";
            this.buttonAddNewBook_GKU.Size = new System.Drawing.Size(147, 42);
            this.buttonAddNewBook_GKU.TabIndex = 9;
            this.buttonAddNewBook_GKU.Text = "Добавить";
            this.buttonAddNewBook_GKU.UseVisualStyleBackColor = true;
            this.buttonAddNewBook_GKU.Click += new System.EventHandler(this.buttonAddNewBook_GKU_Click);
            // 
            // FormAddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 458);
            this.Controls.Add(this.buttonAddNewBook_GKU);
            this.Controls.Add(this.labelAnnotation_GKU);
            this.Controls.Add(this.labelIsBookNew_GKU);
            this.Controls.Add(this.labelGenre_GKU);
            this.Controls.Add(this.labelYear_GKU);
            this.Controls.Add(this.labelAuthor_GKU);
            this.Controls.Add(this.labelBook_Name);
            this.Controls.Add(this.labelArticle_GKU);
            this.Controls.Add(this.comboBoxIsBookNew_GKU);
            this.Controls.Add(this.textBoxBookAnnotation_GKU);
            this.Controls.Add(this.textBoxBookGenre_GKU);
            this.Controls.Add(this.textBoxBookYear_GKU);
            this.Controls.Add(this.textBoxBookAuthor_GKU);
            this.Controls.Add(this.textBoxBookName_GKU);
            this.Controls.Add(this.textBoxBookArticle_GKU);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить книгу";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxBookArticle_GKU;
        private System.Windows.Forms.TextBox textBoxBookName_GKU;
        private System.Windows.Forms.TextBox textBoxBookAuthor_GKU;
        private System.Windows.Forms.TextBox textBoxBookYear_GKU;
        private System.Windows.Forms.TextBox textBoxBookGenre_GKU;
        private System.Windows.Forms.TextBox textBoxBookAnnotation_GKU;
        private System.Windows.Forms.Label labelArticle_GKU;
        private System.Windows.Forms.Label labelBook_Name;
        private System.Windows.Forms.Label labelAuthor_GKU;
        private System.Windows.Forms.Label labelYear_GKU;
        private System.Windows.Forms.Label labelGenre_GKU;
        private System.Windows.Forms.Label labelIsBookNew_GKU;
        private System.Windows.Forms.Label labelAnnotation_GKU;
        private System.Windows.Forms.Button buttonAddNewBook_GKU;
        private System.Windows.Forms.ComboBox comboBoxIsBookNew_GKU;
    }
}