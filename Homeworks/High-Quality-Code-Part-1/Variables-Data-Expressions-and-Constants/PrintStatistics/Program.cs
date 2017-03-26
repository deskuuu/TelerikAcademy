namespace PrintStatistics
{
    using System;

    public class Statistic
    {
        public void PrintStatistics(double[] arrOfStatistics, int countStatistics)
        {
            var max = this.FindMaxStatistic(arrOfStatistics, countStatistics);
            var min = this.FindMinStatistic(arrOfStatistics, countStatistics);
            var average = this.FindAverage(arrOfStatistics, countStatistics);

            this.Print("Max", max);
            this.Print("Min", min);
            this.Print("Average", average);
        }

        private double FindMaxStatistic(double[] arrOfStatistics, int countStatistics)
        {
            double maxStatistic = double.MinValue;

            for (int index = 0; index < countStatistics; index++)
            {
                if (arrOfStatistics[index] > maxStatistic)
                {
                    maxStatistic = arrOfStatistics[index];
                }
            }

            return maxStatistic;
        }

        private double FindMinStatistic(double[] arrOfStatistics, int countStatistics)
        {
            double minStatistic = double.MinValue;

            for (int index = 0; index < countStatistics; index++)
            {
                if (arrOfStatistics[index] < minStatistic)
                {
                    minStatistic = arrOfStatistics[index];
                }
            }

            return minStatistic;
        }

        private double FindAverage(double[] arrOfStatistics, int countStatistics)
        {
            double average = 0;
            double sum = 0;

            for (int index = 0; index < countStatistics; index++)
            {
                sum += arrOfStatistics[index];
            }

            average = sum / countStatistics;

            return average;
        }

        private void Print(string name, double value)
        {
            Console.WriteLine($"{name} - {value}");
        }
    }
}
