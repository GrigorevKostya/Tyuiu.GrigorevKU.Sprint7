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
    public partial class FormEditBook : Form
    {
        FormMain fmain;
        public FormEditBook(FormMain fm)
        {
            InitializeComponent();
            this.fmain = fm;
        }

        private void buttonEditNewBook_GKU_Click(object sender, EventArgs e)
        {
            int a = fmain.dataGridViewMain_GKU.CurrentRow.Index;
            fmain.dataGridViewMain_GKU.Rows[a].Cells[0].Value = textBoxBookArticle_GKU.Text;
            fmain.dataGridViewMain_GKU.Rows[a].Cells[1].Value = textBoxBookName_GKU.Text;
            fmain.dataGridViewMain_GKU.Rows[a].Cells[2].Value = textBoxBookAuthor_GKU.Text;
            fmain.dataGridViewMain_GKU.Rows[a].Cells[3].Value = textBoxBookYear_GKU.Text;
            fmain.dataGridViewMain_GKU.Rows[a].Cells[4].Value = textBoxBookGenre_GKU.Text;
            fmain.dataGridViewMain_GKU.Rows[a].Cells[5].Value = comboBoxIsBookNew_GKU.Text;
            fmain.dataGridViewMain_GKU.Rows[a].Cells[6].Value = textBoxBookAnnotation_GKU.Text;
            this.Close();
        }
    }
}
