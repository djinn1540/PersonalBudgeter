﻿using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;


namespace Personal_Budgeter
{
    public partial class Form1 : Form
    {

        private MemStorage data;

        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
          
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Validated(object sender, EventArgs e)
        {

        }

        private void label1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private Boolean stringIsValidNumber(String str)
        {
            
            char[] ValidChars = {'0','1','2','3','4','5','6','7','8','9','.'};
            for(int i = 0; i < str.Length; i++)
            {
                if (!ValidChars.Contains(str.ElementAt(i)))
                {
                    return false;
                }
            }
            return true;
        }

        private decimal parseNumber(String str) //Round up the double from the string: we only care if it drops below zero
        {
            return Math.Ceiling(Decimal.Parse(str));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(Constants.FILENAME))
            {
                if (new FileInfo(Constants.FILENAME).Length == 0)
                { //run the inputs
                    data = this.inputsFunction();
                }
                else
                {
                    //open the serializable
                    Stream stream = File.Open(Constants.FILENAME, FileMode.Open);
                    BinaryFormatter formatter = new BinaryFormatter();

                    data = (MemStorage)formatter.Deserialize(stream);
                    stream.Close();
                }
            }
            else
            {
                data = this.inputsFunction();
            }
            System.Console.Write("heyo");
            updateScreen();
        }

        private void ReceiptEntryButton_Click(object sender, EventArgs e)
        {

            //parse the amount from text
            DecimalConverter conv = new DecimalConverter();
            decimal enteredDollars = (decimal)conv.ConvertFromString(ReceiptEntryTextBox.Text);
            

            if (FoodRadioButton.Checked) {
                //add the amount to the appropriate state
                data.addTo(0, enteredDollars);
            }
            else if (EntRadioButton.Checked) {
                data.addTo(1, enteredDollars);
            }
            else if (ProdRadioButton.Checked) {
                data.addTo(2, enteredDollars);
            }
            else if (VenFoodRadioButton.Checked) {
                data.addTo(3, enteredDollars);
            }
            else;
            //update the screen
            updateScreen();

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //serialize data back into file
            Stream stream = File.Open(Constants.FILENAME, FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, data);
            stream.Close();
        }

        private MemStorage inputsFunction()
        {
            
            String input = null;
            decimal totalBudgetDollars = 0;


            while (input == null) {
                input = Prompt.getUserInput("Input", "Please enter the total budget in USD: ");
                try
                {
                    totalBudgetDollars = Decimal.Parse(input);
                }
                catch(Exception e)
                {
                    input = null;
                }
            }
            
            input = null;
            DateTime endDate = new DateTime();

            while (input  == null)
            {
                input = Prompt.getUserInput("Input", "Please enter the end date for the budget (Mon dd, yyyy) ex Jan 12, 2019: ");
                try {
                    endDate = DateTime.Parse(input);
                }
                catch(Exception e)
                {
                    input = null;
                }
            }
            
            MemStorage applicationStorage = new MemStorage(totalBudgetDollars, endDate);

            return applicationStorage;
            //remember that we are storing the numbers as integer penny amounts
            /*todo:
                 * calculate weekly balanvce left by accessing the system date time
                 * maybe put in a savings calculation ***feature creep! 
                */ 
        }


        private void updateScreen()
        {
            //expense value labels are updated with values from the data object
            CumFoodExpLabel.Text = data.getTotalFoodSpent().ToString("#####0.00");
            CumEntExpLabel.Text = data.getTotalEntertainmentSpent().ToString("#####0.00");
            CumProdExpLabel.Text = data.getTotalProductsSpent().ToString("#####0.00");
            CumVenFoodExpLabel.Text = data.getTotalVenmoFoodSpent().ToString("#####0.00");

            //remainder value labels are updated with values from the data object
            TotalRemNumberLabel.Text = data.getTotalRemBudget().ToString("#####0.00");
            if (data.getNumOfWeeks() > 0) {
                WeeklyRemNumberLabel.Text = ((data.getRemBudgetWeekStart() / data.getNumOfWeeks()) - data.getWeeklyExpenses()).ToString("#####0.00");
            }
            else
            {
                WeeklyRemNumberLabel.Text = (data.getRemBudgetWeekStart() - data.getWeeklyExpenses()).ToString("#####0.00");
            }

            //colors of the text
            if (data.getTotalRemBudget().CompareTo(0) <= 0)
                TotalRemNumberLabel.ForeColor = System.Drawing.Color.Red;
            else
                TotalRemNumberLabel.ForeColor = System.Drawing.Color.Green;
            if (parseNumber(WeeklyRemNumberLabel.Text).CompareTo(0) <= 0)
                WeeklyRemNumberLabel.ForeColor = System.Drawing.Color.Red;
            else
                WeeklyRemNumberLabel.ForeColor = System.Drawing.Color.Green;

        }
    }
}
