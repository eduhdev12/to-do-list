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
    public partial class Settings : MetroFramework.Forms.MetroForm
    {

        int checkedd;

        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            //to show the Main form again and save the current changes
            Properties.Settings.Default.onebox = metroCheckBox1.Checked;
            Properties.Settings.Default.onetext = metroTextBox1.Text;
            Properties.Settings.Default.twobox = metroCheckBox2.Checked;
            Properties.Settings.Default.twotext = metroTextBox2.Text;
            Properties.Settings.Default.threebox = metroCheckBox3.Checked;
            Properties.Settings.Default.threetext = metroTextBox3.Text;
            Properties.Settings.Default.fourbox = metroCheckBox4.Checked;
            Properties.Settings.Default.fourtext = metroTextBox4.Text;
            Properties.Settings.Default.fivebox = metroCheckBox5.Checked;
            Properties.Settings.Default.fivetext = metroTextBox5.Text;
            Properties.Settings.Default.sixbox = metroCheckBox6.Checked;
            Properties.Settings.Default.sixtext = metroTextBox6.Text;
            Properties.Settings.Default.sevenbox = metroCheckBox7.Checked;
            Properties.Settings.Default.seventext = metroTextBox7.Text;
            Properties.Settings.Default.eightbox = metroCheckBox8.Checked;
            Properties.Settings.Default.eighttext = metroTextBox8.Text;
            Properties.Settings.Default.ninebox = metroCheckBox9.Checked;
            Properties.Settings.Default.ninetext = metroTextBox9.Text;
            Properties.Settings.Default.tenbox = metroCheckBox10.Checked;
            Properties.Settings.Default.tentext = metroTextBox10.Text;
            Properties.Settings.Default.topbox = topmostcheck.Checked;
            if (checkedd == 1)
            {
                Properties.Settings.Default.onemain = false;
                Properties.Settings.Default.twomain = false;
                Properties.Settings.Default.threemain = false;
                Properties.Settings.Default.fourmain = false;
                Properties.Settings.Default.fivemain = false;
                Properties.Settings.Default.sixmain = false;
                Properties.Settings.Default.sevenmain = false;
                Properties.Settings.Default.eightmain = false;
                Properties.Settings.Default.ninemain = false;
                Properties.Settings.Default.tenmain = false;
            }
            Properties.Settings.Default.Save();
            var Main = new Main();
            Main.Show();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            //to sync the saved settings when the form is loading
            metroCheckBox1.Checked = Properties.Settings.Default.onebox;
            metroTextBox1.Text = Properties.Settings.Default.onetext;
            metroCheckBox2.Checked = Properties.Settings.Default.twobox;
            metroTextBox2.Text = Properties.Settings.Default.twotext;
            metroCheckBox3.Checked = Properties.Settings.Default.threebox;
            metroTextBox3.Text = Properties.Settings.Default.threetext;
            metroCheckBox4.Checked = Properties.Settings.Default.fourbox;
            metroTextBox4.Text = Properties.Settings.Default.fourtext;
            metroCheckBox5.Checked = Properties.Settings.Default.fivebox;
            metroTextBox5.Text = Properties.Settings.Default.fivetext;
            metroCheckBox6.Checked = Properties.Settings.Default.sixbox;
            metroTextBox6.Text = Properties.Settings.Default.sixtext;
            metroCheckBox7.Checked = Properties.Settings.Default.sevenbox;
            metroTextBox7.Text = Properties.Settings.Default.seventext;
            metroCheckBox8.Checked = Properties.Settings.Default.eightbox;
            metroTextBox8.Text = Properties.Settings.Default.eighttext;
            metroCheckBox9.Checked = Properties.Settings.Default.ninebox;
            metroTextBox9.Text = Properties.Settings.Default.ninetext;
            metroCheckBox10.Checked = Properties.Settings.Default.tenbox;
            metroTextBox10.Text = Properties.Settings.Default.tentext;
            /////////////////
            topmostcheck.Checked = Properties.Settings.Default.topbox;
        }

        private void resetbutton_Click(object sender, EventArgs e)
        {
            //disables all the checkboxes and reset the text from textboxes
            metroCheckBox1.Checked = false;
            metroCheckBox2.Checked = false;
            metroCheckBox3.Checked = false;
            metroCheckBox4.Checked = false;
            metroCheckBox5.Checked = false;
            metroCheckBox6.Checked = false;
            metroCheckBox7.Checked = false;
            metroCheckBox8.Checked = false;
            metroCheckBox9.Checked = false;
            metroCheckBox10.Checked = false;
            metroTextBox1.Text = "";
            metroTextBox2.Text = "";
            metroTextBox3.Text = "";
            metroTextBox4.Text = "";
            metroTextBox5.Text = "";
            metroTextBox6.Text = "";
            metroTextBox7.Text = "";
            metroTextBox8.Text = "";
            metroTextBox9.Text = "";
            metroTextBox10.Text = "";
            checkedd = 1;
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/eduhdev12");
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
