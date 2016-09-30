using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesBonus
{
    public partial class PrintMessageForm : Form
    {
        // declare a property that has the shape of the previous form
        public SalesBonusForm previousForm { get; set; }
        public PrintMessageForm()
        {
            InitializeComponent();
        }

        private void OKPrintButton_Click(object sender, EventArgs e)
        {
            // show the previous form
            this.previousForm.Show();
            this.Close();
        }
    }
}
