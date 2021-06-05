using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostFileEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Program.AdminRelauncher();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label4.Hide();
            LoadHosts();
            removeBtn.Hide();
        }
        private void LoadHosts()
        {
            hostsBox.Clear();
            ipBox.Clear();
            hostBox.Clear();
            String[] hosts = Program.ReadHostFile();
            foreach (var item in hosts)
            {
                if (item.Trim().Length > 0)
                {
                    hostsBox.Text += item + "\n";
                }
                
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ipBox_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            String hosts = ipBox.Text + "\t" + hostBox.Text;
            if (hosts.Length > 8)
            {
                if (Program.ModifyHostsFile(hosts))
                {
                    Message("Success");
                   
                    LoadHosts();
                }
                else
                {
                    Message("Failed to save");
                }

            }
            else
            {
                Message("Ip address and host is empty!");
            }

           
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        public void Message(string text, bool messageBox = false)
        {
            if (messageBox)
            {
                MessageBox.Show(text);
                return;
            }
            label4.Text = text;
            label4.Show();
            var timer = new System.Windows.Forms.Timer();
            timer.Interval = 3000;
            timer.Tick += delegate (object sender, EventArgs args)
            {
                label4.Hide();
                timer.Stop();
            };
            timer.Start();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            LoadHosts();
            Message("Refress success!");
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Do You Want to delete "+ hostsBox.SelectedText+"?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result.Equals(DialogResult.OK))
            {
                if (Program.RemoveHost(hostsBox.SelectedText))
                {
                    Message("Selected host is successfully removed.");
                    LoadHosts();
                    return;
                }

                Message("Please select ip and host to remove");
            }
        }

        private void hostsBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void hostsBox_SelectionChanged(object sender, EventArgs e)
        {
            if(hostsBox.SelectedText.Length > 5)
            {
                removeBtn.Show();
            }
            else
            {
                removeBtn.Hide();
            }
        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }
    }
}
