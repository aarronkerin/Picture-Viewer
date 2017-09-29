using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            else
                pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
        }


        private void button3_Click(object sender, EventArgs e)//close button
        {
            pictureBox1.Image = null;
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            //show the open file dialog. if the user clicks Ok, load the 
            //picture the user chose.
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
           
        }

        private void backgroundButton_Click(object sender, EventArgs e)
        {
            //show the colour dialog box. if the user clicks ok, change
            //picturebox controls background to the colour the user chose.
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                pictureBox1.BackColor = colorDialog1.Color;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        

        
        

        }
    }
}
