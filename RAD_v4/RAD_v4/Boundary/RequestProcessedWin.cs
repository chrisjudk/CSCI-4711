﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RAD_v4
{
    public partial class RequestProcessedWin : Form
    {
        string name;

        public RequestProcessedWin(string n)
        {
            InitializeComponent();
            name = n;
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            Controller.LogoutControl.Logout(name);
            Close();
        }
    }
}
