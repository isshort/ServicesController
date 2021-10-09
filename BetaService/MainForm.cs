using BetaService.Controller;
using ServicesApp.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetaService
{
    public partial class MainForm : Form
    {
        DailyReport daily = new DailyReport();
        DriverForm driverForm = new DriverForm();
        ServiceFrom serviceFrom = new ServiceFrom();
        public MainForm()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.daily.Show();
        }
        private void btnDriver_Click(object sender, EventArgs e)
        {
            this.driverForm.Show();
        }
        private void btnService_Click(object sender, EventArgs e)
        {
            this.serviceFrom.Show();
        }

        private void btnKasa_Click(object sender, EventArgs e)
        {

        }

        private void mainToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void driveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
