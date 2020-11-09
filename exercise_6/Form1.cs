using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace exercise_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_test1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Text = File.ReadAllText(@"C:\Users\boysa\Documents\Visual Studio 2012\Projects\exercise_6\Test1.txt");

        }

        private void button2_test2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Text = File.ReadAllText(@"C:\Users\boysa\Documents\Visual Studio 2012\Projects\exercise_6\Test2.txt");
        }

        private void button3_test3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Text = File.ReadAllText(@"C:\Users\boysa\Documents\Visual Studio 2012\Projects\exercise_6\Test3.txt");
        }

        private void button4_test4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Text = File.ReadAllText(@"C:\Users\boysa\Documents\Visual Studio 2012\Projects\exercise_6\Test4.txt");
        }

        private void button5_test5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Text = File.ReadAllText(@"C:\Users\boysa\Documents\Visual Studio 2012\Projects\exercise_6\Test5.txt");
        }

        private void button6_test6_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Text = File.ReadAllText(@"C:\Users\boysa\Documents\Visual Studio 2012\Projects\exercise_6\Test6.txt");
        }

        private void button_Parser_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Моля изберете файл от Тест 1 до Тест 6.", "Празна текстова кутия !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Stopwatch watch = new Stopwatch();
                String text = textBox1.Text;
                linkLabel1.Text = "";
                watch.Start();
                Scanner.input(text, linkLabel1, dataGridView1);
                watch.Stop();
                label_parseTiming.Text = watch.Elapsed.ToString();
            }
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            Process.Start(linkLabel1.Text);
        }

        private void button_Verification_Click(object sender, EventArgs e)
        {

            int countStart = 0;
            int countEnd = 0;
            if (dataGridView1.DataSource == null)
            {
                MessageBox.Show("DataGridView е празен !!!", "Structural Verification error !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {

                    //if (row.Cells[2].Value == "Start")
                    //{
                    //    countStart++;
                    //}
                    //else if (row.Cells[2].Value == "End")
                    //{
                    //    countEnd++;
                    //}
                }
                

                if (countStart == countEnd)
                {
                    MessageBox.Show("Равен брой Start/End тагове: ", "Брой тагове: ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (countStart > countEnd)
                {
                    MessageBox.Show("По голям брой Start тагове с " + (countStart - countEnd).ToString(), "Брой тагове: ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (countEnd > countStart)
                {
                    MessageBox.Show("По голям брой End тагове с " + (countEnd - countStart).ToString(), "Брой тагове: ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            dataGridView1.DataSource = null;
            label_parseTiming.Text = "0";
            linkLabel1.Text = "";

        }



    }
}
