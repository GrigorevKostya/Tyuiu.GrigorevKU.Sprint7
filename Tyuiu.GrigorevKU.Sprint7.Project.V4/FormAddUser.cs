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
    public partial class FormAddUser : Form
    {
        FormMain fmain;
        public FormAddUser(FormMain fm)
        {
            InitializeComponent();
            this.fmain = fm;
        }

        private void buttonAddNewUser_GKU_Click(object sender, EventArgs e)
        {
            fmain.dataGridViewMain_GKU.Rows.Add(textBoxUserID_GKU.Text, textBoxUserName_GKU.Text, textBoxUserAddress_GKU.Text, textBoxUserPhone_GKU.Text, textBoxUserBookArticle_GKU.Text, textBoxUserGetBookDate_GKU.Text, textBoxBookUserReturnBookDate_GKU.Text);
            fmain.buttonDeleteUser_GKU.Enabled = true;
            this.Close();
        }
    }
}
