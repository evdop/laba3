using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int len_pass = (int)numericUpDown1.Value; //переменная равная длине паролей

            int quantity = (int)numericUpDown2.Value; //переменная равная количество паролей

            bool symbols = checkBox1.Checked; //проверка нажатия checkBox1

            Random rand = new Random(); //создание объекта для генерации символов

            for (int j = 0; j < quantity; j++) // функция, генерирующая несколько паролей

            {

                for (int i = 0; i < len_pass; i++) //функция, генерирующая длину паролей

                {

                    {

                        int value = rand.Next(0, 9); //получить случайное число от 0 до 9

                        richTextBox1.Text += value.ToString(); //вывод числа в richTextBox1


                    }

                    if (symbols == true) //если стоит галочка в checkBox1

                    {

                        char value = (char)rand.Next(33, 125); //генерация символов с позиции 33 до 125

                        if (value == '\\' || value == '/') // если переменная равна / или \, то

                        {

                            value = (char)rand.Next(33, 91); // генерируем переменную с позиции 33 до 91

                            richTextBox1.Text += value.ToString(); //вывод символов в  richTextBox1

                        }

                        else //иначе

                        {

                            richTextBox1.Text += value.ToString(); //вывод символов в  richTextBox1

                        }

                    }

                }

                richTextBox1.Text += "\n"; // перенос строки после работы цикла

            }

        }

    }

}
