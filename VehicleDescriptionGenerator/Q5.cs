﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace VehicleDescriptionGenerator
{
    public partial class Q5 : Form
    {
        Thread th;
        public Q5()
        {
            InitializeComponent();
        }

        private void Q5Home_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openHomeForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openHomeForm(object obj)
        {
            Application.Run(new Page1());
        }


    }
}
