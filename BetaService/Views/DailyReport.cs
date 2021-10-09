using BetaService;
using System;
using System.Windows.Forms;

namespace ServicesApp.Views
{
    public partial class DailyReport : Form
    {
        public DailyReport()
        {
            InitializeComponent();
        }


        private void MainView_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {

            //this.textBox1.AutoCompleteCustomSource.AddRange(new string[] {
            //    "Nematullah  Wahidi",
            //    "Oguzhan",
            //    "Engin Bey"});
            using (DevContext mainContext = new DevContext())
            {

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
