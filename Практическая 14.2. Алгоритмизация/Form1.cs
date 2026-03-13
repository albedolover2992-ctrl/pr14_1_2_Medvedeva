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


namespace Практическая_14._2._Алгоритмизация
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {

            string text1 = textBox1.Text;
            using (StreamWriter wr = File.CreateText("t.txt"))
            {
                wr.WriteLine(text1);
            }
            MessageBox.Show("Файл записан");
            using (StreamReader reader = File.OpenText("t.txt"))
            {
               Stack<int> Open = new Stack<int>();
                bool res = true;
                string text = reader.ReadLine();
            for (int i = 0; i <text.Length; i++)
            {
                char letter = text[i];
                if (letter == '(')
                {
                    Open.Push(i);
                }
                else if (letter == ')')
                {
                    if (Open.Count == 0)
                    {
                        MessageBox.Show($"Лишняя ) на позиции {i + 1}");
                        res = false;
                    }    

                    if (Open.Count > 0)
                    {
                        if (i == Open.Peek() + 1)
                        {
                            MessageBox.Show($"Введите что-то кроме скобок на ползициях {i - 1} и {i} ");
                            res = false;
                        }
                        Open.Pop();
                    }
                }
            }
            if (Open.Count != 0)
            {
                MessageBox.Show($"Лишняя ( на позиции {Open.Peek()}");
                res = false;
            }
            if (res == true)
            {
                using (StreamWriter wr = File.AppendText("t1.txt"))
                {
                    wr.WriteLine(text);
                }
                MessageBox.Show("Выражение добавлено в файл t1.txt");
            }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
