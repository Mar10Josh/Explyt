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

        private void button1_Click(object sender, EventArgs e)
        {
           
            String han = "fastColoredTextBox1";
            String txt = "game.Players." + textBox1.Text + ":Kick(\"you were kicked. lol.\")";
            Form1.FromChildHandle((IntPtr)Marshal.StringToHGlobalAnsi(han)).Text = txt;
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
