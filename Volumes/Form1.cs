using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Volumes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //Declare radius value
            double Radius;

            //Read value from textbox
            try
            {
                Radius = double.Parse(textBox1.Text);
            }

            catch
            {
                MessageBox.Show("Type a number in the radius box");
                Radius = 0.0;
            }

            //Calculate volume
            double Volume = 4.0 / 3.0 * Math.PI * Radius * Radius * Radius;
            
            //Dsiplay volume
            label1.Text = " Volume = " + Volume + "m^3.";
        }
    }
}

  

    

