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
    public partial class AdminMenu : Form
    {
        AppClass.MyComClass com = new AppClass.MyComClass();
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void customerBtn_Click(object sender, EventArgs e)
        {
            com.formLoadInPanel(new CustomerDetailsForm(), formloadArea);
        }

        private void carBtn_Click(object sender, EventArgs e)
        {
            com.formLoadInPanel(new CarForm(), formloadArea);
        }
    }
}
