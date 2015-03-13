using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carlosForm
{
    public partial class Form1 : Form
    {
        int inside, iteration = 100, radius;
        double randomNumberOne, randomNumberTwo, diagonaleLengthOfRandomNumber, areaOfQuterTriangle, pai;
        double averageePai = 0, result;

        Graphics graph;

        public Form1()
        {
            InitializeComponent();
            graph = graphArea.CreateGraphics();
        }
        TextBox text = new TextBox();


        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void retriveInput_Click(object sender, EventArgs e)
        {

            radius = Int32.Parse(inputText.Text);
            Form1 obj = new Form1();
            result = obj.getPai(radius);
            labelPai.Text = "Average of Pai=" + this.result;


           
        

           
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        Random rnd = new Random();
        private double getPai(int radius)
        {
            for (int i = 0; i < 100; i++)
            {
                inside = 0;
                for (int ctr = 1; ctr <= iteration; ctr++)
                {
                    randomNumberOne = (double)rnd.NextDouble() * radius;
                    randomNumberTwo = (double)rnd.NextDouble() * radius;
                    diagonaleLengthOfRandomNumber = Math.Sqrt((randomNumberOne * randomNumberOne) + (randomNumberTwo * randomNumberTwo));
                    if (diagonaleLengthOfRandomNumber < radius)
                    {
                        inside++;
                    }
                }
                areaOfQuterTriangle = (inside * (radius * radius)) / iteration;
                pai = (4 * areaOfQuterTriangle) / (radius * radius);
                averageePai = averageePai + pai;
            }
            averageePai = averageePai / 100;
            return averageePai;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }






    }


}
