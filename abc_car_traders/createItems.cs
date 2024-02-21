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
    public partial class createItems : Form
    {
        myComClass menu = new myComClass();
        public createItems()
        {
            InitializeComponent();
        }

        private void createCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menu.formLoadInPanel(new createCarForm(), formloadArea);
        }
    }
}

