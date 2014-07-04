using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SampleGUIApp
{
    public partial class Control1 : UserControl
    {
        public Control1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button2");
        }
    }
}
