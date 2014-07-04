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
    public partial class Control2 : UserControl
    {
        public Control2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Item Checked: "+ checkBox1.Checked);   //Displays the status of the checkbox
        }
    }
}
