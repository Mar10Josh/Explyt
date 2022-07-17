using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

// 2Ib

using System.Threading.Tasks;
using System.Windows.Forms;
using WeAreDevs_API;

// I hid a secret message using comments, find out what it is!

namespace Explyt
{

    //3ut

    public partial class Main : Form
    {
		ExploitAPI api = new ExploitAPI();
        public Main()
        {
            InitializeComponent();
        }

		protected override void WndProc(ref Message m)
		{
			switch (m.Msg)
			{
				case 0x84:
					base.WndProc(ref m);
					if ((int)m.Result == 0x1)
						m.Result = (IntPtr)0x2;
					return;
			}

			base.WndProc(ref m);
		}

        private void button_WOC1_Click(object sender, EventArgs e)
        {
			if (!api.isAPIAttached())
            {
				PopupAttachForm pleaseAttach = new PopupAttachForm();
				pleaseAttach.ShowDialog();
				System.Console.WriteLine("api not injected");
				return;
            }
			api.SendLuaScript(fastColoredTextBox1.Text);
        }

        private void fastColoredTextBox1_Load(object sender, EventArgs e)
        {

        }

        //6zUvU

        private void button_WOC2_Click(object sender, EventArgs e)
        {
			api.LaunchExploit();
        }

        //1Tr


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink("https://www.wearedevs.net");
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to open link that was clicked.");

            }
        }
            private void VisitLink(string link)
        {
            //5 o Waffle
            // Change the color of the link text by setting LinkVisited
            // to true.
            linkLabel1.LinkVisited = true;
            //Call the Process.Start method to open the default browser
            //with a URL:
            System.Diagnostics.Process.Start(link);
        }

        private void button_WOC3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_WOC4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Lua files (*.lua)|*.lua|All Files|*.*";
            openFileDialog1.ShowDialog();
            if (File.Exists(openFileDialog1.FileName))
            {
                fastColoredTextBox1.Text = File.ReadAllText(openFileDialog1.FileName);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (var sfd = new SaveFileDialog())
            {
                sfd.Filter = "Lua Files (*.lua)|*.lua|All Files|*.*";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(sfd.FileName, fastColoredTextBox1.Text);
                }
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            VisitLink("https://github.com/Mar10Josh/Explyt");
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //this.Close();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void injectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!api.isAPIAttached())
            {
                api.LaunchExploit();
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
             if (toolStripMenuItem2.Checked)
            {
                string prc = "RobloxPlayerBeta";
                if (Process.GetProcessesByName(prc).Length > 0)
                {
                    api.LaunchExploit();
                }
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You successfully enabled Auto-Inject. If Roblox is already running or will launch, please close Explyt and launch Explyt again when roblox launches.");
        }
    }
    //4 e t
}
