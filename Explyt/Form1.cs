using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeAreDevs_API;

namespace Explyt
{
    public partial class Form1 : Form

        
    {
        ExploitAPI api = new ExploitAPI();
        
        public Form1()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            api.LaunchExploit();
            fastColoredTextBox1.Language = FastColoredTextBoxNS.Language.Lua;
        }


        
        private void button2_Click(object sender, EventArgs e)
        {
            if (api.isAPIAttached())
            {
                api.SendLuaScript(fastColoredTextBox1.Text);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }
        

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        public string Code
        {
            get { return fastColoredTextBox1.Text; }
            set { fastColoredTextBox1.Text = value; }
            
        }

        // Note the msgbox's Y is 476 when started
 

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            api.LaunchExploit();
            
            fastColoredTextBox1.Language = FastColoredTextBoxNS.Language.Lua;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            api.LaunchExploit();
            fastColoredTextBox1.Language = FastColoredTextBoxNS.Language.Lua;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
        }

        private void button_WOC2_Click(object sender, EventArgs e)
        {
            if (!api.isAPIAttached())
            {
                
            }
        }
    }
}
