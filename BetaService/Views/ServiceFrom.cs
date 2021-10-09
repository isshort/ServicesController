using BetaService.Controller;
using BetaService.Model;
using System;
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
            this.txtGps.Text = this.dgwService.CurrentRow.Cells[2].Value.ToString();
            this.txtModel.Text = this.dgwService.CurrentRow.Cells[3].Value.ToString();
            this.txtColor.Text = this.dgwService.CurrentRow.Cells[4].Value.ToString();
            this.txtServisF.Text = this.dgwService.CurrentRow.Cells[5].Value.ToString();

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
            });
            ServiceData_Load();
            MessageBox.Show("Service was created!");
        }

        private void btnUpdateS_Click(object sender, EventArgs e)
        {
            _serviceDal.UpdateService(new Service
            {
                Id = Convert.ToInt32(dgwService.CurrentRow.Cells[0].Value),
                serviceNo = txtServisN.Text,
                serviceFlaka = txtServisF.Text,
                pgsCode = txtGps.Text,
                model = txtModel.Text,
                color = txtColor.Text,

            });
            ServiceData_Load();
            MessageBox.Show("Service was updated!");
        }

        private void btnDeleteS_Click(object sender, EventArgs e)
        {
            _serviceDal.DeleteService(new Service
            {
                Id = Convert.ToInt32(dgwService.CurrentRow.Cells[0].Value)
            });
            ServiceData_Load();
            MessageBox.Show("Service was deleted!");
        }


    }
}
