//Sample app to show switching between different user controls (e.g. for a wizard type application)

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SampleGUIApp
{
    public partial class Form1 : Form
    {
        Control2 control2 = new Control2(); //Keep a reference to control2 so we dont need to create it each time.
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*Next Button*/
            this.Controls.Remove(control11);    //remove the first control.
            this.Controls.Add(control2);        //add second control
            button2.Enabled = true;             //set button state
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*Prev Button*/
            this.Controls.Remove(control2);    //remove the second control.
            this.Controls.Add(control11);       //add first control
            button1.Enabled = true;             //set button state
            button2.Enabled = false;
        }
    }
}
