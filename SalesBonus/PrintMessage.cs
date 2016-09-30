using System;
using System.Windows.Forms;
using SalesBonus;

namespace SalesBonus
{
    public partial class PrintMessageForm : Form
    {
        // SalesBonus.PrintMessageForm print = new SalesBonus.PrintMessageForm();

        // declare a property that has the shape of the previous form
        public SalesBonusForm previousForm { get; set; }

        /*
        public object EnglishRadioButton { get; private set; }
        public object FrenchRadioButton { get; private set; }
        public object ItalianRadioButton { get; private set; }
        public object GermanRadioButton { get; private set; }
        public object SpanishRadioButton { get; private set; }
        */

        public PrintMessageForm()
        {
            InitializeComponent();
        }

        
        private void OKPrintButton_Click(object sender, EventArgs e)
        {
            /*
            if (SalesBonusForm.EnglishRadioButton.Checked == true)
            {
                PrintMessageLabel.Text = "Your Form Is Being Sent to the Printer";
            }
            else if(SalesBonusForm.FrenchRadioButton.Checked == true)
            {
                PrintMessageLabel.Text = "Votre formulaire est envoyé à l'imprimante";
            }
            else if (SalesBonusForm.ItalianRadioButton.Checked == true)
            {
                PrintMessageLabel.Text = "Il modulo è stato inviato alla stampante";
            }
            else if (SalesBonusForm.GermanRadioButton.Checked == true)
            {
                PrintMessageLabel.Text = "Das Formular wird an den Drucker gesendet";
            }
            else if (SalesBonusForm.SpanishRadioButton.Checked == true)
            {
                PrintMessageLabel.Text = "Su formulario se envía a la impresora";
            }
            */

            // show the previous form
            this.previousForm.Show();
            this.Close();
        }
    }
}
