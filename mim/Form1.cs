using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Checkit choice = new Checkit();

        private void Button1_Click(object sender, EventArgs e)
        {

            if (radioButton1.Checked) numericUpDown1.Text = choice.Men;
            else if (radioButton2.Checked) numericUpDown1.Text = choice.Igu;
            else if (radioButton3.Checked) numericUpDown1.Text = choice.Mai;

            label1.Text = choice.escolha;

        }
    }
}
