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
    public partial class ReportForm : Form
    {
        AppClass.MyComClass com = new AppClass.MyComClass();
        CustomerReports customer = new CustomerReports();
        public ReportForm()
        {
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
           
        }

        private void listOfCuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            com.formLoadInPanel(new ListOfCustomerReport(), reportLoadArea);

        }

        private void customerOrderByItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            com.formLoadInPanel(new CustomerSummery(), reportLoadArea);
        }

        private void orderByStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            com.formLoadInPanel(new OrderByStatus(), reportLoadArea);
        }
    }
}
