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
using System.Security;

namespace SimpleReplacement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string text;
        private string alphabet;
        private string replacement;
        Element element;
        Coder coder;

        private void DecodingTextClick(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)//Заупуск окно выбора файла
            {
                //загружаем текст
                try
                {
                    var filePath = openFileDialog.FileName;//Путь к файлу
                    using (StreamReader str = new StreamReader(filePath))//Считывание из файла в перменную
                    {
                        text = str.ReadToEnd();
                    }
                }
                catch (SecurityException ex)//Вывод ошибки
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }

                //загружаем алфавит обычный
                try
                {
                    var filePath = "C:\\Users\\Жопчики\\Desktop\\Даша\\projects with git\\оттик лр 4\\SimpleReplacement\\SimpleReplacement\\readingFiles\\alphabet.txt";//Путь к файлу
                    using (StreamReader str = new StreamReader(filePath))//Считывание из файла в перменную
                    {
                        alphabet = str.ReadToEnd();
                    }
                }
                catch (SecurityException ex)//Вывод ошибки
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }

                //загружаем алфавит с перестановками
                try
                {
                    var filePath = "C:\\Users\\Жопчики\\Desktop\\Даша\\projects with git\\оттик лр 4\\SimpleReplacement\\SimpleReplacement\\readingFiles\\replacement.txt";//Путь к файлу
                    using (StreamReader str = new StreamReader(filePath))//Считывание из файла в перменную
                    {
                        replacement = str.ReadToEnd();
                    }
                }
                catch (SecurityException ex)//Вывод ошибки
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
                coder = new Coder(alphabet, replacement);
                coder.Decode(text);
            }
        }
        private void CodingTextClick(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)//Заупуск окно выбора файла
            {
                //загружаем текст
                try
                {
                    var filePath = openFileDialog.FileName;//Путь к файлу
                    using (StreamReader str = new StreamReader(filePath))//Считывание из файла в перменную
                    {
                        text = str.ReadToEnd();
                    }
                }
                catch (SecurityException ex)//Вывод ошибки
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }

                //загружаем алфавит обычный
                try
                {
                    var filePath = "C:\\Users\\Жопчики\\Desktop\\Даша\\projects with git\\оттик лр 4\\SimpleReplacement\\SimpleReplacement\\readingFiles\\alphabet.txt";//Путь к файлу
                    using (StreamReader str = new StreamReader(filePath))//Считывание из файла в перменную
                    {
                        alphabet = str.ReadToEnd();
                    }
                }
                catch (SecurityException ex)//Вывод ошибки
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }

                //загружаем алфавит с перестановками
                try
                {
                    var filePath = "C:\\Users\\Жопчики\\Desktop\\Даша\\projects with git\\оттик лр 4\\SimpleReplacement\\SimpleReplacement\\readingFiles\\replacement.txt";//Путь к файлу
                    using (StreamReader str = new StreamReader(filePath))//Считывание из файла в перменную
                    {
                        replacement = str.ReadToEnd();
                    }
                }
                catch (SecurityException ex)//Вывод ошибки
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
                try
                {
                    coder = new Coder(alphabet, replacement);
                    coder.Encode(text);
                }
                catch (SecurityException ex)//Вывод ошибки
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }
    }
}
