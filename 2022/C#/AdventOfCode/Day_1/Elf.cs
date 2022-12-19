using System.Collections;

namespace AdventOfCode.Day_1
{
    internal class Elf
    {

        private string name;

        private ArrayList calories;

        public Elf(string name) {
            this.name = name;
            calories = new ArrayList();
        }


        public ArrayList getCalories()
        {
            return calories;
        }

        public void addCalories(string calorie)
        { 
            calories.Add(calorie);
        }

        public int getCaloriesCount()
        {
            int total = 0;

            foreach (string calorie in calories)
            {
                total += Int32.Parse(calorie);
            }

            return total;
        }

    }
}
