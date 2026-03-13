using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практическая_14._3._Алгоритмизация
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string num = textBox1.Text;
                int n = Convert.ToInt32(num);
                while (n <= 0)
                {
                    textBox1.Text = ("Неверное n. Введите его вновь");
                    num = textBox1.Text;
                    n = Convert.ToInt32(num);
                }
                Queue<int> queue = new Queue<int>();
                for (int i = 0; i < n; i++)
                {
                    queue.Enqueue(i);
                }
                string text = $"n = {n} " +
                    $"\nРазмерность очереди {queue.Count} " +
                    $"\nВерхний элемент {queue.Peek()} " +
                    $"\nРазмерность очереди { queue.Count} " +
                    $"\nCодержимое очереди: "; 
                while (queue.Count > 0)
                {
                    int number = queue.Dequeue();
                    text += (number + " ");
                }
                text += $"\nНовая содержимость очереди {queue.Count} ";
                MessageBox.Show(text);
            }
            catch (Exception)
            {
                MessageBox.Show("Неверный формат данных");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
