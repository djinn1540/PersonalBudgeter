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
        private decimal totalBudgetCents;
        private String endDate; //we use a string for the end date because serialization doesn't fully store DateTime types

        private decimal totalFoodCentsSpent;
        private decimal totalEntertainmentCentsSpent;
        private decimal totalProductsCentsSpent;
        private decimal totalVenmoFoodCentsSpent;

        private int numberOfCategories = 4;

        public MemStorage(decimal totalBudgetCents, DateTime endDate)
        {
            this.totalBudgetCents = totalBudgetCents;
            this.endDate = endDate.ToString("O"); //the "O" is the roundtrip format specifier: meaning that the resulting string will contain all info to exactly recreate the date
        }

        private void setTotalBudgetCents(decimal newCents)
        {
            totalBudgetCents = newCents;
        }

        public decimal getTotalBudgetCents()
        {
            return totalBudgetCents;
        }

        public decimal getTotalFoodCentsSpent()
        {
            return totalFoodCentsSpent;
        }

        public decimal getTotalEntertainmentCentsSpent()
        {
            return totalEntertainmentCentsSpent;
        }

        public decimal getTotalProductsCentsSpent()
        {
            return totalProductsCentsSpent;
        }

        public decimal getTotalVenmoFoodCentsSpent()
        {
            return totalVenmoFoodCentsSpent;
        }

        public void addCentsTo(int category, decimal centsToAdd)
        {
            if (!(0 <= category && category < numberOfCategories))
                //fail gracefully
                ;
            switch (category)
            {
                case 0:
                    totalFoodCentsSpent += centsToAdd;
                    break;
                case 1:
                    totalEntertainmentCentsSpent += centsToAdd;
                    break;
                case 2:
                    totalProductsCentsSpent += centsToAdd;
                    break;
                case 3:
                    totalVenmoFoodCentsSpent += centsToAdd;
                    break;
                default:
                    //fail gracefully
                    break;
            }
        }
    }
}
