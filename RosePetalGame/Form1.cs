using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RosePetalGame
{
    public partial class Form1 : Form
    {

        Die die1 = new Die();
        Die die2 = new Die();
        Die die3 = new Die();
        Die die4 = new Die();
        Die die5 = new Die();

        public Form1()
        {
           
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            die1.Roll();
            die2.Roll();
            die3.Roll();
            die4.Roll();
            die5.Roll();


            label1.Text = die1.FaceValue.ToString();
            label2.Text = die2.FaceValue.ToString();
            label3.Text = die3.FaceValue.ToString();
            label4.Text = die4.FaceValue.ToString();
            label5.Text = die5.FaceValue.ToString();

            switch (die1.FaceValue)
            {
                case 1: pictureBox1.ImageLocation = "M:\\FreeLance\\Next Level Gaming\\RosePetalGame\\RosePetalGame\\Images\\Die1.jpg";
                        pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
                    break;
                case 2: pictureBox1.ImageLocation = "M:\\FreeLance\\Next Level Gaming\\RosePetalGame\\RosePetalGame\\Images\\Die2.jpg";
                    pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
                    break;
                case 3: pictureBox1.ImageLocation = "M:\\FreeLance\\Next Level Gaming\\RosePetalGame\\RosePetalGame\\Images\\Die3.jpg";
                    pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
                    break;
                case 4: pictureBox1.ImageLocation = "M:\\FreeLance\\Next Level Gaming\\RosePetalGame\\RosePetalGame\\Images\\Die4.jpg";
                    pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
                    break;
                case 5: pictureBox1.ImageLocation = "M:\\FreeLance\\Next Level Gaming\\RosePetalGame\\RosePetalGame\\Images\\Die5.jpg";
                    pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
                    break;
                case 6: pictureBox1.ImageLocation = "M:\\FreeLance\\Next Level Gaming\\RosePetalGame\\RosePetalGame\\Images\\Die6.jpg";
                    pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
                    break;
            }

        }
    }
}
