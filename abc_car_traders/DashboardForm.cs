using abc_car_traders.AppClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace abc_car_traders
{
    public partial class DashboardForm : Form
    {
       Dashboard db = new Dashboard();
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            db.carOrderChart = carOrderChart;
            db.partsOrderChart = partsOrderChart;
            db.displayCarOrder();
            db.displayPartsOrder();
        }
    }
}
