using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace abc_car_traders.AppClass
{
    internal class myComClass
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

        public bool CheckValidateFields(params TextBox[] textBoxes)
        {
            return IsAnyValueEmpty(textBoxes.Select(tb => tb.Text).ToArray());
        }

        public void ClearTextBoxes(params TextBox[] textBoxes)
        {
            foreach (TextBox textBox in textBoxes)
            {
                textBox.Text = "";
            }
        }
    }
}
