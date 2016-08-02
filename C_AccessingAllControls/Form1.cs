using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_AccessingAllControls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       //Acceses all controls including the control in the GroupBox.
        private void button1_Click(object sender, EventArgs e)
        {
            AccessAll(this.Controls);
        }
        void AccessAll(Control.ControlCollection cc)
        {
           foreach (Control c in cc)
            {
                c.Text = "Changed Text";
                if (c.HasChildren) AccessAll(c.Controls);
            }
        }
    }
}
