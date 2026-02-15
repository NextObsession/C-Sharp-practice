using System;

namespace DailyRate
{
    class Program
    {
        static void Main(String[] args)
        {
            (new Program()).run();
        }

        void run()
        {
            double DailyRate = readDouble("Enter your daily rate: ");
            int noOfDays = readInt("Enter number of days: ");
            writeFee(calculateFee(DailyRate, noOfDays));
        }

        private void writeFee(double v) => Console.WriteLine($"The consultant's fee is: {v * 1.1}");


        private double calculateFee(double dailyRate, int noOfDays) => dailyRate * noOfDays;


        private int readInt(String v)
        {
            Console.Write(v);
            String line = Console.ReadLine();
            return int.Parse(line);
        }

        private double readDouble(String v)
        {
            Console.Write(v);
            String line = Console.ReadLine();
            return double.Parse(line);
        }
    }
}
