using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var service = new ServiceReference.WebServiceSoapClient();
            label3.Text = "Результат: " + service.Calculate((double)numericUpDown1.Value, (int)numericUpDown2.Value);
        }
    }
}
