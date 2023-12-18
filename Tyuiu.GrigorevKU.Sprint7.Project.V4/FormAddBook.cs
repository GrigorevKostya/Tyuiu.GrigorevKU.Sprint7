using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.GrigorevKU.Sprint7.Project.V4
{
    public partial class FormAddBook : Form
    {
        FormMain fmain;
        public FormAddBook(FormMain fm)
        {
            InitializeComponent();
            this.fmain = fm;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonAddNewBook_GKU_Click(object sender, EventArgs e)
        {
            fmain.dataGridViewMain_GKU.Rows.Add(textBoxBookArticle_GKU.Text, textBoxBookName_GKU.Text, textBoxBookAuthor_GKU.Text, textBoxBookYear_GKU.Text, textBoxBookGenre_GKU.Text, comboBoxIsBookNew_GKU.Text, textBoxBookAnnotation_GKU.Text);
            fmain.buttonDeleteBook_GKU.Enabled = true;
        }
    }
}
