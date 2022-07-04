using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Explyt
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private Form1 mainForm = null;
        public Form2(Form callingForm)
        {
            mainForm = callingForm as Form1;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.mainForm.Code = "game.Players." + textBox1.Text + ":Kick(\"Insert KICK reason\")";
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
