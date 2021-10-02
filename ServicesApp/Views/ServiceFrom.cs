using ServicesApp.Controller;
using ServicesApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServicesApp.Views
{
    public partial class ServiceFrom : Form
    {
        ServiceDal _serviceDal = new ServiceDal(); 
        public ServiceFrom()
        {
            InitializeComponent();
        }
        public void ServiceData_Load()
        {
            dgwService.DataSource = _serviceDal.GetAllServices();
        }
        private void ServisFrom_Load(object sender, EventArgs e)
        {
            
            ServiceData_Load();
        }
        private void dgwDriver_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtServisN.Text = this.dgwService.CurrentRow.Cells[1].Value.ToString();
            this.txt

            this.txtServisF.Text = this.dgwService.CurrentRow.Cells[4].Value.ToString();

        }
        private void btnAdd_S_Click(object sender, EventArgs e)
        {
            _serviceDal.AddNewSerivce(new Service
            {
                serviceNo = txtServisN.Text,
                serviceFlaka = txtServisF.Text,
                pgsCode = txtGps.Text,
                model = txtModel.Text,
                color = txtColor.Text,
            }) ;
        }

        private void btnUpdateS_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteS_Click(object sender, EventArgs e)
        {

        }

      
    }
}
