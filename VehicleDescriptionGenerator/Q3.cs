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
    public partial class Q3 : Form
    {
        Thread th;
        public Q3()
        {
            InitializeComponent();
        }

        private void Q3Home_Click(object sender, EventArgs e)
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
