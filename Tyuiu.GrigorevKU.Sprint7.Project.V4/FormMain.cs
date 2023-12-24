using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.GrigorevKU.Sprint7.Project.V4.Lib;

namespace Tyuiu.GrigorevKU.Sprint7.Project.V4
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
    

            openFileDialogTask_GKU.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogTask_GKU.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.";
        }

        static int rows;
        static int columns;
        static string openFilePath;
        DataService ds = new DataService();

        public static string[,] LoadFromFileData(string filePath)
        {
            string FileData = File.ReadAllText(filePath);

            FileData = FileData.Replace('\n', '\r');
            string[] lines = FileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            string[,] arrayValues = new string[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = line_r[c];
                }
            }
            return arrayValues;
        }

        public void buttonOpenBookBase_GKU_Click(object sender, EventArgs e)
        {
            openFileDialogTask_GKU.ShowDialog();
            openFilePath = openFileDialogTask_GKU.FileName;

            string[,] arrayValues = new string[rows, columns];

            arrayValues = LoadFromFileData(openFilePath);

            arrayValues = ds.GetBase(openFilePath);
            buttonBooks_GKU.Enabled = true;
            buttonDeleteBook_GKU.Enabled = true;
            buttonChangeBook_GKU.Enabled = true;
            buttonUsersBase_GKU.Enabled = false;
            buttonAddUser_GKU.Visible = false;
            buttonChangeUser_GKU.Visible = false;
            buttonDeleteUser_GKU.Visible = false;
            buttonFindUser_GKU.Visible = false;
            panelUnreturned_GKU.Visible = false;
            buttonUnreturnedBook_GKU.Visible = false;
            buttonSaveUserBase_GKU.Enabled = false;
            ToolStripMenuItemSaveUser_GKU.Enabled = false;
            ToolStripMenuItemFile_GKU.Enabled = true;
            ToolStripMenuItemEditUsers_GKU.Enabled = false;
        }

        public void buttonBooks_GKU_Click(object sender, EventArgs e)
        {
            dataGridViewMain_GKU.ColumnCount = columns;
            dataGridViewMain_GKU.RowCount = rows;

            dataGridViewMain_GKU.Columns[0].HeaderText = "Артикул";
            dataGridViewMain_GKU.Columns[1].HeaderText = "Название";
            dataGridViewMain_GKU.Columns[2].HeaderText = "Автор";
            dataGridViewMain_GKU.Columns[3].HeaderText = "Год издания";
            dataGridViewMain_GKU.Columns[4].HeaderText = "Жанр";
            dataGridViewMain_GKU.Columns[5].HeaderText = "Новое издание";
            dataGridViewMain_GKU.Columns[6].HeaderText = "Аннотация";

            dataGridViewMain_GKU.Columns[0].Width = 50;
            dataGridViewMain_GKU.Columns[1].Width = 200;
            dataGridViewMain_GKU.Columns[2].Width = 100;
            dataGridViewMain_GKU.Columns[3].Width = 50;
            dataGridViewMain_GKU.Columns[4].Width = 60;
            dataGridViewMain_GKU.Columns[5].Width = 50;
            dataGridViewMain_GKU.Columns[6].Width = 300;


            dataGridViewMain_GKU.Rows[0].ReadOnly = true;
            dataGridViewMain_GKU.Columns[0].ReadOnly = true;

            string[,] arrayValues = new string[rows, columns];
            arrayValues = LoadFromFileData(openFilePath);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewMain_GKU.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            arrayValues = ds.GetBase(openFilePath);
            buttonDeleteBook_GKU.Visible = true;
            buttonChangeBook_GKU.Visible = true;
            buttonFindBook_GKU.Visible = true;
            buttonAddBook_GKU.Visible = true;
            ToolStripMenuItemEditBooks_GKU.Enabled = true;
            buttonSaveBookBase_GKU.Enabled = true;
            textBoxElementCount_GKU.Visible = true;
            textBoxElementCount_GKU.Text = dataGridViewMain_GKU.Rows.Count.ToString();
            labelCount_GKU.Visible = true;
            labelCount_GKU.Text = "Количество книг:";
            groupBoxNewBooks_GKU.Visible = true;
            buttonNewBook_GKU.Visible = true;

        }

        public void buttonDeleteBook_GKU_Click(object sender, EventArgs e)
        {
            try
            {
                if(dataGridViewMain_GKU.CurrentRow.Index >= 0)
                {
                    int a = dataGridViewMain_GKU.CurrentRow.Index;
                    dataGridViewMain_GKU.Rows.Remove(dataGridViewMain_GKU.Rows[a]);
                    if (dataGridViewMain_GKU.Rows.Count == 1)
                    {
                        dataGridViewMain_GKU.Rows.Clear();
                    }
                }
                if(dataGridViewMain_GKU.Rows.Count <= 1)
                {
                    buttonDeleteBook_GKU.Enabled = false;
                    buttonChangeBook_GKU.Enabled = false;
                    buttonFindBook_GKU.Enabled = false;
                }
                if(dataGridViewMain_GKU.Rows.Count > 1)
                {
                    buttonDeleteBook_GKU.Enabled = true;
                }
                buttonBooks_GKU.Enabled = false;
                textBoxElementCount_GKU.Text = dataGridViewMain_GKU.Rows.Count.ToString();

            }
            catch
            {
                MessageBox.Show("Ошибка при удалении книги", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void buttonAddBook_GKU_Click(object sender, EventArgs e)
        {
            FormAddBook formAddBook = new FormAddBook(this);
            formAddBook.ShowDialog();
            buttonBooks_GKU.Enabled = false;
            textBoxElementCount_GKU.Text = dataGridViewMain_GKU.Rows.Count.ToString();
        }

        private void buttonChangeBook_GKU_Click(object sender, EventArgs e)
        {
            try
            {
                int a = dataGridViewMain_GKU.CurrentRow.Index;
                FormEditBook fed = new FormEditBook(this);
                fed.textBoxBookArticle_GKU.Text = dataGridViewMain_GKU.Rows[a].Cells[0].Value.ToString();
                fed.textBoxBookName_GKU.Text = dataGridViewMain_GKU.Rows[a].Cells[1].Value.ToString();
                fed.textBoxBookAuthor_GKU.Text = dataGridViewMain_GKU.Rows[a].Cells[2].Value.ToString();
                fed.textBoxBookYear_GKU.Text = dataGridViewMain_GKU.Rows[a].Cells[3].Value.ToString();
                fed.textBoxBookGenre_GKU.Text = dataGridViewMain_GKU.Rows[a].Cells[4].Value.ToString();
                fed.comboBoxIsBookNew_GKU.Text = dataGridViewMain_GKU.Rows[a].Cells[5].Value.ToString();
                fed.textBoxBookAnnotation_GKU.Text = dataGridViewMain_GKU.Rows[a].Cells[6].Value.ToString();
                fed.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Ошибка при редактировании книги", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonFindBook_GKU_Click(object sender, EventArgs e)
        {
            FormSearchBook formSearchBook = new FormSearchBook(this);
            formSearchBook.ShowDialog();
        }

        private void toolStripMenuItemOpenBook_GKU_Click(object sender, EventArgs e)
        {
            openFileDialogTask_GKU.ShowDialog();
            openFilePath = openFileDialogTask_GKU.FileName;

            string[,] arrayValues = new string[rows, columns];

            arrayValues = LoadFromFileData(openFilePath);

            arrayValues = ds.GetBase(openFilePath);
            buttonBooks_GKU.Enabled = true;
            buttonDeleteBook_GKU.Enabled = true;
            buttonChangeBook_GKU.Enabled = true;
            buttonSaveBookBase_GKU.Enabled = true;
            panelUnreturned_GKU.Visible = false;
            buttonUnreturnedBook_GKU.Visible = false;
            buttonSaveUserBase_GKU.Enabled = false;
            ToolStripMenuItemSaveUser_GKU.Enabled = false;
            ToolStripMenuItemFile_GKU.Enabled = true;
            ToolStripMenuItemEditUsers_GKU.Enabled = false;
            textBoxElementCount_GKU.Text = dataGridViewMain_GKU.Rows.Count.ToString();
        }

        private void ToolStripMenuItemAddBook_GKU_Click(object sender, EventArgs e)
        {
            FormAddBook formAddBook = new FormAddBook(this);
            formAddBook.ShowDialog();
            buttonBooks_GKU.Enabled = false;
            textBoxElementCount_GKU.Text = dataGridViewMain_GKU.Rows.Count.ToString();
        }

        private void ToolStripMenuItemEditBook_GKU_Click(object sender, EventArgs e)
        {
            try
            {
                int a = dataGridViewMain_GKU.CurrentRow.Index;
                FormEditBook fed = new FormEditBook(this);
                fed.textBoxBookArticle_GKU.Text = dataGridViewMain_GKU.Rows[a].Cells[0].Value.ToString();
                fed.textBoxBookName_GKU.Text = dataGridViewMain_GKU.Rows[a].Cells[1].Value.ToString();
                fed.textBoxBookAuthor_GKU.Text = dataGridViewMain_GKU.Rows[a].Cells[2].Value.ToString();
                fed.textBoxBookYear_GKU.Text = dataGridViewMain_GKU.Rows[a].Cells[3].Value.ToString();
                fed.textBoxBookGenre_GKU.Text = dataGridViewMain_GKU.Rows[a].Cells[4].Value.ToString();
                fed.comboBoxIsBookNew_GKU.Text = dataGridViewMain_GKU.Rows[a].Cells[5].Value.ToString();
                fed.textBoxBookAnnotation_GKU.Text = dataGridViewMain_GKU.Rows[a].Cells[6].Value.ToString();
                fed.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Ошибка при редактировании книги", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ToolStripMenuItemFindBook_GKU_Click(object sender, EventArgs e)
        {
            FormSearchBook formSearchBook = new FormSearchBook(this);
            formSearchBook.ShowDialog();
        }

        private void ToolStripMenuItemDeleteBook_GKU_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewMain_GKU.CurrentRow.Index >= 0)
                {
                    int a = dataGridViewMain_GKU.CurrentRow.Index;
                    dataGridViewMain_GKU.Rows.Remove(dataGridViewMain_GKU.Rows[a]);
                    if (dataGridViewMain_GKU.Rows.Count == 1)
                    {
                        dataGridViewMain_GKU.Rows.Clear();
                    }
                }
                if (dataGridViewMain_GKU.Rows.Count <= 1)
                {
                    buttonDeleteBook_GKU.Enabled = false;
                    buttonChangeBook_GKU.Enabled = false;
                    buttonFindBook_GKU.Enabled = false;
                }
                if (dataGridViewMain_GKU.Rows.Count > 1)
                {
                    buttonDeleteBook_GKU.Enabled = true;
                }
                buttonBooks_GKU.Enabled = false;
                textBoxElementCount_GKU.Text = dataGridViewMain_GKU.Rows.Count.ToString();

            }
            catch
            {
                MessageBox.Show("Ошибка при удалении книги", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ToolStripMenuItemFile_GKU_Click(object sender, EventArgs e)
        {
            saveFileDialogTask_GKU.FileName = "BookBase.csv";
            saveFileDialogTask_GKU.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogTask_GKU.ShowDialog();

            string path = saveFileDialogTask_GKU.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool FileExists = fileInfo.Exists;

            if (FileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewMain_GKU.RowCount;
            int columns = dataGridViewMain_GKU.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewMain_GKU.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewMain_GKU.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonSaveBookBase_GKU_Click(object sender, EventArgs e)
        {
            saveFileDialogTask_GKU.FileName = "BookBase.csv";
            saveFileDialogTask_GKU.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogTask_GKU.ShowDialog();

            string path = saveFileDialogTask_GKU.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool FileExists = fileInfo.Exists;

            if (FileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewMain_GKU.RowCount;
            int columns = dataGridViewMain_GKU.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewMain_GKU.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewMain_GKU.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonOpenUserBase_GKU_Click(object sender, EventArgs e)
        {
            openFileDialogTask_GKU.ShowDialog();
            openFilePath = openFileDialogTask_GKU.FileName;

            string[,] arrayValues = new string[rows, columns];

            arrayValues = LoadFromFileData(openFilePath);

            arrayValues = ds.GetBase(openFilePath);
            buttonUsersBase_GKU.Enabled = true;
            buttonDeleteUser_GKU.Enabled = true;
            buttonChangeUser_GKU.Enabled = true;
            buttonBooks_GKU.Enabled = false;
            buttonAddBook_GKU.Visible = false;
            buttonChangeBook_GKU.Visible = false;
            buttonDeleteBook_GKU.Visible = false;
            buttonFindBook_GKU.Visible = false;
            buttonSaveBookBase_GKU.Enabled = false;
            ToolStripMenuItemFile_GKU.Enabled = false;
            ToolStripMenuItemSaveUser_GKU.Enabled = true;
            ToolStripMenuItemEditBooks_GKU.Enabled = false;
        }

        private void buttonUsersBase_GKU_Click(object sender, EventArgs e)
        {
            dataGridViewMain_GKU.ColumnCount = columns;
            dataGridViewMain_GKU.RowCount = rows;

            dataGridViewMain_GKU.Columns[0].HeaderText = "Номер билета";
            dataGridViewMain_GKU.Columns[1].HeaderText = "ФИО";
            dataGridViewMain_GKU.Columns[2].HeaderText = "Адрес";
            dataGridViewMain_GKU.Columns[3].HeaderText = "Номер телефона";
            dataGridViewMain_GKU.Columns[4].HeaderText = "Артикул книги";
            dataGridViewMain_GKU.Columns[5].HeaderText = "Дата получения";
            dataGridViewMain_GKU.Columns[6].HeaderText = "Дата возврата";

            dataGridViewMain_GKU.Columns[0].Width = 50;
            dataGridViewMain_GKU.Columns[1].Width = 200;
            dataGridViewMain_GKU.Columns[2].Width = 300;
            dataGridViewMain_GKU.Columns[3].Width = 200;
            dataGridViewMain_GKU.Columns[4].Width = 60;
            dataGridViewMain_GKU.Columns[5].Width = 100;
            dataGridViewMain_GKU.Columns[6].Width = 100;


            dataGridViewMain_GKU.Rows[0].ReadOnly = true;
            dataGridViewMain_GKU.Columns[0].ReadOnly = true;

            string[,] arrayValues = new string[rows, columns];
            arrayValues = LoadFromFileData(openFilePath);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewMain_GKU.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            arrayValues = ds.GetBase(openFilePath);
            buttonDeleteUser_GKU.Visible = true;
            buttonChangeUser_GKU.Visible = true;
            buttonFindUser_GKU.Visible = true;
            buttonAddUser_GKU.Visible = true;
            ToolStripMenuItemEditUsers_GKU.Enabled = true;
            buttonSaveUserBase_GKU.Enabled = true;
            panelUnreturned_GKU.Visible = true;
            buttonUnreturnedBook_GKU.Visible = true;
            ToolStripMenuItemEditUsers_GKU.Enabled = true;
            textBoxElementCount_GKU.Text = dataGridViewMain_GKU.Rows.Count.ToString();
            labelCount_GKU.Text = "Количество записей:";
            groupBoxNewBooks_GKU.Visible = false;
            buttonNewBook_GKU.Visible = false;
            chartStat_GKU.Visible = false;

        }

        private void buttonAddUser_GKU_Click(object sender, EventArgs e)
        {
            FormAddUser formAddUser = new FormAddUser(this);
            formAddUser.ShowDialog();
            buttonUsersBase_GKU.Enabled = false;
            textBoxElementCount_GKU.Text = dataGridViewMain_GKU.Rows.Count.ToString();
        }

        private void buttonDeleteUser_GKU_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewMain_GKU.CurrentRow.Index >= 0)
                {
                    int a = dataGridViewMain_GKU.CurrentRow.Index;
                    dataGridViewMain_GKU.Rows.Remove(dataGridViewMain_GKU.Rows[a]);
                    if (dataGridViewMain_GKU.Rows.Count == 1)
                    {
                        dataGridViewMain_GKU.Rows.Clear();
                    }
                }
                if (dataGridViewMain_GKU.Rows.Count <= 1)
                {
                    buttonDeleteUser_GKU.Enabled = false;
                    buttonChangeUser_GKU.Enabled = false;
                    buttonFindUser_GKU.Enabled = false;
                }
                if (dataGridViewMain_GKU.Rows.Count > 1)
                {
                    buttonDeleteUser_GKU.Enabled = true;
                }
                buttonUsersBase_GKU.Enabled = false;
                textBoxElementCount_GKU.Text = dataGridViewMain_GKU.Rows.Count.ToString();
                buttonUnreturnedBook_GKU.Enabled = true;

            }
            catch
            {
                MessageBox.Show("Ошибка при удалении читателя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonFindUser_GKU_Click(object sender, EventArgs e)
        {
            FormSearchUser formSearchUser = new FormSearchUser(this);
            formSearchUser.ShowDialog();
        }

        private void buttonChangeUser_GKU_Click(object sender, EventArgs e)
        {
            try
            {
                int a = dataGridViewMain_GKU.CurrentRow.Index;
                FormEditUser fed = new FormEditUser(this);
                fed.textBoxUserID_GKU.Text = dataGridViewMain_GKU.Rows[a].Cells[0].Value.ToString();
                fed.textBoxUserName_GKU.Text = dataGridViewMain_GKU.Rows[a].Cells[1].Value.ToString();
                fed.textBoxUserAddress_GKU.Text = dataGridViewMain_GKU.Rows[a].Cells[2].Value.ToString();
                fed.textBoxUserPhone_GKU.Text = dataGridViewMain_GKU.Rows[a].Cells[3].Value.ToString();
                fed.textBoxUserBookArticle_GKU.Text = dataGridViewMain_GKU.Rows[a].Cells[4].Value.ToString();
                fed.textBoxUserGetBookDate_GKU.Text = dataGridViewMain_GKU.Rows[a].Cells[5].Value.ToString();
                fed.textBoxBookUserReturnBookDate_GKU.Text = dataGridViewMain_GKU.Rows[a].Cells[6].Value.ToString();
                fed.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Ошибка при измении данных читателя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void labelUnreturnedBookss_GKU_Click(object sender, EventArgs e)
        {

        }

        private void buttonUnreturnedBook_GKU_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewUnreturnedBooks_GKU.Rows.Clear();
                dataGridViewUnreturnedBooks_GKU.Columns[0].Width = 200;
                dataGridViewUnreturnedBooks_GKU.Columns[1].Width = 100;
                dataGridViewUnreturnedBooks_GKU.ColumnCount = 2;
                dataGridViewUnreturnedBooks_GKU.RowCount = dataGridViewMain_GKU.RowCount;
                for (int i = 0; i < dataGridViewMain_GKU.RowCount; i++)
                {
                    if((dataGridViewMain_GKU.Rows[i].Cells[5].Value != null) && (dataGridViewMain_GKU.Rows[i].Cells[6].Value == ""))
                    {
                        string column1Value = dataGridViewMain_GKU.Rows[i].Cells[1].Value.ToString(); 
                        string column2Value = dataGridViewMain_GKU.Rows[i].Cells[4].Value.ToString();
                        dataGridViewUnreturnedBooks_GKU.Rows.Add(column1Value, column2Value);
                    }
                }

                for (int i = 0; i < dataGridViewUnreturnedBooks_GKU.RowCount - 1; i++)
                {

                    if ((dataGridViewUnreturnedBooks_GKU.Rows[i].Cells[0].Value == null) && (dataGridViewUnreturnedBooks_GKU.Rows[i].Cells[1].Value == null))
                    {
                        dataGridViewUnreturnedBooks_GKU.Rows.RemoveAt(i);
                        i--;
                    }
                }


            }
            catch
            {
               MessageBox.Show("Ошибка при редактировании книги", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ToolStripMenuItemOpenUser_GKU_Click(object sender, EventArgs e)
        {
            openFileDialogTask_GKU.ShowDialog();
            openFilePath = openFileDialogTask_GKU.FileName;

            string[,] arrayValues = new string[rows, columns];

            arrayValues = LoadFromFileData(openFilePath);

            arrayValues = ds.GetBase(openFilePath);
            buttonUsersBase_GKU.Enabled = true;
            buttonDeleteUser_GKU.Enabled = true;
            buttonChangeUser_GKU.Enabled = true;
            buttonBooks_GKU.Enabled = false;
            buttonAddBook_GKU.Visible = false;
            buttonChangeBook_GKU.Visible = false;
            buttonDeleteBook_GKU.Visible = false;
            buttonFindBook_GKU.Visible = false;
            buttonSaveBookBase_GKU.Enabled = false;
            ToolStripMenuItemFile_GKU.Enabled = false;
            ToolStripMenuItemSaveUser_GKU.Enabled = true;
            ToolStripMenuItemEditBooks_GKU.Enabled = false;
            groupBoxNewBooks_GKU.Visible = false;
            buttonNewBook_GKU.Visible = false;
        }

        private void ToolStripMenuItemAddUser_GKU_Click(object sender, EventArgs e)
        {
            FormAddUser formAddUser = new FormAddUser(this);
            formAddUser.ShowDialog();
            buttonUsersBase_GKU.Enabled = false;
            textBoxElementCount_GKU.Text = dataGridViewMain_GKU.Rows.Count.ToString();
        }

        private void ToolStripMenuItemEditUser_GKU_Click(object sender, EventArgs e)
        {
            try
            {
                int a = dataGridViewMain_GKU.CurrentRow.Index;
                FormEditUser fed = new FormEditUser(this);
                fed.textBoxUserID_GKU.Text = dataGridViewMain_GKU.Rows[a].Cells[0].Value.ToString();
                fed.textBoxUserName_GKU.Text = dataGridViewMain_GKU.Rows[a].Cells[1].Value.ToString();
                fed.textBoxUserAddress_GKU.Text = dataGridViewMain_GKU.Rows[a].Cells[2].Value.ToString();
                fed.textBoxUserPhone_GKU.Text = dataGridViewMain_GKU.Rows[a].Cells[3].Value.ToString();
                fed.textBoxUserBookArticle_GKU.Text = dataGridViewMain_GKU.Rows[a].Cells[4].Value.ToString();
                fed.textBoxUserGetBookDate_GKU.Text = dataGridViewMain_GKU.Rows[a].Cells[5].Value.ToString();
                fed.textBoxBookUserReturnBookDate_GKU.Text = dataGridViewMain_GKU.Rows[a].Cells[6].Value.ToString();
                fed.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Ошибка при измении данных читателя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ToolStripMenuItemFindUser_GKU_Click(object sender, EventArgs e)
        {
            FormSearchUser formSearchUser = new FormSearchUser(this);
            formSearchUser.ShowDialog();
        }

        private void ToolStripMenuItemDeleteUser_GKU_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewMain_GKU.CurrentRow.Index >= 0)
                {
                    int a = dataGridViewMain_GKU.CurrentRow.Index;
                    dataGridViewMain_GKU.Rows.Remove(dataGridViewMain_GKU.Rows[a]);
                    if (dataGridViewMain_GKU.Rows.Count == 1)
                    {
                        dataGridViewMain_GKU.Rows.Clear();
                    }
                }
                if (dataGridViewMain_GKU.Rows.Count <= 1)
                {
                    buttonDeleteUser_GKU.Enabled = false;
                    buttonChangeUser_GKU.Enabled = false;
                    buttonFindUser_GKU.Enabled = false;
                }
                if (dataGridViewMain_GKU.Rows.Count > 1)
                {
                    buttonDeleteUser_GKU.Enabled = true;
                }
                buttonUsersBase_GKU.Enabled = false;
                textBoxElementCount_GKU.Text = dataGridViewMain_GKU.Rows.Count.ToString();

            }
            catch
            {
                MessageBox.Show("Ошибка при удалении читателя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSaveUserBase_GKU_Click(object sender, EventArgs e)
        {
            saveFileDialogTask_GKU.FileName = "UsersBase.csv";
            saveFileDialogTask_GKU.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogTask_GKU.ShowDialog();

            string path = saveFileDialogTask_GKU.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool FileExists = fileInfo.Exists;

            if (FileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewMain_GKU.RowCount;
            int columns = dataGridViewMain_GKU.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewMain_GKU.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewMain_GKU.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void ToolStripMenuItemSaveUser_GKU_Click(object sender, EventArgs e)
        {
            saveFileDialogTask_GKU.FileName = "UsersBase.csv";
            saveFileDialogTask_GKU.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogTask_GKU.ShowDialog();

            string path = saveFileDialogTask_GKU.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool FileExists = fileInfo.Exists;

            if (FileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewMain_GKU.RowCount;
            int columns = dataGridViewMain_GKU.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewMain_GKU.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewMain_GKU.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonInfo_GKU_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void ToolStripMenuItemAbout_GKU_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void ToolStripMenuItemInstruction_GKU_Click(object sender, EventArgs e)
        {
            FormInstruction forminst = new FormInstruction();
            forminst.ShowDialog();
        }

        private void textBoxElementCount_GKU_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelCount_GKU_Click(object sender, EventArgs e)
        {

        }

        private void chartStatistics_GKU_Click(object sender, EventArgs e)
        {

        }

        private void buttonNewBook_GKU_Click(object sender, EventArgs e)
        {
            int newbook = 0;
            int oldbook = 0;
            for(int i = 0; i < dataGridViewMain_GKU.RowCount; i++)
            {
                for(int j = 5; j <= 5; j++)
                {
                    if(dataGridViewMain_GKU.Rows[i].Cells[j].Value.ToString() == "да")
                    {
                        newbook++;
                    }
                    else
                    {
                        oldbook++;
                    }
                }
            }
            dataGridViewNewBooks_GKU.Rows[0].Cells[0].Value = Convert.ToString(newbook);
            dataGridViewNewBooks_GKU.Rows[0].Cells[1].Value = Convert.ToString(oldbook);

            chartStat_GKU.Visible = true;

            chartStat_GKU.Series.Clear();

            Series oldSeries = new Series();
            oldSeries.Name = "Старые издания";
            oldSeries.ChartType = SeriesChartType.Column;

            Series newSeries = new Series();
            newSeries.Name = "Новые издания";
            newSeries.ChartType = SeriesChartType.Column;

            newSeries.Points.AddXY(0, dataGridViewNewBooks_GKU.Rows[0].Cells[0].Value);
            oldSeries.Points.AddXY(1, dataGridViewNewBooks_GKU.Rows[0].Cells[1].Value);

            chartStat_GKU.Series.Add(oldSeries);
            chartStat_GKU.Series.Add(newSeries);

        }

        private void dataGridViewNewBooks_GKU_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

    
}
