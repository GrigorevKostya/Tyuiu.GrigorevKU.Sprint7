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
    public partial class FormEditUser : Form
    {
        FormMain fmain;
        public FormEditUser(FormMain fm)
        {
            InitializeComponent();
            this.fmain = fm;
        }

        private void buttonEditUser_GKU_Click(object sender, EventArgs e)
        {
            int a = fmain.dataGridViewMain_GKU.CurrentRow.Index;
            fmain.dataGridViewMain_GKU.Rows[a].Cells[0].Value = textBoxUserID_GKU.Text;
            fmain.dataGridViewMain_GKU.Rows[a].Cells[1].Value = textBoxUserName_GKU.Text;
            fmain.dataGridViewMain_GKU.Rows[a].Cells[2].Value = textBoxUserAddress_GKU.Text;
            fmain.dataGridViewMain_GKU.Rows[a].Cells[3].Value = textBoxUserPhone_GKU.Text;
            fmain.dataGridViewMain_GKU.Rows[a].Cells[4].Value = textBoxUserBookArticle_GKU.Text;
            fmain.dataGridViewMain_GKU.Rows[a].Cells[5].Value = textBoxUserGetBookDate_GKU.Text;
            fmain.dataGridViewMain_GKU.Rows[a].Cells[6].Value = textBoxBookUserReturnBookDate_GKU.Text;
            this.Close();
        }
    }
}
