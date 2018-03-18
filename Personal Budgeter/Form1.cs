using System;
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

        private void Remainder_TextChanged(object sender, EventArgs e)
        {
            if (stringIsValidNumber(this.Text))
            {
                if (parseNumber(WeeklyRemNumberLabel.Text).CompareTo(0) <= 0)
                    this.ForeColor = System.Drawing.Color.Red;
                else
                    this.ForeColor = System.Drawing.Color.Green;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(Constants.FILENAME))
            {
                System.Console.Write("hey");
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
        }

        private void ReceiptEntryButton_Click(object sender, EventArgs e)
        {

            //parse the cents from text
            DecimalConverter conv = new DecimalConverter();
            decimal enteredDollars = (decimal)conv.ConvertFromString(ReceiptEntryTextBox.Text);
            decimal centsToAdd = dollars2Cents(enteredDollars);

            if (FoodRadioButton.Checked) {

                //add those cents to the appropriate state
                data.addCentsTo(0, centsToAdd);

            }
            else if (EntRadioButton.Checked) {
                data.addCentsTo(1, centsToAdd);
            }
            else if (ProdRadioButton.Checked) {
                data.addCentsTo(2, centsToAdd);
            }
            else if (VenFoodRadioButton.Checked) {
                data.addCentsTo(3, centsToAdd);
            }
            else;
            //update the screen

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
            
            while (input == null) {
                input = Prompt.getUserInput("Input", "Please enter the total budget in USD: ");
            }
            decimal totalBudgetDollars = Decimal.Parse(input);
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

        //todo updateScreen

        private void updateScreen()
        {
            //expense value labels are updated with values from the data object
            CumFoodExpLabel.Text = data.getTotalFoodSpent().ToString("######.00");
            CumEntExpLabel.Text = data.getTotalEntertainmentSpent().ToString("######.00");
            CumProdExpLabel.Text = data.getTotalProductsSpent().ToString("######.00");
            CumVenFoodExpLabel.Text =  data.getTotalVenmoFoodSpent().ToString("######.00");


        }
    }
}
