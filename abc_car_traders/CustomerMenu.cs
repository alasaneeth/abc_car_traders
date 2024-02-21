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
    public partial class CustomerMenu : Form
    {
        int LoginUserId;
        public CustomerMenu()
        {
            InitializeComponent();
        }

        public CustomerMenu(int loginUserId)
        {
            InitializeComponent();
            LoginUserId = loginUserId;
        }


        private void formLoadArea_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void CustomerMenu_Load(object sender, EventArgs e)
        {
         
        }



        private void formLoadInPanel(Form form, Panel panel)
        {
            panel.Controls.Clear();
            form.TopLevel = false;
            form.AutoScroll = true; 
            panel.Controls.Add(form);
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void carPartsDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formLoadInPanel(new PartsOrderForm(), formLoadArea);
        }

        private void formLoadArea_Paint_1(object sender, PaintEventArgs e)
        {

        }


        private void partsOrderBtn_Click(object sender, EventArgs e)
        {
            formLoadInPanel(new PartsOrderForm(), formLoadArea);
        }

        private void formLoadArea_Paint_2(object sender, PaintEventArgs e)
        {

        }
    }
}
