using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServicesController
{
    public partial class Form1 : Form
    {
        DriverDal _driverDal = new DriverDal();

        public Form1()
        {
            InitializeComponent();
        }

    

        private void Form1_Load(object sender, EventArgs e)
        {
            LoudData();
        }
        public void LoudData()
        {
            dgwDriver.DataSource = _driverDal.GetAllDrivers();
        }
       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void addBtn_Click_1(object sender, EventArgs e)
        {
           
  
            _driverDal.AddDriver(
             new Driver
             {
                 Herperion = this.herperionId.Text,
                 Name = this.name.Text,
                 LastName = this.last_name.Text,

             });

            MessageBox.Show("New Driver was added!");
        }

        private void dgwDriver_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.herperionId.Text=dgwDriver.CurrentRow.Cells[1].Value.ToString();
            this.name.Text=dgwDriver.CurrentRow.Cells[2].Value.ToString();
            this.last_name.Text=dgwDriver.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Driver driver = new Driver
            {
                Id = Convert.ToInt32(dgwDriver.CurrentRow.Cells[0].Value),
                Herperion = this.herperionId.Text,
                Name = this.name.Text,
                LastName = this.last_name.Text

            };
            _driverDal.UpdateDriver(driver);
            LoudData();
            MessageBox.Show("Updated!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Driver driver = new Driver
            {
                Id = Convert.ToInt32(dgwDriver.CurrentRow.Cells[0].Value),
                

            };
            _driverDal.DeleteDriver(driver);
            LoudData();
            MessageBox.Show("Deleted!");
        }
    }
}
