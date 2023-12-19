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
    public partial class FormSearchUser : Form
    {
        FormMain fmain;
        public FormSearchUser(FormMain fm)
        {
            InitializeComponent();
            this.fmain = fm;
        }

        private void buttonAddNewBook_GKU_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < fmain.dataGridViewMain_GKU.RowCount; i++)
                {
                    fmain.dataGridViewMain_GKU.Rows[i].Selected = false;
                    for (int j = comboBoxSearchType_GKU.SelectedIndex; j < fmain.dataGridViewMain_GKU.ColumnCount; j++)
                        if (fmain.dataGridViewMain_GKU.Rows[i].Cells[j].Value != null)
                            if (fmain.dataGridViewMain_GKU.Rows[i].Cells[j].Value.ToString().Contains(textBoxBookSearch_GKU.Text))
                            {
                                fmain.dataGridViewMain_GKU.Rows[i].Selected = true;
                                break;
                            }
                }
                this.Close();
            }
            catch
            {
                MessageBox.Show("Ошибка при поиске книги", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
