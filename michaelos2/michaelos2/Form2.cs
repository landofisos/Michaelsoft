using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace michaelos2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Form1 obj = (Form1)Application.OpenForms["Form1"];
            obj.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            browser childForm = new browser(); //initialize a child form

            childForm.TopLevel = false; //set it's TopLevel to false

            Controls.Add(childForm); //and add it to the parent Form
            childForm.Show(); //finally display it

            childForm.BringToFront();
        }
    }
}
