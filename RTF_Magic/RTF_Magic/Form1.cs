using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RTF_Magic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //-------------------------------//
            this.button1.Enabled = false;
            this.button1.Refresh();
            this.panel1.Visible= true;
            this.panel1.Refresh();
            this.label1.Refresh();
            this.label2.Refresh();
            //------------------------------//
            string x;
            x = Application.StartupPath + "\\First.rtf";
            this.richTextBox1.LoadFile(x);
            //----------------------------//
            this.panel1.Visible = false;
            this.button1.Enabled=true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.colorDialog1.ShowDialog();
            this.richTextBox1.SelectionColor = this.colorDialog1.Color;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.colorDialog1.ShowDialog();
            this.richTextBox1.SelectionBackColor = this.colorDialog1.Color;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.fontDialog1.ShowDialog();
            this.richTextBox1.SelectionFont = this.fontDialog1.Font;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if(this.richTextBox1.SelectionBullet == true)//Checks if the selected tect has bullets
            {
                this.richTextBox1.SelectionBullet=false;//This removes the Bullets
            }
            else
            {
                this.richTextBox1.SelectionBullet=true;// This one adds the bullets
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int x;
            x = this.richTextBox1.SelectionIndent;
            x = x + 10;
            this.richTextBox1.SelectionIndent = x;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int x;
            x= this.richTextBox1.SelectionIndent;
            x= x - 10;
            this.richTextBox1.SelectionIndent = x;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Copy();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Paste();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Undo();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Redo();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.saveFileDialog1.ShowDialog();
            string fn;
            fn= this.saveFileDialog1.FileName + ".rtf";
            this.panel1.Visible= true;
            this.label2.Text = "Saving...";
            this.panel1.Refresh();
            this.richTextBox1.SaveFile(fn);
            this.panel1.Visible= false;
            this.label2.Text = "Loading...";
        }
    }
}
