//-----------------------------------------------------
// Coded by eduhdev12! Free to-do list source
// https://github.com/eduhdev12/to-do-list
// Note to the person using this, removing this
// text is in violation of the license you agreed
// to by downloading. Only you can see this so what
// does it matter anyways.
// Copyright © eduhdev12 2020
// Licensed under a MIT license
// Read the terms of the license here
// https://github.com/eduhdev12/
//-----------------------------------------------------


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList
{
    public partial class Main : MetroFramework.Forms.MetroForm
    {
        public Main()
        {
            InitializeComponent();
        }

        private void settingsbutton_Click(object sender, EventArgs e)
        {
            var Settings = new Settings();
            this.Hide();
            Settings.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.onebox == true)
            {

                metroCheckBox1.Visible = true;
                metroCheckBox1.Checked = Properties.Settings.Default.onemain;
            }
            else metroCheckBox1.Visible = false;
            metroCheckBox1.Text = Properties.Settings.Default.onetext;
            if (Properties.Settings.Default.twobox == true)
            {
                metroCheckBox2.Visible = true;
                metroCheckBox2.Checked = Properties.Settings.Default.twomain;
            }
            else metroCheckBox2.Visible = false;
            metroCheckBox2.Text = Properties.Settings.Default.twotext;
            if (Properties.Settings.Default.threebox == true)
            {
                metroCheckBox3.Visible = true;
                metroCheckBox3.Checked = Properties.Settings.Default.threemain;
            }
            else metroCheckBox3.Visible = false;
            metroCheckBox3.Text = Properties.Settings.Default.threetext;
            if (Properties.Settings.Default.fourbox == true)
            {
                metroCheckBox4.Visible = true;
                metroCheckBox4.Checked = Properties.Settings.Default.fourmain;
            }
            else metroCheckBox4.Visible = false;
            metroCheckBox4.Text = Properties.Settings.Default.fourtext;
            if (Properties.Settings.Default.fivebox == true)
            {
                metroCheckBox5.Visible = true;
                metroCheckBox5.Checked = Properties.Settings.Default.fivemain;
            }
            else metroCheckBox5.Visible = false;
            metroCheckBox5.Text = Properties.Settings.Default.fivetext;
            if (Properties.Settings.Default.sixbox == true)
            {
                metroCheckBox6.Visible = true;
                metroCheckBox6.Checked = Properties.Settings.Default.sixmain;
            }
            else metroCheckBox6.Visible = false;
            metroCheckBox6.Text = Properties.Settings.Default.sixtext;
            if (Properties.Settings.Default.sevenbox == true)
            {
                metroCheckBox7.Visible = true;
                metroCheckBox7.Checked = Properties.Settings.Default.sevenmain;
            }
            else metroCheckBox7.Visible = false;
            metroCheckBox7.Text = Properties.Settings.Default.seventext;
            if (Properties.Settings.Default.eightbox == true)
            {
                metroCheckBox8.Visible = true;
                metroCheckBox8.Checked = Properties.Settings.Default.eightmain;
            }
            else metroCheckBox8.Visible = false;
            metroCheckBox8.Text = Properties.Settings.Default.eighttext;
            if (Properties.Settings.Default.ninebox == true)
            {
                metroCheckBox9.Visible = true;
                metroCheckBox9.Checked = Properties.Settings.Default.ninemain;
            }
            else metroCheckBox9.Visible = false;
            metroCheckBox9.Text = Properties.Settings.Default.ninetext;
            if (Properties.Settings.Default.tenbox == true)
            {
                metroCheckBox10.Visible = true;
                metroCheckBox10.Checked = Properties.Settings.Default.tenmain;
            }
            else metroCheckBox10.Visible = false;
            metroCheckBox10.Text = Properties.Settings.Default.tentext;
            if (Properties.Settings.Default.onebox == false && Properties.Settings.Default.twobox == false && Properties.Settings.Default.threebox == false && Properties.Settings.Default.fourbox == false && Properties.Settings.Default.fivebox == false && Properties.Settings.Default.sixbox == false && Properties.Settings.Default.sevenbox == false && Properties.Settings.Default.eightbox == false && Properties.Settings.Default.ninebox == false && Properties.Settings.Default.tenbox == false)
            {
                nothingtext.Visible = true;
            }
            else nothingtext.Visible = false;
            if (Properties.Settings.Default.topbox == true)
                this.TopMost = true;
            else this.TopMost = false;
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.onemain = metroCheckBox1.Checked;
            Properties.Settings.Default.twomain = metroCheckBox2.Checked;
            Properties.Settings.Default.threemain = metroCheckBox3.Checked;
            Properties.Settings.Default.fourmain = metroCheckBox4.Checked;
            Properties.Settings.Default.fivemain = metroCheckBox5.Checked;
            Properties.Settings.Default.sixmain = metroCheckBox6.Checked;
            Properties.Settings.Default.sevenmain = metroCheckBox7.Checked;
            Properties.Settings.Default.eightmain = metroCheckBox8.Checked;
            Properties.Settings.Default.ninemain = metroCheckBox9.Checked;
            Properties.Settings.Default.tenmain = metroCheckBox10.Checked;
            Properties.Settings.Default.Save();
            Application.Exit();
        }
    }
}

//-----------------------------------------------------
// Coded by eduhdev12! Free to-do list source
// https://github.com/eduhdev12/to-do-list
// Note to the person using this, removing this
// text is in violation of the license you agreed
// to by downloading. Only you can see this so what
// does it matter anyways.
// Copyright © eduhdev12 2020
// Licensed under a MIT license
// Read the terms of the license here
// https://github.com/eduhdev12/to-do-list/blob/master/LICENSE
//-----------------------------------------------------
