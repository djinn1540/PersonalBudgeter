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
        private String endDate; //we use a string for the end date because serialization doesn't fully store DateTime types

        private decimal totalFoodSpent;
        private decimal totalEntertainmentSpent;
        private decimal totalProductsSpent;
        private decimal totalVenmoFoodSpent;

        private int numberOfCategories = 4;

        public MemStorage(decimal totalBudgetCents, DateTime endDate)
        {
            this.totalBudgetDollars = totalBudgetDollars;
            this.totalFoodSpent = 0;
            this.endDate = endDate.ToString("O"); //the "O" is the roundtrip format specifier: meaning that the resulting string will contain all info to exactly recreate the date
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

        public void addTo(int category, decimal dollarsToAdd)
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
        }
    }
}
