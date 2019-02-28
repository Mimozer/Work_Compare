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

        // Метод по клику Шаг1 берет из заданной директории файлы всех видов,
        // отделяет их имена, время последнего изменения, и число строк,
        // и выписывает в текст-боксе.
        public void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            folderBrowserDialog1.ShowDialog();
            var nameFold1 = folderBrowserDialog1.SelectedPath;
            DirectoryInfo dirName1 = new DirectoryInfo(nameFold1);
            textBox1.Text = "Путь: " + nameFold1 + "\r\n \r\n";
            foreach (var file1 in dirName1.GetFiles("*.*"))
            {
                string fileName1 = file1.Name; // Переменная хранит имя файла.
                var fileDate1 = file1.LastWriteTime; // Переменная хранит время изменения.
                int fileCount1 = System.IO.File.ReadAllLines(nameFold1 + "\\" + fileName1).Length; // Читаем файл, сохраняем в массив, считаем число строк по числу элементов.
                textBox1.Text += "Имя: " + fileName1 + " | Время: " + fileDate1 + " | Число строк:" + fileCount1 + "\r\n";
                string Array1 = fileName1 + " " + fileDate1 + " " + fileCount1;
            }
        }

        // Шаг 2 аботает аналогично с button1_Click, только для 2 текстового поля.
        public void button2_Click(object sender, EventArgs e) 
        {
            textBox2.Clear();
            folderBrowserDialog2.ShowDialog();
            var nameFold2 = folderBrowserDialog2.SelectedPath;
            DirectoryInfo dirName2 = new DirectoryInfo(nameFold2);
            textBox2.Text = "Путь: " + nameFold2 + "\r\n \r\n";
            foreach (var file2 in dirName2.GetFiles("*.*"))
            {
                string fileName2 = file2.Name;
                var fileDate2 = file2.LastWriteTime;
                int fileCount2 = System.IO.File.ReadAllLines(nameFold2 + "\\" + fileName2).Length;
                textBox2.Text += "Имя: " + fileName2 + " | Время: " + fileDate2 + " | Число строк:" + fileCount2 + "\r\n";
                string Array2 = fileName2 + " " + fileDate2 + " " + fileCount2;
            }
        }
 
        // Метод для ввода добавочного номера к именам файлов.
        public void button3_Click(object sender, EventArgs e)
        {
        //    string Number = ;
        }

        // Метод для сравнения двух массивов, полученных ранее, и вывод в чек-лист.
        private void button4_Click(object sender, EventArgs e)
        {
            //string Array3 = ;
            //checkedListBox1.Items.Clear();
            //checkedListBox1.Items.AddRange = ;
        }

        // Метод для перемещения файлов из каталога1 в каталог2 с добавлением в имя файла добавочного номера.
        private void button5_Click(object sender, EventArgs e)
        {
            //for ()
            //{
            //}
        }

        // Метод для закрытия приложения.
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}