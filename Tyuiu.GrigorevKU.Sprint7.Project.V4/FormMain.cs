﻿using System;
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
                if(dataGridViewMain_GKU.Rows.Count == 1)
                {
                    buttonDeleteBook_GKU.Enabled = false;
                    buttonChangeBook_GKU.Enabled = false;
                }
                if(dataGridViewMain_GKU.Rows.Count > 1)
                {
                    buttonDeleteBook_GKU.Enabled = true;
                }
                buttonBooks_GKU.Enabled = false;

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
    }

    
}
