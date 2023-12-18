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

        private void buttonOpenBookBase_GKU_Click(object sender, EventArgs e)
        {
            openFileDialogTask_GKU.ShowDialog();
            openFilePath = openFileDialogTask_GKU.FileName;

            string[,] arrayValues = new string[rows, columns];

            arrayValues = LoadFromFileData(openFilePath);

            dataGridViewMain_GKU.ColumnCount = columns;
            dataGridViewMain_GKU.RowCount = rows;

            arrayValues = ds.GetBase(openFilePath);
            buttonBooks_GKU.Enabled = true;
        }

        private void buttonBooks_GKU_Click(object sender, EventArgs e)
        {
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

            string[,] arrayValues = new string[rows, columns];
            arrayValues = LoadFromFileData(openFilePath);
            for (int i = 0; i < columns; i++)
            {
                //dataGridViewMain_GKU.Columns[i].Width = 200;
                //dataGridViewMain_GKU.Columns[i].Width = 200;
            }

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
        }
    }
    
}
