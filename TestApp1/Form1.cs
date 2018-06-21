using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TestApp1
{


    public partial class Form1 : Form
    {
        List<Turtle> Turtles;
        
        public Form1()
        {
            InitializeComponent();
            label1.Text = "This character wears (Color) clothes.";
            Turtles = new List<Turtle>
            {
                new Turtle(){name = "Leo", color="Blue" },
                new Turtle(){name = "Raphael", color="Red" },
                new Turtle(){name = "Mikey", color="Orange" },
                new Turtle(){name = "Donatello", color="Purple" },
                new Turtle(){name = "Splinter", color="Brown" },
                new Turtle(){name = "April", color="Yellow" },
            };
            comboBox1.DataSource = Turtles;
            comboBox1.DisplayMember = "name";
            comboBox1.ValueMember = "color";
        }

        private void Leo_Click(object sender, EventArgs e)
        {
            words();
        }

        private void Raphael_Click(object sender, EventArgs e)
        {
            words();
        }

        private void Mikey_Click(object sender, EventArgs e)
        { 
            words();
        }

        private void Donatello_Click(object sender, EventArgs e)
        {

            words();
        }

        private void Splinter_Click(object sender, EventArgs e)
        {

            words();
        }

        private void April_Click(object sender, EventArgs e)
        {

            words();
        }

        private void words()
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = string.Format("{0} wears {1} clothes.", comboBox1.SelectedText, comboBox1.SelectedValue);
            label1.BackColor = Color.FromName(comboBox1.SelectedValue.ToString());

        }
    }

}
