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
            if (File.Exists("data.xml"))
            {
                byte[] fileBytes = File.ReadAllBytes("data.xml");
                if (fileBytes == null)
                { //run the inputs
                    inputsFunction (returns MemStorage obj)
                }
                else
                {
                    //open the serializable
                    Stream stream = File.Open("data.xml", FileMode.Open);
                    BinaryFormatter formatter = new BinaryFormatter();

                    data = (MemStorage)formatter.Deserialize(stream);
                    stream.Close();
                }
            }
            else
            {// run the inputs

            }
        }

        private void ReceiptEntryButton_Click(object sender, EventArgs e)
        {
            //parse the cents from text
            if (FoodRadioButton.Checked) {

                //add those cents to the appropriate state
            }
            else if (EntRadioButton.Checked) {

            }
            else if (ProdRadioButton.Checked) {

            }
            else if (VenFoodRadioButton.Checked) {

            }
            else;
            //update the screen

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //serialize data back into file
            Stream stream = File.Open("data.xml", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, data);
            stream.Close();
        }

        private void inputsFunction()
        {
            DecimalConverter converter = new DecimalConverter();
            System.Console.Write("Please enter the amount that you wish to budget: ");
            decimal totalBudgetDub = (decimal) converter.ConvertFromString(System.Console.ReadLine());
            totalBudgetDub *= 100;
            int totalBudgetCents = (int) Math.Floor(totalBudgetDub);
            //remember that we are storing the numbers as integer penny amounts
            //convert to pennies function to be used in reciept entry and input entry   
            /*todo:
                 * calculate weekly balanvce left by accessing the system date time
                 * get entry for how many weeks the budget is for
                 * maybe put in a savings calculation
                */ 
        }
    }
}
