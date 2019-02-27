using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace WindowsFormsComparer_с_работы_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Метод берет из заданной директории файлы всех видов,
        // отделяет их имена и время последнего изменения,
        // и выписывает в текст-боксе.
        // Необходимо добавить вывод количества строк в файле.
        //private void button1_Click(object sender, EventArgs e)
        //{
        //    textBox1.Clear();
        //    folderBrowserDialog1.ShowDialog();
        //    var nameDir1 = folderBrowserDialog1.SelectedPath;
        //    DirectoryInfo dirName1 = new DirectoryInfo(nameDir1);
        //    foreach (var file1 in dirName1.GetFiles("*.*"))
        //    {
        //        string fileName1 = file1.Name; // Переменная хранит имя файла.
        //        var fileDate1 = file1.LastWriteTime; // Переменная хранит время изменения.

        //        textBox1.Text += "Имя: " + fileName1 + " | Время: " + fileDate1 + " | Число строк:" + "\r\n";
        //    }
        //}

        // Метод берет имена файлов всех видов из заданной директории как массив,
        // и построчно распределяе его в чек-лист боксе.
        //

        private void button1_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();
            folderBrowserDialog1.ShowDialog();
            var nameFold1 = folderBrowserDialog1.SelectedPath;
            DirectoryInfo dirName1 = new DirectoryInfo(nameFold1);
            foreach (var file1 in dirName1.GetFiles("*.*"))
            {
                string fileName1 = file1.Name; // Переменная хранит имя файла.
                var fileDate1 = file1.LastWriteTime; // Переменная хранит время изменения.
                //int fileNum1 = 
                Array[] array2 = fileName1;
                //checkedListBox1.Items.Add = array2;
                //"Имя: " + fileName1 + " | Время: " + fileDate1 + " | Число строк:" + "\r\n";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();
            folderBrowserDialog2.ShowDialog();
            var nameFold2 = folderBrowserDialog2.SelectedPath;
            DirectoryInfo dirName2 = new DirectoryInfo(nameFold2);
            foreach (var file2 in dirName2.GetFiles("*.*"))
            {
                string fileName2 = file2.Name; // Переменная хранит имя файла.
                var fileDate2 = file2.LastWriteTime; // Переменная хранит время изменения.
                //string[] array2 = fileName2;
                //checkedListBox1.Items.Add = array2;
                //"Имя: " + fileName2 + " | Время: " + fileDate2;
            }
        }
        // Метод для закрытия приложения.
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Метод для сравнения двух массивов имён файлов.
        private void сравнитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}