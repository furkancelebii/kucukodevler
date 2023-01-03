using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deneme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[,] matrisa,matrisb,toplam,carpma;
        private void button2_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox2.Text);
            int b = int.Parse(textBox1.Text);
            matrisa = new int[a, b];
            for(int i = 0; i < a; i++)
            {
                for(int j = 0; j < b; j++)
                {
                    matrisa[i, j] = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("A matrisinin "+(i + 1)+".satır" + (j + 1) + ".sütuna sayı giriniz:", "Sayı giriniz:.", " ", 40, 40));
                    textBox6.Text = textBox6.Text + matrisa[i, j]+" ";
                }
                textBox6.Text = textBox6.Text + "\r\n";
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox4.Text);
            int y = int.Parse(textBox3.Text);
            matrisb = new int[x,y];
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    matrisb[i, j] = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("B matrisinin " + (i + 1) + ".satır" + (j + 1) + ".sütuna sayı giriniz:", "Sayı giriniz:.", " ", 40, 40));
                    textBox5.Text = textBox5.Text + matrisb[i, j] + " ";
                }
                textBox5.Text = textBox5.Text + "\r\n";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            int a = int.Parse(textBox2.Text);
            int b = int.Parse(textBox1.Text);
            matrisa = new int[a, b];
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {

                    int k= matrisa[0, 0] + matrisa[a,b]+ matrisa[0, b]+ matrisa[a, 0];
                    textBox6.Text = textBox6.Text + k ;
                }
                
            }
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox4.Text);
            int b = int.Parse(textBox3.Text);

            toplam = new int[a, b];
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    toplam[i, j] = matrisa[i, j] + matrisb[i, j];
                    textBox7.Text = textBox7.Text + toplam[i, j] + " ";
                }
                textBox7.Text = textBox7.Text + "\r\n";
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox2.Text);
            int y = int.Parse(textBox3.Text);
            carpma = new int[a, y];
        
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    carpma[i, j] = matrisa[i, j] * matrisb[i, j];
                    textBox7.Text = textBox7.Text + carpma[i, j] + " ";
                }
                textBox7.Text = textBox7.Text + "\r\n";
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        
    }
}
