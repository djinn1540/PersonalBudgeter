﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personal_Budgeter
{
    public partial class Form1 : Form
    {
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

        }

        private void ReceiptEntryButton_Click(object sender, EventArgs e)
        {
            if (FoodCheckBox.CheckState) {
                //parse the cents from text
                //add those cents to the appropriate state
            }
            else if{

            }
            else if{

            }
            else if{

            }
            else
        }
    }
}
