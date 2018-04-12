using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Android_ID_Changer
{
    public partial class fmGUI : Form
    {
        string SSAID_XML = null;

        public fmGUI()
        {
            InitializeComponent();
            Icon = Properties.Resources.favicon;
        }

        private async void btn_check_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
            var log = await Task.Run(()=> Tool.ADB("devices"));
            var regex = new Regex(@"(\w+)\tdevice");
            var match = regex.Match(log);
            if (!match.Success)
            {
                label_Info.Text = "No device detect!";
                return;
            }
            var sn = match.Groups[1].Value;
            Tool.SN = sn;
            log = await Task.Run(() => Tool.ADBShell("getprop ro.build.version.sdk"));
            var sdk = int.Parse(log);
            if (sdk >= 26)
            {
                groupBox3.Enabled = true;
                btn_func3_read.Focus();
            }
            else if (sdk >= 21)
            {
                groupBox2.Enabled = true;
                btn_func2_read.Focus();
            }
            else if (sdk >= 14)
            {
                groupBox1.Enabled = true;
                btn_func1_read.Focus();
            }
            label_Info.Text = $"Device: {sn}    API: {sdk}";
        }

        private async void btn_func1_read_Click(object sender, EventArgs e)
        {
            btn_func1_read.Enabled = false;
            text_func1_old.Text = null;
            text_func1_new.Text = null;
            var id = await Task.Run(() => Tool.ReadID(1));
            text_func1_old.Text = id;
            btn_func1_read.Enabled = true;
            btn_func1_write.Enabled = true;
            text_func1_new.Focus();
        }

        private async void btn_func1_write_Click(object sender, EventArgs e)
        {
            btn_func1_write.Enabled = false;
            var regex = new Regex("[0-9A-Fa-f]{16}");
            var new_id = text_func1_new.Text;
            var match = regex.Match(new_id);
            if (!match.Success)
            {
                MessageBox.Show("Android ID format incorrect, must be 16 hex digits!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                btn_func1_write.Enabled = true;
                return;
            }
            await Task.Run(() => Tool.WriteID(1, new_id));
            text_func1_old.Text = await Task.Run(() => Tool.ReadID(1));
            text_func1_new.Text = null;
            btn_func1_write.Enabled = true;
        }

        private async void btn_func2_read_Click(object sender, EventArgs e)
        {
            btn_func2_read.Enabled = false;
            text_func2_old.Text = null;
            text_func2_new.Text = null;
            var id = await Task.Run(() => Tool.ReadID(2));
            text_func2_old.Text = id;
            btn_func2_read.Enabled = true;
            btn_func2_write.Enabled = true;
            text_func2_new.Focus();
        }

        private async void btn_func2_write_Click(object sender, EventArgs e)
        {
            btn_func2_write.Enabled = false;
            var regex = new Regex("[0-9A-Fa-f]{16}");
            var new_id = text_func2_new.Text;
            var match = regex.Match(new_id);
            if (!match.Success)
            {
                MessageBox.Show("Android ID format incorrect, must be 16 hex digits!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                btn_func2_write.Enabled = true;
                return;
            }
            await Task.Run(() => Tool.WriteID(2, new_id));
            text_func2_old.Text = await Task.Run(() => Tool.ReadID(2));
            text_func2_new.Text = null;
            btn_func2_write.Enabled = true;
        }

        private async void btn_func3_read_Click(object sender, EventArgs e)
        {
            btn_func3_read.Enabled = false;
            text_func3_old.Text = null;
            text_func3_new.Text = null;
            listBox_package.Items.Clear();
            await Task.Run(() => Tool.ADBShell("dd if=/data/system/users/0/settings_ssaid.xml of=/sdcard/settings_ssaid.xml", true));
            await Task.Run(() => Tool.ADB("pull /sdcard/settings_ssaid.xml"));
            await Task.Run(() => Tool.ADBShell("rm /sdcard/settings_ssaid.xml"));
            if (!File.Exists("settings_ssaid.xml"))
            {
                MessageBox.Show("Cannot read settings_ssaid.xml", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                btn_func3_read.Enabled = true;
                return;
            }
            var regex = new Regex("value=\"([0-9A-Fa-f]+)\" package=\"(\\S+)\" defaultValue=\"([0-9A-Fa-f]+)\"");
            SSAID_XML = File.ReadAllText("settings_ssaid.xml");
            File.Delete("settings_ssaid.xml");
            var sr = new StringReader(SSAID_XML);
            string line = null;
            while ((line = sr.ReadLine()) != null)
            {
                if (regex.IsMatch(line))
                {
                    var match = regex.Match(line);
                    listBox_package.Items.Add(new Item(match.Groups[1].Value, match.Groups[2].Value, match.Groups[3].Value));
                }
            }
            listBox_package.SelectedIndex = 0;
            btn_func3_read.Enabled = true;
            btn_func3_write.Enabled = true;
            btn_func3_save.Enabled = true;
        }

        private void listBox_package_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = listBox_package.SelectedItem as Item;
            text_func3_old.Text = item.value;
            text_func3_new.Text = null;
            text_func3_new.Focus();
        }

        private void btn_func3_save_Click(object sender, EventArgs e)
        {
            var regex = new Regex("[0-9A-Fa-f]{16}");
            var new_id = text_func3_new.Text;
            var match = regex.Match(new_id);
            if (!match.Success)
            {
                MessageBox.Show("Android ID format incorrect, must be 16 hex digits!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            var item = listBox_package.SelectedItem as Item;
            if (item.value.Length != new_id.Length)
            {
                MessageBox.Show("Android ID length not matched!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            SSAID_XML = SSAID_XML.Replace(item.value, new_id).Replace(item.defaultValue, new_id);
            item.value = new_id;
            text_func3_old.Text = item.value;
            text_func3_new.Text = null;
        }

        private async void btn_func3_write_Click(object sender, EventArgs e)
        {
            btn_func3_write.Enabled = false;
            File.WriteAllText("settings_ssaid.xml", SSAID_XML);
            await Task.Run(() => Tool.ADB("push settings_ssaid.xml /sdcard/"));
            File.Delete("settings_ssaid.xml");
            await Task.Run(() => Tool.ADBShell("dd if=/sdcard/settings_ssaid.xml of=/data/system/users/0/settings_ssaid.xml", true));
            await Task.Run(() => Tool.ADBShell("chmod 600 /data/system/users/0/settings_ssaid.xml", true));
            await Task.Run(() => Tool.ADBShell("rm /sdcard/settings_ssaid.xml"));
            btn_func3_write.Enabled = true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://htcfz.wordpress.com/");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.facebook.com/profile.php?id=100005653172695");
        }
    }
}
