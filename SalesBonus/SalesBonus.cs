/*
Sharp Mail Order - SALES BONUS
Created by Gabriele Dibenedetto
Date: September 30th, 2016

This app calculates a bonus for each employee in the Company depending on sales.
For each dollar made in a month, the Company awards 2% of sales to the employee.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesBonus
{
    public partial class SalesBonusForm : Form
    {
        public SalesBonusForm()
        {
            InitializeComponent();
        }

        // Language Methods. Each radio button will change this form's language

        // Change to English (default)
        private void EnglishRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            EnglishRadioButton.Text = "English";
            FrenchRadioButton.Text = "French";
            ItalianRadioButton.Text = "Italian";
            GermanRadioButton.Text = "German";
            SpanishRadioButton.Text = "Spanish";
            SelectLanguageGroupBox.Text = "Select Language";
            EmployeeNameLabel.Text = "Employee's Name";
            EmployeeIDLabel.Text = "Employee ID";
            HoursWorkedLabel.Text = "Hours Worked";
            TotalMonthlySalesLabel.Text = "Total Monthly Sales";
            SalesBonusLabel.Text = "Sales Bonus";
            CalculateBMIButton.Text = "Calculate";
            PrintButton.Text = "Print";
            ClearButton.Text = "Clear";
            ExitButton.Text = "Exit";
        }

        // Change to French
        private void FrenchRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            EnglishRadioButton.Text = "Anglais";
            FrenchRadioButton.Text = "Français";
            ItalianRadioButton.Text = "Italien";
            GermanRadioButton.Text = "Allemande";
            SpanishRadioButton.Text = "Espanol";
            SelectLanguageGroupBox.Text = "Choisissez la langue";
            EmployeeNameLabel.Text = "Nom de l'employé(e)";
            EmployeeIDLabel.Text = "ID de l'employé(e)";
            HoursWorkedLabel.Text = "Heures travaillées";
            TotalMonthlySalesLabel.Text = "Total des ventes mensuelles";
            SalesBonusLabel.Text = "Bonus des ventes";
            CalculateBMIButton.Text = "Calculer";
            PrintButton.Text = "Imprimer";
            ClearButton.Text = "Éclaircir";
            ExitButton.Text = "Sortir";
        }

        // Change to Italian
        private void ItalianRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            EnglishRadioButton.Text = "Inglese";
            FrenchRadioButton.Text = "Francese";
            ItalianRadioButton.Text = "Italiano";
            GermanRadioButton.Text = "Tedesco";
            SpanishRadioButton.Text = "Spagnolo";
            SelectLanguageGroupBox.Text = "Selezionare la lingua";
            EmployeeNameLabel.Text = "Nome dell'impiegato/a";
            EmployeeIDLabel.Text = "ID dell'impiegato/a";
            HoursWorkedLabel.Text = "Ore lavorative";
            TotalMonthlySalesLabel.Text = "Totale vendite mensili";
            SalesBonusLabel.Text = "Bonus vendite";
            CalculateBMIButton.Text = "Calcola";
            PrintButton.Text = "Stampa";
            ClearButton.Text = "Azzera";
            ExitButton.Text = "Esci";
        }

        // Change to German
        private void GermanRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            EnglishRadioButton.Text = "Englisch";
            FrenchRadioButton.Text = "Französisch";
            ItalianRadioButton.Text = "Italien";
            GermanRadioButton.Text = "Deutsch";
            SpanishRadioButton.Text = "Spanisch";
            SelectLanguageGroupBox.Text = "Sprache auswählen";
            EmployeeNameLabel.Text = "Mitarbeiter(in)name";
            EmployeeIDLabel.Text = "Mitarbeiter(in) ID";
            HoursWorkedLabel.Text = "Arbeitsstunden";
            TotalMonthlySalesLabel.Text = "Summe der monatlichen Verkäufe";
            SalesBonusLabel.Text = "Umsatzprämie";
            CalculateBMIButton.Text = "Berechnen";
            PrintButton.Text = "Drucken";
            ClearButton.Text = "Zurückstellen";
            ExitButton.Text = "Verlassen";
        }

        // Change to Spanish
        private void SpanishRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            EnglishRadioButton.Text = "Inglés";
            FrenchRadioButton.Text = "Francés";
            ItalianRadioButton.Text = "Italiano";
            GermanRadioButton.Text = "Alemán";
            SpanishRadioButton.Text = "Español";
            SelectLanguageGroupBox.Text = "Seleccioner el idioma";
            EmployeeNameLabel.Text = "Nombre de empleado/a";
            EmployeeIDLabel.Text = "ID de empleado/a";
            HoursWorkedLabel.Text = "Horas trabajadas";
            TotalMonthlySalesLabel.Text = "Ventas totales mensuales";
            SalesBonusLabel.Text = "Bono ventas";
            CalculateBMIButton.Text = "Calcular";
            PrintButton.Text = "Imprimir";
            ClearButton.Text = "Reajustar";
            ExitButton.Text = "Salir";
        }

        // Calculate Button
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            CalculateTotal();
        }
        
        // Calculate Method
        private void CalculateTotal()
        {
            double PercentageHoursWorked;
            double HoursWorked;
            double TotalMonthlySales;
            double SalesBonus;
            double BonusAmount;
                        
            try
            {
                // Convert User String Values to Double
                HoursWorked = Convert.ToDouble(HoursWorkedTextBox.Text);

                if (HoursWorked < 1 || HoursWorked > 160)
                {
                    MessageBox.Show("Please insert values between 1 and 160", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    TotalMonthlySales = Convert.ToDouble(TotalMonthlySalesTextBox.Text);
                    // TotalBonusAmount = Convert.ToDouble(SalesBonusTextBox);

                    // 1. Determine the Percentage of hours worked during the bonus period
                    // Divide the Total Hours  Worked by 160
                    PercentageHoursWorked = HoursWorked / 160;

                    // 2. Calculate 2% of Sales which is the Total Bonus Amount.
                    // Multiply Total Monthly Sales by 0.02
                    BonusAmount = TotalMonthlySales * 0.02;

                    // 3. Determine the value you need to display in the Sales Bonus Text Field
                    // Multiply the Percentage of Hours Worked by the Total Bonus Amount
                    SalesBonus = PercentageHoursWorked * BonusAmount;

                    // Display DiscountAmount in related Text Box
                    TotalMonthlySalesTextBox.Text = TotalMonthlySales.ToString("C2"); // $ in two decimal places
                    // Display Bonus in related Text Box
                    SalesBonusTextBox.Text = SalesBonus.ToString("C2");
                }
            }
            catch (Exception)
            {
                // Error message in different languages
                if (EnglishRadioButton.Checked == true)
                {
                    MessageBox.Show("Please insert numeric values between 1 and 160.", "Input Error");
                    HoursWorkedTextBox.Focus(); // keep staying on the same form after error message
                    HoursWorkedTextBox.SelectAll();
                }
                else if(FrenchRadioButton.Checked == true)
                {
                    MessageBox.Show("S'il vous plaît insérer des valeurs numériques entre 1 et 160.", "Erreur d'entrée");
                    HoursWorkedTextBox.Focus();
                    HoursWorkedTextBox.SelectAll();
                }
                else if (ItalianRadioButton.Checked == true)
                {
                    MessageBox.Show("Assicurarsi di inserire valori numerici tra 1 e 160.", "Errore Input");
                    HoursWorkedTextBox.Focus();
                    HoursWorkedTextBox.SelectAll();
                }
                else if (GermanRadioButton.Checked == true)
                {
                    MessageBox.Show("Bitte geben Sie numerische Werte zwischen 1 und 160.", "Eingabe Fehler");
                    HoursWorkedTextBox.Focus();
                    HoursWorkedTextBox.SelectAll();
                }
                else if (SpanishRadioButton.Checked == true)
                {
                    MessageBox.Show("Por favor, introduzca los valores numéricos entre 1 y 160.", "Error de input");
                    HoursWorkedTextBox.Focus();
                    HoursWorkedTextBox.SelectAll();
                }
            }            
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            EmployeeNameTextBox.Text = String.Empty;
            EmployeeIDTextBox.Text = String.Empty;
            HoursWorkedTextBox.Text = String.Empty;
            TotalMonthlySalesTextBox.Text = String.Empty;
            //SalesBonusTextBox = String.Empty;
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            // instantiate the next form
            PrintMessageForm ToPrintForm = new PrintMessageForm();
            // save a reference to the current form in a property of the nextForm
            ToPrintForm.previousForm = this;

            // show the next form
            ToPrintForm.Show();
        }        
    }
}
