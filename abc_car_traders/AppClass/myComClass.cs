using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace abc_car_traders.AppClass
{
    internal class MyComClass
    {

      public  string addMessage = "Please Add Any Value";

        public void formLoadInPanel(Form form, Panel panel)
        {
            panel.Controls.Clear();
            form.TopLevel = false;
            form.AutoScroll = true;
            panel.Controls.Add(form);
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        public  bool IsAnyValueEmpty(params string[] values)
        {
            foreach (string value in values)
            {
                if (string.IsNullOrEmpty(value))
                {
                    return true;
                }
            }
            return false;
        }

        public bool CheckValidateFields(params Control[] controls)
        {
            return IsAnyValueEmpty(controls.Select(tb => tb.Text).ToArray());
        }

        public void clearcontroles(params Control[] controls)
        {
            foreach (Control control in controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Text = "";
                }
                else if (control is ComboBox comboBox)
                {
                    comboBox.SelectedIndex = -1;
                }
                else if (control is DataGridView dataGridView)
                {
                    dataGridView.DataSource = null;
                    dataGridView.Rows.Clear();
                    dataGridView.Columns.Clear();
                }
            }
        }

      

    }
}
