using System;
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
    public partial class Page1 : Form
    {
        Thread th;
        public Page1()
        {
            InitializeComponent();
        }

        private void A3_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openA3Form);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void openA3Form(object obj)
        {
            Application.Run(new A3());
        }
        private void A4_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openA4Form);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void openA4Form(object obj)
        {
            Application.Run(new A4());
        }

        private void A5_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openA5Form);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void openA5Form(object obj)
        {
            Application.Run(new A5());
        }

        private void A6_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openA6Form);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void openA6Form(object obj)
        {
            Application.Run(new A6());
        }

        private void A7_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openA7Form);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void openA7Form(object obj)
        {
            Application.Run(new A7());
        }
        private void A8_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openA8Form);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void openA8Form(object obj)
        {
            Application.Run(new A8());
        }

        private void Q3_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openQ3Form);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void openQ3Form(object obj)
        {
            Application.Run(new Q3());
        }

        private void Q5_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openQ5Form);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void openQ5Form(object obj)
        {
            Application.Run(new Q5());
        }

        private void Q7_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openQ7Form);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openQ7Form(object obj)
        {
            Application.Run(new Q7());
        }


        private void other_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openOtherForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void openOtherForm(object obj)
        {
            Application.Run(new Other());
        }
    }
}
