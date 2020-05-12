using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6._3F
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int[,] Input(out int n, out int m)
        {
            Random rnd = new Random();
            n = Convert.ToInt32(N.Text);
            m = Convert.ToInt32(M.Text);
            int[,] a = new int[n, m];
            for (int i = 0; i < n; ++i)
                for (int j = 0; j < m; ++j)
                {
                    a[i, j] = rnd.Next(0,50);
                }
            return a;
        }
        private void Print(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); ++i, V.Text += Environment.NewLine)
                for (int j = 0; j < a.GetLength(1); ++j)
                    V.Text += a[i, j] + "  ";
        }
        private void Change(int[,] a)
        {
            V.Text += Environment.NewLine;
            int max, sum = 0;
            int s = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                max = a[i, 0];
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] > max) max = a[i, j];
                }
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] == max)
                    {
                        sum += max;
                        s++;
                        if (s == a.GetLength(1)) break;
                    }
                }
                if (s == a.GetLength(1)) break;
            }
            V.Text += "Summa = " + sum;
        }

        private void Жми_Click(object sender, EventArgs e)
        {
            try
            {
                V.Text = "";
                int m, n;
                int[,] mas = Input(out n, out m);
                Print(mas);
                Change(mas);
            }
            catch
            {
                V.Text = "Неккоректные данные";
            }
        }
    }
}
