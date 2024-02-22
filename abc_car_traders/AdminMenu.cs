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
        myComClass menu = new myComClass();
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            menu.formLoadInPanel(new CarForm(), formloadArea);
        }

      

        private void formloadArea_Paint(object sender, PaintEventArgs e)
        {

        }

        private void createItem_Click(object sender, EventArgs e)
        {

        }
    }
}
