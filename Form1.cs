// Ahmed Benyusuf
// Class and Section (CS 313 01)
// Assignment (Program 02 Chapter 02)
// Description of the Program: This program will present the setup and punchline for a funny joke. 



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C02_P02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SetupButton_Click(object sender, EventArgs e)
        {
            DisplayLabel.Text = "Why do cows wear bells?";
        }

        private void PunchLineButton_Click(object sender, EventArgs e)
        {
            DisplayLabel.Text = "Because their horns dont work.";
        }
    }
}
