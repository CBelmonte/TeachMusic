/*
 * Author : Carmine Belmonte
 * Version: 2.0.0
 * date Modified 2013-7-16
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace WindowsFormsApplication1
{
    public partial class Main : Form
    {
        int score = 0;
        string ImageNum = "";
        int randomNumber = 0;

        public Main()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {
                        
        }
        private void button1_Click(object sender, EventArgs e)
        {
        	next();
        }
        public void next(){
        ImageNum = "";
            Random random = new Random();
            randomNumber = random.Next(0, 9);
            button2.Visible = true;

            if (ChkF.Checked==true)
            {
                FClefPic();
            }
            else
            {
                GClefPic();
            }
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (ChkG.Checked == true)
            {
                GClef();
            }
            else if (ChkF.Checked == true)
            {
                FClef();
            }
            next();
        }
        private void radioButtonA_CheckedChanged(object sender, EventArgs e)
        {
            
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        public void FClefPic()
        {
            if (randomNumber == 0)
            {
                ImageNum = "BA";
            }
            else if (randomNumber == 1)
            {
                ImageNum = "BB";
            }
            else if (randomNumber == 2)
            {
                ImageNum = "BC";
            }
            else if (randomNumber == 3)
            {
                ImageNum = "BD";
            }
            else if (randomNumber == 4)
            {
                ImageNum = "BE";

            }
            else if (randomNumber == 5)
            {
                ImageNum = "BF";
            }
            else if (randomNumber == 6)
            {
                ImageNum = "BG";
            }
            else if (randomNumber == 7)
            {
                ImageNum = "BE2";
            }
            else if (randomNumber == 8)
            {
                ImageNum = "BF2";
            }
            else
            {
                ImageNum = "BG2";
            }

            label1.Image = (Image) Properties.Resources.ResourceManager.GetObject(ImageNum);
        }
        public void GClefPic()
        {
            if (randomNumber == 0)
            {
                ImageNum = "TA";
            }
            else if (randomNumber == 1)
            {
                ImageNum = "TB";
            }
            else if (randomNumber == 2)
            {
                ImageNum = "TC";
            }
            else if (randomNumber == 3)
            {
                ImageNum = "TD";
            }
            else if (randomNumber == 4)
            {
                ImageNum = "TE";

            }
            else if (randomNumber == 5)
            {
                ImageNum = "TF";
            }
            else if (randomNumber == 6)
            {
                ImageNum = "TG";
            }
            else if (randomNumber == 7)
            {
                ImageNum = "TE2";
            }
            else if (randomNumber == 8)
            {
                ImageNum = "TF2";
            }
            else
            {
                ImageNum = "TG2";
            }

            label1.Image = (Image) Properties.Resources.ResourceManager.GetObject(ImageNum);
        }
        public void GClef()
        {
            button2.Visible = false;
            if (randomNumber == 0 && radioButtonA.Checked == true)
            {
                score = score + 10;
                textBox1.Text = score.ToString();
            }
    else if (randomNumber == 1 && radioButtonB.Checked == true)
    {
        score = score + 10;
        textBox1.Text = score.ToString();
    }
    else if (randomNumber == 2 && radioButtonC.Checked == true)
    {
        score = score + 10;
        textBox1.Text = score.ToString();
    }
    else if (randomNumber == 3 && radioButtonD.Checked == true)
    {
        score = score + 10;
        textBox1.Text = score.ToString();
    }
    else if (randomNumber == 4 && radioButtonE.Checked == true)
    {
        score = score + 10;
        textBox1.Text = score.ToString();
    }
    else if (randomNumber == 5 && radioButtonF.Checked == true)
    {
        score = score + 10;
        textBox1.Text = score.ToString();
    }
    else if (randomNumber == 6 && radioButtonG.Checked == true)
    {
        score = score + 10;
        textBox1.Text = score.ToString();
    }
    else if (randomNumber == 7 && radioButtonE.Checked == true)
    {
        score = score + 10;
        textBox1.Text = score.ToString();
    }
    else if (randomNumber == 8 && radioButtonF.Checked == true)
    {
        score = score + 10;
        textBox1.Text = score.ToString();
    }
    else if (randomNumber == 9 && radioButtonG.Checked == true)
    {
        score = score + 10;
        textBox1.Text = score.ToString();


    }
    else
    {
        MessageBox.Show("OOoooo   You almost had it!  That was a tough one  Try again");
    }
    if (score == 100)
    {
        textBox1.Text = ("YOU ROCK DUDE" + Environment.NewLine + "Try again!!");
        score = 0;
    }
        }
        public void FClef()
        {

            {
                button2.Visible = false;
                if (randomNumber == 0 && radioButtonA.Checked == true)
                {
                    score = score + 10;
                    textBox1.Text = score.ToString();
                }
                else if (randomNumber == 1 && radioButtonB.Checked == true)
                {
                    score = score + 10;
                    textBox1.Text = score.ToString();
                }
                else if (randomNumber == 2 && radioButtonC.Checked == true)
                {
                    score = score + 10;
                    textBox1.Text = score.ToString();
                }
                else if (randomNumber == 3 && radioButtonD.Checked == true)
                {
                    score = score + 10;
                    textBox1.Text = score.ToString();
                }
                else if (randomNumber == 4 && radioButtonE.Checked == true)
                {
                    score = score + 10;
                    textBox1.Text = score.ToString();
                }
                else if (randomNumber == 5 && radioButtonF.Checked == true)
                {
                    score = score + 10;
                    textBox1.Text = score.ToString();
                }
                else if (randomNumber == 6 && radioButtonG.Checked == true)
                {
                    score = score + 10;
                    textBox1.Text = score.ToString();
                }
                else if (randomNumber == 7 && radioButtonE.Checked == true)
                {
                    score = score + 10;
                    textBox1.Text = score.ToString();
                }
                else if (randomNumber == 8 && radioButtonF.Checked == true)
                {
                    score = score + 10;
                    textBox1.Text = score.ToString();
                }
                else if (randomNumber == 9 && radioButtonG.Checked == true)
                {
                    score = score + 10;
                    textBox1.Text = score.ToString();


                }
                else
                {
                    MessageBox.Show("OOoooo   You almost had it!  That was a tough one  Try again");
                }
                if (score == 100)
                {
                    textBox1.Text = ("YOU ROCK DUDE" + Environment.NewLine + "Try again!!");
                    score = 0;
                }
            }
        }
        private void ChkG_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkG.Checked==true)
            {
                ChkF.Checked = false;
            }
        }
        private void ChkF_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkF.Checked==true)
            {
                ChkG.Checked = false;
            }
        }
    }
}
