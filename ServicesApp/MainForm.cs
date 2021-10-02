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

namespace ServicesApp
{
    public partial class MainForm : Form
    {
        DailyReport main = new DailyReport();
        DriverForm driverForm = new DriverForm();
        ServiceFrom serviceFrom = new ServiceFrom();
        public MainForm()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.main.Show();
        }
        private void btnDriver_Click(object sender, EventArgs e)
        {
            this.driverForm.Show();
        }
        private void btnService_Click(object sender, EventArgs e)
        {
            this.serviceFrom.Show();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
