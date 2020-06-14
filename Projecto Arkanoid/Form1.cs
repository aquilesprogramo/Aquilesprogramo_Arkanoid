using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projecto_Arkanoid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            OptionUser optionUser = new OptionUser();
            optionUser.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Hay que agregar el botton 2
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}