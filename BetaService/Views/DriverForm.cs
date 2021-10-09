using BetaService.Controller;
using BetaService.Model;
using System;
using System.Windows.Forms;

namespace ServicesApp.Views
{
    public partial class DriverForm : Form
    {
        public DriverForm()
        {
            InitializeComponent();
        }
        DriverDal _driverDal = new DriverDal();
        private void DriverForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            dgwDriver.DataSource = _driverDal.GetAll();
            var data1 = _driverDal.GetDriverName();
            Console.WriteLine("Hello", data1);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            _driverDal.AddDriver(new Driver
            {
                Heyperion = heyperionId.Text,
                Name = name.Text,
                LastName = last_name.Text,
            });
            LoadData();
            MessageBox.Show("New Driver Added!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _driverDal.UpdateDriver(new Driver
            {
                Id = Convert.ToInt32(dgwDriver.CurrentRow.Cells[0].Value),
                Heyperion = this.heyperionId.Text,
                Name = this.name.Text,
                LastName = this.last_name.Text
            });
            LoadData();
            MessageBox.Show("Updated!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _driverDal.DeleteDriver(new Driver
            {
                Id = Convert.ToInt32(dgwDriver.CurrentRow.Cells[0].Value),

            });
            LoadData();
            MessageBox.Show("Deleted!");
        }

        private void dgwDriver_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.heyperionId.Text = dgwDriver.CurrentRow.Cells[1].Value.ToString();
            this.name.Text = dgwDriver.CurrentRow.Cells[2].Value.ToString();
            this.last_name.Text = dgwDriver.CurrentRow.Cells[3].Value.ToString();
        }


    }
}
