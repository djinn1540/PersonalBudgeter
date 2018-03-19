using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Budgeter
{
    [Serializable()]
    class MemStorage
    {
        private decimal totalBudgetDollars;
        private decimal remBudgetWeekStart;
        private String endDate; //we use a string for the end date because serialization doesn't fully store DateTime types
        private String endOfWeek; //string for the date that is 7x (for x an integer) days before the endDate of the budget
        private int numberofWeeks;
        private decimal weeklyExpenses;

        private decimal totalFoodSpent;
        private decimal totalEntertainmentSpent;
        private decimal totalProductsSpent;
        private decimal totalVenmoFoodSpent;

        private const int numberOfCategories = 4;

        public MemStorage(decimal totalBudget, DateTime endDate)
        {
            this.totalBudgetDollars = totalBudget;
            this.remBudgetWeekStart = totalBudget;
            this.totalFoodSpent = 0;
            this.totalEntertainmentSpent = 0;
            this.totalProductsSpent = 0;
            this.totalVenmoFoodSpent = 0;
            this.numberofWeeks = 0;
            this.weeklyExpenses = 0;
            this.endDate = endDate.ToString("O"); //the "O" is the roundtrip format specifier: meaning that the resulting string will contain all info to exactly recreate the date



            DateTime temp = endDate;
            while (DateTime.Compare(temp, System.DateTime.Today) > 0)
            {
                temp = temp.Subtract(Constants.aWeek); //decrement the date in temp by a week until temp is before the current date
                numberofWeeks++;
            }
            temp = temp.Add(Constants.aWeek); //add a week to give the end of the first week (this first week can be less than 7 days but all others will be 7 days)
            this.endOfWeek = temp.ToString("O"); //"O" is rountrip format specifier

            Console.Write(numberofWeeks + "\n");
        }

        private void setTotalBudgetDollars(decimal newDollarAmount)
        {
            totalBudgetDollars = newDollarAmount;
        }

        public decimal getTotalBudgetDollars()
        {
            return totalBudgetDollars;
        }

        public decimal getTotalFoodSpent()
        {
            return totalFoodSpent;
        }

        public decimal getTotalEntertainmentSpent()
        {
            return totalEntertainmentSpent;
        }

        public decimal getTotalProductsSpent()
        {
            return totalProductsSpent;
        }

        public decimal getTotalVenmoFoodSpent()
        {
            return totalVenmoFoodSpent;
        }

        public decimal getRemBudgetWeekStart()
        {
            return remBudgetWeekStart;
        }

        public decimal getTotalRemBudget()
        {
            return (totalBudgetDollars - (totalFoodSpent + totalEntertainmentSpent + totalProductsSpent + totalVenmoFoodSpent));
        }

        public int getNumOfWeeks()
        {
            return numberofWeeks;
        }
        public decimal getWeeklyExpenses()
        {
            return weeklyExpenses;
        }

        public void updateEndOfWeek()
        {
            DateTime temp = DateTime.Parse(endOfWeek);
            while (DateTime.Compare(temp, DateTime.Today) < 0)
            {
                temp = temp.Add(Constants.aWeek); //add weeks until endOfWeek(temp) is after the current date
                weeklyExpenses = 0; 
                numberofWeeks--; //decrement the number of weeks so we can calculate the budget per week 
            }
            endOfWeek = temp.ToString("O"); //"O" is the roundtrip formatter for DateTime
            remBudgetWeekStart = getTotalRemBudget();
        }


        public void addTo(int category, decimal dollarsToAdd) //adds the dollar amount to the indicated cateory
        {
            if (!(0 <= category && category < numberOfCategories))
                //fail gracefully
                ;
            switch (category)
            {
                case 0:
                    totalFoodSpent += dollarsToAdd;
                    break;
                case 1:
                    totalEntertainmentSpent += dollarsToAdd;
                    break;
                case 2:
                    totalProductsSpent += dollarsToAdd;
                    break;
                case 3:
                    totalVenmoFoodSpent += dollarsToAdd;
                    break;
                default:
                    //fail gracefully
                    break;
            }

            weeklyExpenses += dollarsToAdd;
        }
    }
}
