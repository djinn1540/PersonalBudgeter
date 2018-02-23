using System;
namespace BudgeterMemStorage {

    [Serializable()]
    public class AppData
    {
        private int totalBudgetCents;

        private int totalFoodCentsSpent;
        private int totalEntertainmentCentsSpent;
        private int totalProductsCentsSpent;
        private int totalVenmoFoodCentsSpent;

        private int numberOfCategories = 4;

        public AppData()
        {
            //TODO input base information (can also be used to correct numbers)
        }

        private void setTotalBudgetCents(int newCents)
        {
            totalBudgetCents = newCents;
        }

        public int getTotalBudgetCents()
        {
            return totalBudgetCents;
        }

        public int getTotalFoodCentsSpent()
        {
            return totalFoodCentsSpent;
        }

        public int getTotalEntertainmentCentsSpent()
        {
            return totalEntertainmentCentsSpent;
        }

        public int getTotalProductsCentsSpent()
        {
            return totalProductsCentsSpent;
        }

        public int getTotalVenmoFoodCentsSpent()
        {
            return totalVenmoFoodCentsSpent;
        }

        public void addCentsTo(int category, int centsToAdd)
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
                    ;
            }
        }
    }
}
